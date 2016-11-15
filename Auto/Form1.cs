using System;
using System.Windows.Forms;

namespace AutoNS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e) {
            string stdOut = "";
            string stdErr = "";

            Auto.run(
                txtFilePath.Text,  // file path
                txtArguments.Text, // arguments
                txtCommands.Lines, // commands
                ref stdOut,        // output from file
                ref stdErr         // error from file
            );

            txtOutput.Text = stdOut;
            txtError.Text = stdErr;
        }
    }
}
