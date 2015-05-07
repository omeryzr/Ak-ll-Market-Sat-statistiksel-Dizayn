namespace WindowsFormsApplication1
{
    partial class ÜrünMalBilgisi
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
            this.txtMarkaİleAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtİsimİleAra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataStok = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStok)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarkaİleAra
            // 
            this.txtMarkaİleAra.Location = new System.Drawing.Point(6, 19);
            this.txtMarkaİleAra.Name = "txtMarkaİleAra";
            this.txtMarkaİleAra.Size = new System.Drawing.Size(116, 20);
            this.txtMarkaİleAra.TabIndex = 0;
            this.txtMarkaİleAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtİsimİleAra);
            this.groupBox1.Location = new System.Drawing.Point(239, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka İle Ara";
            // 
            // txtİsimİleAra
            // 
            this.txtİsimİleAra.Location = new System.Drawing.Point(6, 19);
            this.txtİsimİleAra.Name = "txtİsimİleAra";
            this.txtİsimİleAra.Size = new System.Drawing.Size(116, 20);
            this.txtİsimİleAra.TabIndex = 0;
            this.txtİsimİleAra.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMarkaİleAra);
            this.groupBox2.Location = new System.Drawing.Point(94, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İsim İle Ara";
            // 
            // dataStok
            // 
            this.dataStok.AllowUserToOrderColumns = true;
            this.dataStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataStok.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataStok.Location = new System.Drawing.Point(5, 93);
            this.dataStok.Name = "dataStok";
            this.dataStok.Size = new System.Drawing.Size(868, 354);
            this.dataStok.TabIndex = 4;
            // 
            // Kod
            // 
            this.Kod.DataPropertyName = "Kod";
            this.Kod.HeaderText = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ürünİsmi";
            this.Column2.HeaderText = "Ürün İsmi";
            this.Column2.Name = "Column2";
            this.Column2.Width = 174;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Grup";
            this.Column3.HeaderText = "Grup";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Barkod";
            this.Column4.HeaderText = "Barkod";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Marka";
            this.Column5.HeaderText = "Marka";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Birim";
            this.Column6.HeaderText = "Birim";
            this.Column6.Name = "Column6";
            this.Column6.Width = 75;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Giriş";
            this.Column8.HeaderText = "Giriş";
            this.Column8.Name = "Column8";
            this.Column8.Width = 75;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Çıkış";
            this.Column9.HeaderText = "Çıkış";
            this.Column9.Name = "Column9";
            this.Column9.Width = 75;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Mevcut";
            this.Column10.HeaderText = "Mevcut";
            this.Column10.Name = "Column10";
            this.Column10.Width = 75;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Search;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 76);
            this.panel1.TabIndex = 6;
            // 
            // ÜrünMalBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataStok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::WindowsFormsApplication1.Properties.Settings.Default, "ortak", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::WindowsFormsApplication1.Properties.Settings.Default.ortak;
            this.Name = "ÜrünMalBilgisi";
            this.Text = "Ürün Ara";
            this.Load += new System.EventHandler(this.ÜrünMalBilgisi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarkaİleAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtİsimİleAra;
        public System.Windows.Forms.DataGridView dataStok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Panel panel1;

    }
}