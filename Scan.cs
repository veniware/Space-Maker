using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

public partial class Scan : UserControl {

    private struct DirEnrty {
        public DirEnrty[] subdir;
        public FileEnrty[] files;

        public string name;
        public string fullname;
        public long cre_date;
        public long mod_date;
        public ulong size;
        //TODO: permissions
    }

    private struct FileEnrty {
        public string name;
        public string fullname;
        public long cre_date;
        public long mod_date;
        public long size;
        //public string hash;
    }

    private string root;
    private readonly List<string> subroots = new List<string>();
    private readonly Hashtable hashtable = new Hashtable();

    public Scan(string targer) {
        InitializeComponent();
        this.Dock = DockStyle.Fill;

        for (int i = 0; i < this.Controls.Count; i++)
            this.Controls[i].Visible = this.Controls[i] == prgBar;

        Thread thScan = new Thread(() => StartScan(targer));
        thScan.Priority = ThreadPriority.Normal;
        thScan.Start();
    }

    private delegate void SafeCallDelegate(string target);

    private void StartScan(string target) {
        if (!(target is null)) { //procedure
#if !DEBUG
            try {
#endif
            DirectoryInfo dir = new DirectoryInfo(target);

            long preScanTimeStamp = DateTime.Now.Ticks;
            ScanDirectory(dir);

            DateTime timer = new DateTime(DateTime.Now.Ticks - preScanTimeStamp);
            txtPath.Text = timer.ToLongTimeString() + " : " + timer.Millisecond;

            root = target;
            foreach (DirectoryInfo d in dir.GetDirectories()) 
                subroots.Add(d.FullName);
#if !DEBUG
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Directory error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
#endif
        }

        if (this.InvokeRequired) {
            SafeCallDelegate d = new SafeCallDelegate(StartScan);
            this.Invoke(d, new object[] { null });
        } else {
            for (int i = 0; i < this.Controls.Count; i++)
                this.Controls[i].Visible = this.Controls[i] != prgBar;

            TreeNode rootNode = lstTree.Nodes.Add(root.EndsWith("\\") ? root.Substring(0, root.Length -1) : root);
            Populate(rootNode);

            DirEnrty entry = (DirEnrty)this.hashtable[root];
            this.pnlVisual.BackgroundImage = this.DrawMap((DirEnrty)hashtable[root]);
        }
    }

    private Tuple<ulong, DirEnrty[], FileEnrty[]> ScanDirectory(DirectoryInfo dir) {
        ulong size = 0;

        DirectoryInfo[] dirInfo = dir.GetDirectories();
        DirEnrty[] dirs = new DirEnrty[dirInfo.Length];
        for (long i = 0; i < dirInfo.Length; i++) {
            Tuple<ulong, DirEnrty[], FileEnrty[]> nested = null;                
            try {
                nested = ScanDirectory(dirInfo[i]);
            } catch { }

            dirs[i] = new DirEnrty() {
                name     = dirInfo[i].Name,
                fullname = dirInfo[i].FullName,
                cre_date = dirInfo[i].CreationTime.Ticks,
                mod_date = dirInfo[i].LastWriteTime.Ticks,
                size     = nested?.Item1 ?? 0,
                subdir   = nested?.Item2 ?? new DirEnrty[] { },
                files    = nested?.Item3 ?? new FileEnrty[] { }
            };
            
            size += nested?.Item1 ?? 0;
        }

        FileEnrty[] files = null;
        try {
            FileInfo[] fileInfo = dir.GetFiles();
            files = new FileEnrty[fileInfo.Length];
            for (long i = 0; i < fileInfo.Length; i++) {
                files[i] = new FileEnrty() {
                    name      = fileInfo[i].Name,
                    fullname  = fileInfo[i].FullName,
                    cre_date  = fileInfo[i].CreationTime.Ticks,
                    mod_date  = fileInfo[i].LastWriteTime.Ticks,
                    size      = fileInfo[i].Length
                };
                size += (ulong)fileInfo[i].Length;
            }
        } catch { }

        DirEnrty entry = new DirEnrty() {
            name     = dir.Name,
            fullname = dir.FullName,
            cre_date = dir.CreationTime.Ticks,
            mod_date = dir.LastWriteTime.Ticks,
            size     = size,
            subdir   = dirs ?? new DirEnrty[] { },
            files    = files ?? new FileEnrty[] { }
        };
        hashtable.Add(dir.FullName, entry);

        return Tuple.Create(size, dirs, files);
    }

    private Bitmap DrawMap(DirEnrty entry) {
        return null;
    }

    private void Populate(TreeNode node) {
        string path = node.FullPath;
        if (path.Length == 2) path += "\\";
        
        if (node.Nodes.Count > 0) return; //already populated
        if (!this.hashtable.ContainsKey(path)) return; //not found in hashtable

        DirEnrty entry = (DirEnrty)this.hashtable[path];

        for (int i = 0; i < entry.subdir.Length; i++) {
            TreeNode subnode = node.Nodes.Add(entry.subdir[i].name);
            if (hashtable.ContainsKey(entry.subdir[i].fullname)) {
                DirEnrty sub = (DirEnrty)hashtable[entry.subdir[i].fullname];
                foreach (DirEnrty o in sub.subdir) subnode.Nodes.Add(o.name);
            }
        }
    }

    private void LstTree_AfterSelect(object sender, TreeViewEventArgs e) {
        txtPath.Text = e.Node.FullPath;

        lstFiles.Items.Clear();

        string path = e.Node.FullPath;
        if (path.Length == 2) path += "\\";

        if (!this.hashtable.ContainsKey(path)) return;

        DirEnrty entry = (DirEnrty)this.hashtable[path];
        
        for (int i = 0; i < entry.subdir.Length; i++) {
            ListViewItem item = new ListViewItem(
                new string[] {
                    $"{entry.subdir[i].name}\\",
                    entry.subdir[i].size.ToString(),
                    entry.subdir[i].cre_date.ToString(),
                    entry.subdir[i].mod_date.ToString()});
            item.ImageIndex = 1;
            lstFiles.Items.Add(item);
        }

        for (int i = 0; i < entry.files.Length; i++) {
            ListViewItem item = new ListViewItem(
                new string[] {
                    entry.files[i].name,
                    entry.files[i].size.ToString(),
                    entry.files[i].cre_date.ToString(),
                    entry.files[i].mod_date.ToString()});
            item.ImageIndex = 0;
            lstFiles.Items.Add(item);
        }
    }

    private void LstTree_AfterExpand(object sender, TreeViewEventArgs e) {
        for (int i = 0; i < e.Node.Nodes.Count; i++)
            Populate(e.Node.Nodes[i]);
    }

}
