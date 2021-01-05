using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uebung4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e) {
            buttonTest.Text = "clicked";
        }

        private void buttonTest_FontChanged(object sender, EventArgs e) {
            ///
        }

        private void buttonTest_DragDrop(object sender, DragEventArgs e) {

        }
    }
}
