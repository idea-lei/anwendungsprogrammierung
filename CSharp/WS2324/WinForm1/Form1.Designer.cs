﻿namespace WinForm1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_Verbrauch = new TextBox();
            button1 = new Button();
            textBox_Reichweite = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 13);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Verbrauch:";
            // 
            // textBox_Verbrauch
            // 
            textBox_Verbrauch.Location = new Point(161, 36);
            textBox_Verbrauch.Name = "textBox_Verbrauch";
            textBox_Verbrauch.Size = new Size(157, 27);
            textBox_Verbrauch.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(301, 127);
            button1.Name = "button1";
            button1.Size = new Size(145, 28);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_Reichweite
            // 
            textBox_Reichweite.Location = new Point(416, 40);
            textBox_Reichweite.Name = "textBox_Reichweite";
            textBox_Reichweite.Size = new Size(187, 27);
            textBox_Reichweite.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 17);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Reichweite";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox_Reichweite);
            Controls.Add(button1);
            Controls.Add(textBox_Verbrauch);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Demo 01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Verbrauch;
        private Button button1;
        private TextBox textBox_Reichweite;
        private Label label2;
    }
}