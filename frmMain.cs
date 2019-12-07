using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class frmMain : Form {
    public frmMain() {
        InitializeComponent();
    }

    public struct Task {
        public string name;
        public int icon;
        public TabPage page;
        public Control control;
    }

    public Task NewTask(string name, Control control, TabPage page = null, int icon = 0) {
        if (page is null)
            page = new TabPage() {
                Text = name,
                UseVisualStyleBackColor = true
            };

        Task newTask = new Task() {
            name = name,
            icon = icon,
            page = page,
            control = control
        };

        tabsContainer.TabPages.Add(page);
        page.Controls.Add(control);

        tabsContainer.SelectedIndex = tabsContainer.TabPages.IndexOf(page);

        return newTask;
    }

    private void NewScan() {
        using (frmNewScanDialog frmNew = new frmNewScanDialog()) {
            frmNew.Icon = this.Icon;
            if (frmNew.ShowDialog() == DialogResult.OK) {
                NewTask($"Scan: {frmNew.txtTarget.Text}", new Scan(frmNew.txtTarget.Text));
            }
        }
    }

    private void button1_Click(object sender, EventArgs e) {
        NewScan();
    }
}