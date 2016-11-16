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
        public frmMain() {
            InitializeComponent();
        }

        private void btnOpenDir_Click(object sender, EventArgs e) {
            explorer.openDir();
            btnOpenDir.Hide();
        }
    }
}
