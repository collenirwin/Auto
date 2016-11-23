using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoNS {
    public partial class frmMain : Form {

        #region Vars

        #endregion

        #region Methods

        #region Constructor & Events

        public frmMain() {
            InitializeComponent();
            console.start();
        }

        private void btnOpenDir_Click(object sender, EventArgs e) {
            openDir();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            console.stop();
        }

        #region ToolStripMenuItem Events


        private void extractArchiveToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void organizeFilesToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        #endregion

        #endregion

        private void openDir() {
            explorer.openDir();

            if (explorer.hasDir) {
                btnOpenDir.Hide();
            }
        }

        #endregion
    }
}
