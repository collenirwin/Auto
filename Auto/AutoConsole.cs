using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoNS {
    public partial class AutoConsole : UserControl {

        #region Vars

        #region Private

        private const int HISTORY_MAX = 100;
        private List<string> history  = new List<string>(HISTORY_MAX);
        private int historyIndex      = -1;

        private Color _outputColor = Color.LightBlue;
        private Color _errorColor  = Color.LightCoral;

        private Process _process;

        private string _prompt = ">:";
        private string _path   = "cmd";

        private delegate void _updateConsole(string text, Color color);

        #endregion

        #region Public

        /// <summary>
        /// Color of standard output
        /// </summary>
        public Color outputColor {
            get { return  _outputColor; }
            set { _outputColor = value; }
        }

        /// <summary>
        /// Color of standard error and other error messages
        /// </summary>
        public Color errorColor {
            get { return  _errorColor; }
            set { _errorColor = value; }
        }

        /// <summary>
        /// Prompt that appears at the bottom of the AutoConsole
        /// </summary>
        public string prompt {
            get { return _prompt; }
        }

        /// <summary>
        /// Path to the shell AutoConsole is using
        /// </summary>
        public string path {
            get { return _path; }
        }

        public string lastCommand {
            get { return history[0]; }
        }

        #endregion

        #endregion

        #region Methods

        public AutoConsole() {
            InitializeComponent();
        }

        private void updateConsole(string text, Color color) {

            // thread safety
            if (txtConsole.InvokeRequired) {
                _updateConsole uc = new _updateConsole(updateConsole);
                txtConsole.Invoke(uc, new object[] { text, color });
            } else {
                int start = txtConsole.TextLength;

                // add text
                txtConsole.AppendText(text);

                // color text
                txtConsole.SelectionStart  = start;
                txtConsole.SelectionLength = text.Length;
                txtConsole.SelectionColor  = color;
                txtConsole.SelectionLength = 0;

                txtConsole.SelectionStart = txtConsole.TextLength - 1;
                txtConsole.ScrollToCaret();
            }
        }

        public void setPrompt(string newPrompt) {

            // if there's text other than the prompt
            if (txtConsoleInput.TextLength != _prompt.Length) {
                txtConsoleInput.Text = newPrompt + txtConsoleInput.Text.Substring(_prompt.Length);
            } else {
                txtConsoleInput.Text = newPrompt;
            }

            _prompt = newPrompt;
        }

        /// <summary>
        /// Sends a command to the process running within 
        /// </summary>
        /// <param name="command">command to send</param>
        /// <param name="showErrorOnConsole">if there's an error, this controls whether it is displayed on the console</param>
        /// <returns>false if an exception is thrown</returns>
        public bool sendCommand(string command, bool showErrorOnConsole = true) {

            try {
                string commandLower = command.ToLower();

                // TODO?: do something when the command is "exit"?
                if (commandLower == "clear" || commandLower == "cls") {
                    txtConsole.Clear();
                    txtConsole.Refresh();
                } else {

                    // pass the command over stdin
                    _process.StandardInput.WriteLine(command);
                }

                addCommand(command);

            } catch (Exception ex) {
                if (showErrorOnConsole) {
                    updateConsole("[AutoConsole Exception] " + ex.Message + Environment.NewLine, errorColor);
                }
                
                return false;
            }

            return true;
        }

        private void txtConsoleInput_KeyDown(object sender, KeyEventArgs e) {

            // on enter
            if (e.KeyCode == Keys.Enter) {

                // get rid of the 'ding' sound on enter
                e.SuppressKeyPress = true;

                if (_process == null) {
                    updateConsole("[AutoConsole] No process is running" + Environment.NewLine, errorColor);
                    return;
                }

                // we have a command
                if (txtConsoleInput.TextLength > prompt.Length) {

                    // send it
                    sendCommand(txtConsoleInput.Text.Substring(prompt.Length).Trim());
                    
                    // erase the command
                    txtConsoleInput.Text = prompt;
                }

            } else if (e.KeyCode == Keys.Up) { // going up in history
                showHistoryItem(1);
            } else if (e.KeyCode == Keys.Down) { // going down in history
                showHistoryItem(-1);
            }
        }

        private void showHistoryItem(int up) {
            if (history.Count == 0) {
                historyIndex = -1;
                return;
            }

            historyIndex += up;

            if (historyIndex < 0) {
                historyIndex = 0;
            } else if (historyIndex > history.Count - 1) {
                historyIndex = history.Count - 1;
            }

            txtConsoleInput.Text = prompt + history[historyIndex];
        }

        // add a command to history, but keep history.Count below HISTORY_MAX
        private void addCommand(string command) {

            // remove from the end if we reach the max
            if (history.Count == HISTORY_MAX) {
                history.RemoveAt(HISTORY_MAX - 1);
            }

            // add to the beginning
            history.Insert(0, command);

            // reset historyIndex
            historyIndex = -1;
        }

        private void txtConsoleInput_TextChanged(object sender, EventArgs e) {

            // don't let the user erase the console prompt
            if (txtConsoleInput.TextLength < prompt.Length) {
                txtConsoleInput.Text = prompt;
                txtConsoleInput.SelectionStart = txtConsoleInput.TextLength;
            }
        }

        private void txtConsoleInput_SelectionChanged(object sender, EventArgs e) {

            // make sure the user can't select the console prompt
            if (txtConsoleInput.SelectionStart < prompt.Length) {
                txtConsoleInput.SelectionStart = prompt.Length;
            }
        }

        public void start(string fileName, string args = "") {
            _path = fileName;

            // free up any resources _process might have
            if (_process != null) {
                _process.Dispose();
            }

            // open a process
            _process = new Process();

            // set process info
            _process.StartInfo = new ProcessStartInfo {
                FileName  = fileName,
                Arguments = args,
                RedirectStandardInput  = true,
                RedirectStandardOutput = true,
                RedirectStandardError  = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
            };

            _process.OutputDataReceived += new DataReceivedEventHandler(_process_OnOutputDataReceived);
            _process.ErrorDataReceived  += new DataReceivedEventHandler(_process_OnErrorDataReceived);

            _process.Start();
            _process.BeginOutputReadLine();
            _process.BeginErrorReadLine();
        }

        public void start() {
            start(path);
        }

        public bool stop() {
            if (_process != null) {

                try {
                    _process.WaitForExit(1);
                    _process.Dispose();

                    return true;

                } catch {
                    return false;
                }
            }

            return false;
        }

        private void updateConsole(string text) {
            txtConsole.AppendText(text);
        }

        private void _process_OnOutputDataReceived(object sender, DataReceivedEventArgs e) {
            if (e.Data != null) {
                updateConsole(e.Data + Environment.NewLine, outputColor);
            }
        }

        private void _process_OnErrorDataReceived(object sender, DataReceivedEventArgs e) {
            if (e.Data != null) {
                updateConsole(e.Data + Environment.NewLine, errorColor);
            }
        }

        #endregion
    }
}