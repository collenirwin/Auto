using System;
using System.IO;
using System.Windows.Forms;

namespace AutoNS {
    public partial class frmTestSeparateDirs : Form {
        public frmTestSeparateDirs() {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e) {

            Auto.moveToSeparateDirs(
                new DirectoryInfo(txtDirPath.Text),    // directory to look in
                new DirectoryInfo(txtOutDirPath.Text), // directory to make subdirectories in
                txtRegEx.Text                          // regex match string
            );
        }
    }
}
