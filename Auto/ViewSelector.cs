using System;
using System.Windows.Forms;

namespace AutoNS {
    public partial class ViewSelector : UserControl {

        private const int MAX_HEIGHT  = 146;
        private bool _dropDownVisible = false;

        public bool dropDownVisible {
            get { return _dropDownVisible; }
            set {
                _dropDownVisible = value;
                Height = (value) ? MAX_HEIGHT : btnMain.Height;
            }
        }

        public ViewSelector() {
            InitializeComponent();
            dropDownVisible = false;
        }

        private void btnMain_Click(object sender, EventArgs e) {
            dropDownVisible = !dropDownVisible;
        }
    }
}
