namespace WinForm1
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_p = new Button();
            btn_c = new Button();
            btn_b = new Button();
            btn_d = new Button();
            btn_minus = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_multiply = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_e = new Button();
            btn_comma = new Button();
            btn_0 = new Button();
            btn_pon = new Button();
            btn_plus = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            textBox_result = new TextBox();
            textBox_value1 = new TextBox();
            textBox_value2 = new TextBox();
            textBox_operator = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_p
            // 
            btn_p.Location = new Point(12, 103);
            btn_p.Name = "btn_p";
            btn_p.Size = new Size(100, 29);
            btn_p.TabIndex = 0;
            btn_p.Text = "%";
            btn_p.UseVisualStyleBackColor = true;
            btn_p.Click += btn_operator_Click;
            btn_p.MouseEnter += btn_MouseEnter;
            btn_p.MouseLeave += btn_MouseLeave;
            // 
            // btn_c
            // 
            btn_c.Location = new Point(118, 103);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(100, 29);
            btn_c.TabIndex = 1;
            btn_c.Text = "c";
            btn_c.UseVisualStyleBackColor = true;
            btn_c.Click += btn_c_Click;
            // 
            // btn_b
            // 
            btn_b.Location = new Point(224, 103);
            btn_b.Name = "btn_b";
            btn_b.Size = new Size(100, 29);
            btn_b.TabIndex = 2;
            btn_b.Text = "<-";
            btn_b.UseVisualStyleBackColor = true;
            // 
            // btn_d
            // 
            btn_d.Location = new Point(330, 103);
            btn_d.Name = "btn_d";
            btn_d.Size = new Size(100, 29);
            btn_d.TabIndex = 3;
            btn_d.Text = "/";
            btn_d.UseVisualStyleBackColor = true;
            btn_d.Click += btn_operator_Click;
            // 
            // btn_minus
            // 
            btn_minus.Location = new Point(330, 173);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(100, 29);
            btn_minus.TabIndex = 15;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_operator_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(224, 173);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(100, 29);
            btn_6.TabIndex = 14;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_Number_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(118, 173);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(100, 29);
            btn_5.TabIndex = 13;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_Number_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(12, 173);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(100, 29);
            btn_4.TabIndex = 12;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_Number_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Location = new Point(330, 138);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(100, 29);
            btn_multiply.TabIndex = 11;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_operator_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(224, 138);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(100, 29);
            btn_9.TabIndex = 10;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_Number_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(118, 138);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(100, 29);
            btn_8.TabIndex = 9;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_Number_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(12, 138);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(100, 29);
            btn_7.TabIndex = 8;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_Number_Click;
            // 
            // btn_e
            // 
            btn_e.Location = new Point(330, 243);
            btn_e.Name = "btn_e";
            btn_e.Size = new Size(100, 29);
            btn_e.TabIndex = 23;
            btn_e.Text = "=";
            btn_e.UseVisualStyleBackColor = true;
            btn_e.Click += btn_e_Click;
            // 
            // btn_comma
            // 
            btn_comma.Location = new Point(224, 243);
            btn_comma.Name = "btn_comma";
            btn_comma.Size = new Size(100, 29);
            btn_comma.TabIndex = 22;
            btn_comma.Text = ",";
            btn_comma.UseVisualStyleBackColor = true;
            btn_comma.Click += btn_comma_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(118, 243);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(100, 29);
            btn_0.TabIndex = 21;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_Number_Click;
            // 
            // btn_pon
            // 
            btn_pon.Location = new Point(12, 243);
            btn_pon.Name = "btn_pon";
            btn_pon.Size = new Size(100, 29);
            btn_pon.TabIndex = 20;
            btn_pon.Text = "+/-";
            btn_pon.UseVisualStyleBackColor = true;
            // 
            // btn_plus
            // 
            btn_plus.Location = new Point(330, 208);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(100, 29);
            btn_plus.TabIndex = 19;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_operator_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(224, 208);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(100, 29);
            btn_3.TabIndex = 18;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_Number_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(118, 208);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(100, 29);
            btn_2.TabIndex = 17;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_Number_Click;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(12, 208);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(100, 29);
            btn_1.TabIndex = 16;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_Number_Click;
            // 
            // textBox_result
            // 
            textBox_result.Font = new Font("Segoe UI", 16F);
            textBox_result.Location = new Point(330, 54);
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new Size(100, 43);
            textBox_result.TabIndex = 24;
            // 
            // textBox_value1
            // 
            textBox_value1.Font = new Font("Segoe UI", 16F);
            textBox_value1.Location = new Point(12, 54);
            textBox_value1.Name = "textBox_value1";
            textBox_value1.Size = new Size(100, 43);
            textBox_value1.TabIndex = 25;
            // 
            // textBox_value2
            // 
            textBox_value2.Font = new Font("Segoe UI", 16F);
            textBox_value2.Location = new Point(224, 54);
            textBox_value2.Name = "textBox_value2";
            textBox_value2.Size = new Size(100, 43);
            textBox_value2.TabIndex = 26;
            // 
            // textBox_operator
            // 
            textBox_operator.Font = new Font("Segoe UI", 16F);
            textBox_operator.Location = new Point(118, 54);
            textBox_operator.Name = "textBox_operator";
            textBox_operator.Size = new Size(100, 43);
            textBox_operator.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 28;
            label1.Text = "value 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 31);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 29;
            label2.Text = "value 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 31);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 30;
            label3.Text = "operator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 31);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 31;
            label4.Text = "result";
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 281);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_operator);
            Controls.Add(textBox_value2);
            Controls.Add(textBox_value1);
            Controls.Add(textBox_result);
            Controls.Add(btn_e);
            Controls.Add(btn_comma);
            Controls.Add(btn_0);
            Controls.Add(btn_pon);
            Controls.Add(btn_plus);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_minus);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_multiply);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_d);
            Controls.Add(btn_b);
            Controls.Add(btn_c);
            Controls.Add(btn_p);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_p;
        private Button btn_c;
        private Button btn_b;
        private Button btn_d;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btn_minus;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_multiply;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_e;
        private Button btn_comma;
        private Button btn_0;
        private Button btn_pon;
        private Button btn_plus;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private TextBox textBox_result;
        private TextBox textBox_value1;
        private TextBox textBox_value2;
        private TextBox textBox_operator;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}