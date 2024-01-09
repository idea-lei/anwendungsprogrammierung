using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btn_Number_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var btnText = btn.Text;

            if (string.IsNullOrEmpty(textBox_operator.Text))
            {
                textBox_value1.Text += btnText;
            }
            else
            {
                textBox_value2.Text += btnText;
            }
        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var btnText = btn.Text;

            if (string.IsNullOrEmpty(textBox_operator.Text))
            {
                if (textBox_value1.Text?.Contains(btnText) == false)
                {
                    textBox_value1.Text += btnText;
                }
            }
            else
            {
                if (textBox_value2.Text?.Contains(btnText) == false)
                {
                    textBox_value2.Text += btnText;
                }
            }
        }

        private void btn_operator_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            textBox_operator.Text = btn.Text;
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_value1.Text, out double v1))
            {
                MessageBox.Show("Value 1 is not valid");
            }
            if (!double.TryParse(textBox_value2.Text, out double v2))
            {
                MessageBox.Show("Value 2 is not valid");
            }

            switch (textBox_operator.Text)
            {
                case "+":
                    textBox_result.Text = (v1 + v2).ToString();
                    break;
                case "-":
                    textBox_result.Text = (v1 - v2).ToString();
                    break;
                case "*":
                    textBox_result.Text = (v1 * v2).ToString();
                    break;
                case "/":
                    if (v2 == 0)
                    {
                        MessageBox.Show("Value 2 is not valid");
                        return;
                    }
                    textBox_result.Text = (v1 / v2).ToString();
                    break;
                case "%":
                    if (v2 == 0)
                    {
                        MessageBox.Show("Value 2 is not valid");
                        return;
                    }
                    textBox_result.Text = (v1 % v2).ToString();
                    break;
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            textBox_operator.Text = string.Empty;
            textBox_value1.Text = string.Empty;
            textBox_value2.Text = string.Empty;
            textBox_result.Text = string.Empty;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
