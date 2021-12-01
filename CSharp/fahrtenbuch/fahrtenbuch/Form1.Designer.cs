namespace fahrtenbuch
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loaddata = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kmstand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_verbrauch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vkm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vmpg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fzid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrtenbuch";
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(323, 34);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(94, 29);
            this.btn_loaddata.TabIndex = 1;
            this.btn_loaddata.Text = "Load Data";
            this.btn_loaddata.UseVisualStyleBackColor = true;
            this.btn_loaddata.Click += new System.EventHandler(this.btn_loaddata_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(454, 33);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(585, 33);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "KM Stand";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "gef. KM";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Verbrauch";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(423, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Verb. / 100km";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(554, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reichweite";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(704, 314);
            this.panel1.TabIndex = 14;
            // 
            // dg1
            // 
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_kmstand,
            this.col_km,
            this.col_verbrauch,
            this.col_vkm,
            this.col_vmpg,
            this.col_fzid});
            this.dg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg1.Location = new System.Drawing.Point(20, 20);
            this.dg1.Margin = new System.Windows.Forms.Padding(10);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersWidth = 51;
            this.dg1.RowTemplate.Height = 29;
            this.dg1.Size = new System.Drawing.Size(664, 274);
            this.dg1.TabIndex = 0;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_kmstand
            // 
            this.col_kmstand.HeaderText = "KM_Stand";
            this.col_kmstand.MinimumWidth = 6;
            this.col_kmstand.Name = "col_kmstand";
            this.col_kmstand.ReadOnly = true;
            // 
            // col_km
            // 
            this.col_km.HeaderText = "KM";
            this.col_km.MinimumWidth = 6;
            this.col_km.Name = "col_km";
            this.col_km.ReadOnly = true;
            // 
            // col_verbrauch
            // 
            this.col_verbrauch.HeaderText = "Verbrauch";
            this.col_verbrauch.MinimumWidth = 6;
            this.col_verbrauch.Name = "col_verbrauch";
            this.col_verbrauch.ReadOnly = true;
            // 
            // col_vkm
            // 
            this.col_vkm.HeaderText = "v_km";
            this.col_vkm.MinimumWidth = 6;
            this.col_vkm.Name = "col_vkm";
            this.col_vkm.ReadOnly = true;
            // 
            // col_vmpg
            // 
            this.col_vmpg.HeaderText = "v_mpg";
            this.col_vmpg.MinimumWidth = 6;
            this.col_vmpg.Name = "col_vmpg";
            this.col_vmpg.ReadOnly = true;
            // 
            // col_fzid
            // 
            this.col_fzid.HeaderText = "FZ_ID";
            this.col_fzid.MinimumWidth = 6;
            this.col_fzid.Name = "col_fzid";
            this.col_fzid.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_loaddata);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_loaddata;
        private Button btn_add;
        private Button btn_delete;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Panel panel1;
        private DataGridView dg1;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_kmstand;
        private DataGridViewTextBoxColumn col_km;
        private DataGridViewTextBoxColumn col_verbrauch;
        private DataGridViewTextBoxColumn col_vkm;
        private DataGridViewTextBoxColumn col_vmpg;
        private DataGridViewTextBoxColumn col_fzid;
    }
}