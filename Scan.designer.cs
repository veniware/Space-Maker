    partial class Scan {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scan));
            this.lstTree = new System.Windows.Forms.TreeView();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCreTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMd5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContentIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtPath = new System.Windows.Forms.TextBox();
            this.pnlMap = new Space_maker.DoubleBuffer();
            this.splContainer2 = new System.Windows.Forms.SplitContainer();
            this.splContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splContainer2)).BeginInit();
            this.splContainer2.Panel1.SuspendLayout();
            this.splContainer2.Panel2.SuspendLayout();
            this.splContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splContainer1)).BeginInit();
            this.splContainer1.Panel1.SuspendLayout();
            this.splContainer1.Panel2.SuspendLayout();
            this.splContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTree
            // 
            this.lstTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTree.Location = new System.Drawing.Point(0, 31);
            this.lstTree.Name = "lstTree";
            this.lstTree.Size = new System.Drawing.Size(198, 416);
            this.lstTree.TabIndex = 0;
            this.lstTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.LstTree_AfterExpand);
            this.lstTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LstTree_AfterSelect);
            // 
            // prgBar
            // 
            this.prgBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prgBar.Location = new System.Drawing.Point(200, 209);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(400, 32);
            this.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgBar.TabIndex = 3;
            this.prgBar.Visible = false;
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmSize,
            this.clmCreTime,
            this.clmModTime,
            this.clmMd5});
            this.lstFiles.HideSelection = false;
            this.lstFiles.LargeImageList = this.ContentIcons;
            this.lstFiles.Location = new System.Drawing.Point(3, 31);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(590, 200);
            this.lstFiles.SmallImageList = this.ContentIcons;
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstFiles_MouseDoubleClick);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 150;
            // 
            // clmSize
            // 
            this.clmSize.Text = "Size";
            // 
            // clmCreTime
            // 
            this.clmCreTime.Text = "Created";
            this.clmCreTime.Width = 100;
            // 
            // clmModTime
            // 
            this.clmModTime.Text = "Modified";
            this.clmModTime.Width = 100;
            // 
            // clmMd5
            // 
            this.clmMd5.Text = "MD5";
            // 
            // ContentIcons
            // 
            this.ContentIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ContentIcons.ImageStream")));
            this.ContentIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ContentIcons.Images.SetKeyName(0, "file_b.png");
            this.ContentIcons.Images.SetKeyName(1, "folder_b.png");
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtPath.Location = new System.Drawing.Point(0, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(198, 22);
            this.txtPath.TabIndex = 1;
            // 
            // pnlMap
            // 
            this.pnlMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 0);
            this.pnlMap.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(596, 212);
            this.pnlMap.TabIndex = 0;
            // 
            // splContainer2
            // 
            this.splContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splContainer2.Location = new System.Drawing.Point(0, 0);
            this.splContainer2.Name = "splContainer2";
            this.splContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splContainer2.Panel1
            // 
            this.splContainer2.Panel1.Controls.Add(this.lstFiles);
            this.splContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splContainer2.Panel2
            // 
            this.splContainer2.Panel2.Controls.Add(this.pnlMap);
            this.splContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splContainer2.Size = new System.Drawing.Size(596, 450);
            this.splContainer2.SplitterDistance = 234;
            this.splContainer2.TabIndex = 5;
            // 
            // splContainer1
            // 
            this.splContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splContainer1.Location = new System.Drawing.Point(0, 0);
            this.splContainer1.Name = "splContainer1";
            // 
            // splContainer1.Panel1
            // 
            this.splContainer1.Panel1.Controls.Add(this.lstTree);
            this.splContainer1.Panel1.Controls.Add(this.txtPath);
            this.splContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splContainer1.Panel1MinSize = 200;
            // 
            // splContainer1.Panel2
            // 
            this.splContainer1.Panel2.Controls.Add(this.splContainer2);
            this.splContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splContainer1.Panel2MinSize = 450;
            this.splContainer1.Size = new System.Drawing.Size(800, 450);
            this.splContainer1.SplitterDistance = 200;
            this.splContainer1.TabIndex = 6;
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splContainer1);
            this.Controls.Add(this.prgBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Scan";
            this.Size = new System.Drawing.Size(800, 450);
            this.splContainer2.Panel1.ResumeLayout(false);
            this.splContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splContainer2)).EndInit();
            this.splContainer2.ResumeLayout(false);
            this.splContainer1.Panel1.ResumeLayout(false);
            this.splContainer1.Panel1.PerformLayout();
            this.splContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splContainer1)).EndInit();
            this.splContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView lstTree;
        internal System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmSize;
        private System.Windows.Forms.ColumnHeader clmCreTime;
        private System.Windows.Forms.ColumnHeader clmModTime;
        private System.Windows.Forms.ColumnHeader clmMd5;
    private System.Windows.Forms.ImageList ContentIcons;
    private Space_maker.DoubleBuffer pnlMap;
    private System.Windows.Forms.SplitContainer splContainer2;
    private System.Windows.Forms.SplitContainer splContainer1;
}
