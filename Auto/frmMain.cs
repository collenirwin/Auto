using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AutoNS.Properties;
using BoinBoxNS;
using BoinMsgNS;
using System.Diagnostics;

namespace AutoNS {
    public partial class frmMain : Form {

        #region Vars

        BoinBox[] navButtons = new BoinBox[4];

        public bool saveExplorerPath = true;

        DirectoryInfo organizeDir;

        #endregion

        #region Methods

        public frmMain() {
            InitializeComponent();

            // coloring our messagebox
            BoinMsg.backColor = BackColor;
            BoinMsg.foreColor = SystemColors.HotTrack;
            BoinMsg.buttonBackColor = btnHelpOrganize.BackColor;
            BoinMsg.buttonForeColor = btnHelpOrganize.ForeColor;

            // populating the nav array
            navButtons[0] = btnNavHome;
            navButtons[1] = btnNavOrganize;
            navButtons[2] = btnNavCompileRun;
            navButtons[3] = btnNavCompare;

            // starting off with the home panel
            showPanel(btnNavHome, pnlHome);

            // get settings from Settings.Default and apply them
            getSettings();

            // start cmd in the console control
            console.start();
        }

        private void getSettings() {
            bool consoleOpen = Settings.Default.consoleOpen;
            consoleToolStripMenuItem.Checked = consoleOpen;
            spltMain.Panel2Collapsed = !consoleOpen;         

            bool explorerOpen = Settings.Default.explorerOpen;
            directoryBrowserToolStripMenuItem.Checked = explorerOpen;
            spltSideBar.Panel1Collapsed = !explorerOpen;

            string path = Settings.Default.explorerPath;
            if (Directory.Exists(path)) {
                if (explorer.loadDir(new DirectoryInfo(path))) {
                    btnOpenDir.Hide();
                }
            }
        }

        private void setSettings() {
            Settings.Default.consoleOpen = consoleToolStripMenuItem.Checked;

            Settings.Default.explorerOpen = directoryBrowserToolStripMenuItem.Checked;

            if (saveExplorerPath && explorer.hasDir) {
                Settings.Default.explorerPath = explorer.directory.FullName;
            } else {
                Settings.Default.explorerPath = "";
            }

            Settings.Default.Save();
        }

        private void btnOpenDir_Click(object sender, EventArgs e) {
            openDir();
        }

        private void frmMain_Activated(object sender, EventArgs e) {
            if (explorer.hasDir) {
                explorer.refresh();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            console.stop();
            setSettings();
        }

        private void openDir(DirectoryInfo dir = null) {
            if (dir == null) {
                explorer.openDir();
            } else {
                if (!explorer.loadDir(dir)) {
                    BoinMsg.show(Constants.MSG_CANT_OPEN_ERR, Constants.MSG_CAPTION_ERR);
                }
            }

            spltSideBar.Panel1Collapsed = false;
            directoryBrowserToolStripMenuItem.Checked = true;

            if (explorer.hasDir) {
                btnOpenDir.Hide();
            }
        }

        private void spltSideBar_SplitterMoved(object sender, SplitterEventArgs e) {

            // hack to get rid of ugly selection border
            btnSelectionHack.Focus();
        }

        #region ToolStripMenuItem Events

        #region FILE

        private void closeDirectorytoolStripMenuItem_Click(object sender, EventArgs e) {
            if (explorer.hasDir) {
                explorer.closeDir();
                btnOpenDir.Show();
            }
        }

        private void extractArchiveToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void organizeFilesToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        #endregion

        #region VIEW

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e) {

            // toggle console window
            spltMain.Panel2Collapsed = !consoleToolStripMenuItem.Checked;
        }

        private void directoryBrowserToolStripMenuItem_Click(object sender, EventArgs e) {

            // toggle directory browser
            spltSideBar.Panel1Collapsed = !directoryBrowserToolStripMenuItem.Checked;
        }

        #endregion

        #endregion

        #region Panels

        #region Nav

        private void showPanel(BoinBox button, Panel panel) {

            // set all buttons back to normal
            foreach (var btn in navButtons) {
                btn.ForeColor = SystemColors.Highlight;
                btn.BackColor = Color.White;
                btn.MouseOverBackColor = SystemColors.Highlight;
                btn.Font = new Font(btn.Font.FontFamily, 9.0f);
            }

            // set the passed button to be 'selected'
            button.storedForeColor = Color.White;
            button.ForeColor = Color.White;
            button.BackColor = SystemColors.HotTrack;
            button.MouseOverBackColor = SystemColors.HotTrack;
            button.Font = new Font(button.Font.FontFamily, 10.0f);

            // show the panel
            panel.BringToFront();
            panel.Dock = DockStyle.Fill;
        }

        private void btnNavHome_Click(object sender, EventArgs e) {
            showPanel(btnNavHome, pnlHome);
        }

        private void btnNavOrganize_Click(object sender, EventArgs e) {
            showPanel(btnNavOrganize, pnlOrganize);
        }

        private void btnNavCompileRun_Click(object sender, EventArgs e) {

        }

        private void btnNavCompare_Click(object sender, EventArgs e) {

        }

        #endregion

        #region HOME

        private void btnOrganize_Click(object sender, EventArgs e) {
            showPanel(btnNavOrganize, pnlOrganize);
        }

        private void btnCompileRun_Click(object sender, EventArgs e) {

        }

        private void btnCompare_Click(object sender, EventArgs e) {

        }

        #endregion

        #region ORGANIZE

        private string browseForDir() {
            var fbDailog = new Ionic.Utils.FolderBrowserDialogEx();
            fbDailog.Description = "Select a directory";
            fbDailog.ShowNewFolderButton = true;
            fbDailog.ShowEditBox = true;
            fbDailog.ShowFullPathInEditBox = true;

            var result  = fbDailog.ShowDialog();
            string path = fbDailog.SelectedPath;

            if (result == DialogResult.OK && Directory.Exists(path)) {
                return path;
            }

            return "";
        }

        private void btnBrowseStart_Click(object sender, EventArgs e) {
            txtStartDir.Text = browseForDir();
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e) {
            txtOutputDir.Text = browseForDir();
        }

        private void chkSameDir_CheckedChanged(object sender, EventArgs e) {
            btnBrowseOutput.Visible = !chkSameDir.Checked;
            txtOutputDir.Visible    = !chkSameDir.Checked;
        }

        private void btnOrganizeGo_Click(object sender, EventArgs e) {

            // check to make sure we have starting and output dirs
            if (Directory.Exists(txtStartDir.Text)
                && (chkSameDir.Checked || Directory.Exists(txtOutputDir.Text))) 
            {
                var outputDir = (chkSameDir.Checked) ? 
                    new DirectoryInfo(txtStartDir.Text) : 
                    new DirectoryInfo(txtOutputDir.Text);

                bool worked = Auto.moveToSeparateDirs(
                    new DirectoryInfo(txtStartDir.Text), // start                    
                    outputDir, // if same dir is checked, use start dir, else use specified output dir
                    txtMatchString.Text, // RegEx match string
                    radMove.Checked // move or copy
                );

                if (worked) {
                    organizeDir = outputDir;

                    btnOpenInDBOrganize.Show();
                    btnOpenInExplorerOrganize.Show();
                } else {
                    BoinMsg.show("There was an error when attempting to move the files.", Constants.MSG_CAPTION_ERR);
                }

            } else {
                BoinMsg.show("Please provide valid starting and output directories.", Constants.MSG_CAPTION);
            }
        }

        private void btnOpenInDBOrganize_Click(object sender, EventArgs e) {
            if (organizeDir != null && organizeDir.Exists) {
                openDir(organizeDir);
            } else {
                BoinMsg.show(Constants.MSG_CANT_OPEN_ERR, Constants.MSG_CAPTION_ERR);
            }
        }

        private void btnOpenInExplorerOrganize_Click(object sender, EventArgs e) {
            if (organizeDir != null && organizeDir.Exists) {
                try {
                    Process.Start("explorer", organizeDir.FullName);
                } catch (Exception ex) {
                    BoinMsg.show("Failed to open Windows Explorer with the following error:\r\n"
                        + ex.Message,
                        Constants.MSG_CAPTION_ERR
                    );
                }

            } else {
                BoinMsg.show(Constants.MSG_CANT_OPEN_ERR, Constants.MSG_CAPTION_ERR);
            }
        }

        #endregion

        #region COMPILE AND RUN

        #endregion

        #region COMPARE

        #endregion

        #endregion

        #endregion
    }
}
