namespace WindowsFormsApplication1
{
    partial class Giris
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblGiris = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "KULLANICI GİRİŞİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.users_lock;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(7, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 120);
            this.panel2.TabIndex = 7;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(116, 76);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '•';
            this.txtSifre.Size = new System.Drawing.Size(138, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(116, 30);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(138, 20);
            this.txtKadi.TabIndex = 0;
            this.txtKadi.TextChanged += new System.EventHandler(this.txtKadi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parola";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtKadi);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(137, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 255);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yönetici",
            "Personel"});
            this.comboBox1.Location = new System.Drawing.Point(116, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vasıf";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(367, 336);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 13);
            this.lblTarih.TabIndex = 8;
            this.lblTarih.Visible = false;
            this.lblTarih.Click += new System.EventHandler(this.lblTarih_Click);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Location = new System.Drawing.Point(71, 356);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(61, 13);
            this.lblGiris.TabIndex = 9;
            this.lblGiris.Text = "Giriş Yapıldı";
            this.lblGiris.Visible = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(600, 381);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Giris";
            this.Text = "Market Akıllı Satış Ve İstatislik Dizayn Yazılımı ™";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblGiris;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

