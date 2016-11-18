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

        const string CONSOLE_PROMPT = ">:";

        List<string> consoleHistory = new List<string>();

        #endregion

        #region Methods

        #region Constructor & Events

        public frmMain() {
            InitializeComponent();
        }

        private void btnOpenDir_Click(object sender, EventArgs e) {
            openDir();
        }

        private void txtConsoleInput_TextChanged(object sender, EventArgs e) {

            // don't let the user erase the console prompt
            if (txtConsoleInput.TextLength < CONSOLE_PROMPT.Length) {
                txtConsoleInput.Text = CONSOLE_PROMPT;
                txtConsoleInput.SelectionStart = txtConsoleInput.TextLength;
            }
        }

        private void txtConsoleInput_SelectionChanged(object sender, EventArgs e) {

            // make sure the user can't select the console prompt
            if (txtConsoleInput.SelectionStart < CONSOLE_PROMPT.Length) {
                txtConsoleInput.SelectionStart = CONSOLE_PROMPT.Length;
            }
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
