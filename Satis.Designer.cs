namespace WindowsFormsApplication1
{
    partial class Satis
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
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenelTop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbÜrünKodu = new System.Windows.Forms.ComboBox();
            this.cmbKdv = new System.Windows.Forms.ComboBox();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nmrcMiktar = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtÜrünFiyatı = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtÜrünİsmi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genel Toplam";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(592, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tarih";
            // 
            // txtGenelTop
            // 
            this.txtGenelTop.Location = new System.Drawing.Point(673, 56);
            this.txtGenelTop.Name = "txtGenelTop";
            this.txtGenelTop.Size = new System.Drawing.Size(141, 20);
            this.txtGenelTop.TabIndex = 12;
            this.txtGenelTop.TextChanged += new System.EventHandler(this.txtGenelTop_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Location = new System.Drawing.Point(585, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kdv Toplam";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(865, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(836, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 32);
            this.panel1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.comboBox1.Location = new System.Drawing.Point(432, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(629, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(231, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fiş No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ödeme Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Satış No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.txtGenelTop);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 83);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(432, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 28);
            this.button6.TabIndex = 19;
            this.button6.Text = "Satışı Tamamla";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(673, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 20);
            this.textBox8.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(673, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Location = new System.Drawing.Point(585, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İskonto Toplamı";
            this.label3.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Enabled = false;
            this.lblTarih.Location = new System.Drawing.Point(832, 371);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 13);
            this.lblTarih.TabIndex = 20;
            this.lblTarih.Text = "label5";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(836, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "Satış İptal";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.cmbÜrünKodu);
            this.panel3.Controls.Add(this.cmbKdv);
            this.panel3.Controls.Add(this.txtToplamFiyat);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnEkle);
            this.panel3.Controls.Add(this.nmrcMiktar);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtÜrünFiyatı);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtBarkod);
            this.panel3.Controls.Add(this.txtÜrünİsmi);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 55);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(570, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Kdv";
            // 
            // cmbÜrünKodu
            // 
            this.cmbÜrünKodu.FormattingEnabled = true;
            this.cmbÜrünKodu.Items.AddRange(new object[] {
            "%0",
            "%1",
            "%8",
            "%18"});
            this.cmbÜrünKodu.Location = new System.Drawing.Point(37, 28);
            this.cmbÜrünKodu.Name = "cmbÜrünKodu";
            this.cmbÜrünKodu.Size = new System.Drawing.Size(73, 21);
            this.cmbÜrünKodu.TabIndex = 23;
            this.cmbÜrünKodu.SelectedIndexChanged += new System.EventHandler(this.cmbKdv_SelectedIndexChanged);
            // 
            // cmbKdv
            // 
            this.cmbKdv.FormattingEnabled = true;
            this.cmbKdv.Items.AddRange(new object[] {
            "%0",
            "%1",
            "%8",
            "%18"});
            this.cmbKdv.Location = new System.Drawing.Point(570, 29);
            this.cmbKdv.Name = "cmbKdv";
            this.cmbKdv.Size = new System.Drawing.Size(58, 21);
            this.cmbKdv.TabIndex = 23;
            this.cmbKdv.SelectedIndexChanged += new System.EventHandler(this.cmbKdv_SelectedIndexChanged);
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtToplamFiyat.Location = new System.Drawing.Point(637, 29);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(129, 20);
            this.txtToplamFiyat.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(637, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Toplam Fiyatı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(783, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // nmrcMiktar
            // 
            this.nmrcMiktar.Location = new System.Drawing.Point(375, 30);
            this.nmrcMiktar.Name = "nmrcMiktar";
            this.nmrcMiktar.Size = new System.Drawing.Size(54, 20);
            this.nmrcMiktar.TabIndex = 4;
            this.nmrcMiktar.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ürün Kodu ";
            // 
            // txtÜrünFiyatı
            // 
            this.txtÜrünFiyatı.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtÜrünFiyatı.Location = new System.Drawing.Point(435, 30);
            this.txtÜrünFiyatı.Name = "txtÜrünFiyatı";
            this.txtÜrünFiyatı.Size = new System.Drawing.Size(129, 20);
            this.txtÜrünFiyatı.TabIndex = 1;
            this.txtÜrünFiyatı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(435, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Birim Fiyatı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Miktar";
            // 
            // txtBarkod
            // 
            this.txtBarkod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBarkod.Location = new System.Drawing.Point(266, 30);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(103, 20);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtÜrünİsmi
            // 
            this.txtÜrünİsmi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtÜrünİsmi.Location = new System.Drawing.Point(131, 30);
            this.txtÜrünİsmi.Name = "txtÜrünİsmi";
            this.txtÜrünİsmi.Size = new System.Drawing.Size(129, 20);
            this.txtÜrünİsmi.TabIndex = 1;
            this.txtÜrünİsmi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Barkod";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button5
            // 
            this.button5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button5.Location = new System.Drawing.Point(818, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Kapat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(819, 242);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.search_icon1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(6, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 459);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::WindowsFormsApplication1.Properties.Settings.Default, "ortak", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::WindowsFormsApplication1.Properties.Settings.Default.ortak;
            this.Name = "Satis";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Satis";
            this.Load += new System.EventHandler(this.Satis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenelTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nmrcMiktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtÜrünFiyatı;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbKdv;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtÜrünİsmi;
        private System.Windows.Forms.ComboBox cmbÜrünKodu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblTarih;



    }
}