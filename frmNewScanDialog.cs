using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class frmNewScanDialog : Form {
    public frmNewScanDialog() {
        InitializeComponent();
    }

    private void btnTarget_Click(object sender, EventArgs e) {
        using (FolderBrowserDialog frmTarget = new FolderBrowserDialog()) {
            frmTarget.SelectedPath = txtTarget.Text;

            if (frmTarget.ShowDialog() == DialogResult.OK) {
                txtTarget.Text = frmTarget.SelectedPath;
            }
        }
    }

}