namespace WindowsFormsApplication1
{
    partial class İkili_Ürün
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
            this.txtKulAdı = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbVasıf = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKulAdı
            // 
            this.txtKulAdı.Location = new System.Drawing.Point(131, 20);
            this.txtKulAdı.Name = "txtKulAdı";
            this.txtKulAdı.Size = new System.Drawing.Size(100, 20);
            this.txtKulAdı.TabIndex = 0;
            this.txtKulAdı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(131, 59);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbVasıf);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtKulAdı);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(99, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 215);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbVasıf
            // 
            this.cmbVasıf.FormattingEnabled = true;
            this.cmbVasıf.Items.AddRange(new object[] {
            "Yönetici",
            "Personel"});
            this.cmbVasıf.Location = new System.Drawing.Point(131, 103);
            this.cmbVasıf.Name = "cmbVasıf";
            this.cmbVasıf.Size = new System.Drawing.Size(100, 21);
            this.cmbVasıf.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vasıf";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(228, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yeni Kullanıcı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.yenikullanici;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(99, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 83);
            this.panel2.TabIndex = 3;
            // 
            // İkili_Ürün
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "İkili_Ürün";
            this.Text = "Kulllanıcı Ekle";
            this.Load += new System.EventHandler(this.İkili_Ürün_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKulAdı;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbVasıf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;

    }
}