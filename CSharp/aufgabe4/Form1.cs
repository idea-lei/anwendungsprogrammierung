using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aufgabe4 {
    public partial class Form1 : Form {
        public List<char> comboBoxList = new List<char> { '+', '-', '*', '/' };
        public Form1() {
            InitializeComponent();
            comboBox1.DataSource = comboBoxList;
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                double n1 = double.Parse(textBox1.Text);
                double n2 = double.Parse(textBox2.Text);
                char eingetippt = comboBox1.Text[0];
                //char op = (char)comboBox1.SelectedItem;

                switch (eingetippt) {
                    case '+':
                        label1.Text = (n1 + n2).ToString();
                        break;
                    case '-':
                        label1.Text = (n1 - n2).ToString();
                        break;
                    case '*':
                        label1.Text = (n1 * n2).ToString();
                        break;
                    case '/':
                        label1.Text = (n1 / n2).ToString();
                        break;
                    default:
                        break;
                }
            } catch(Exception err) {
                MessageBox.Show(err.Message);
            }
        }
    }
}
