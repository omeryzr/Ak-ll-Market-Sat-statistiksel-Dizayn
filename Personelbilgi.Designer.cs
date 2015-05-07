namespace WindowsFormsApplication1
{
    partial class Personelbilgi
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
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAnaAdi = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanımBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.mskDoğumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.cmbDogumYeri = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskEvNo = new System.Windows.Forms.MaskedTextBox();
            this.mskCepNo = new System.Windows.Forms.MaskedTextBox();
            this.mskİşeGirişTarihi = new System.Windows.Forms.MaskedTextBox();
            this.cmbEğitimDurumu = new System.Windows.Forms.ComboBox();
            this.cmbMedeniHali = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTCAra = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Location = new System.Drawing.Point(86, 215);
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(110, 20);
            this.txtBabaAdi.TabIndex = 1;
            this.txtBabaAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBabaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBabaAdi_KeyPress);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(86, 106);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(110, 20);
            this.txtTc.TabIndex = 1;
            this.txtTc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // txtAnaAdi
            // 
            this.txtAnaAdi.Location = new System.Drawing.Point(86, 249);
            this.txtAnaAdi.Multiline = true;
            this.txtAnaAdi.Name = "txtAnaAdi";
            this.txtAnaAdi.Size = new System.Drawing.Size(110, 20);
            this.txtAnaAdi.TabIndex = 1;
            this.txtAnaAdi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtAnaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnaAdi_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(86, 176);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(110, 20);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Yeri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cep No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ev No :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(976, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(737, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Çalışanın Çıkışını Yap";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ddToolStripMenuItem
            // 
            this.ddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sssToolStripMenuItem});
            this.ddToolStripMenuItem.Name = "ddToolStripMenuItem";
            this.ddToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ddToolStripMenuItem.Text = "Dosya";
            // 
            // sssToolStripMenuItem
            // 
            this.sssToolStripMenuItem.Name = "sssToolStripMenuItem";
            this.sssToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.sssToolStripMenuItem.Text = "Çıkış";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanımBilgileriToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // kullanımBilgileriToolStripMenuItem
            // 
            this.kullanımBilgileriToolStripMenuItem.Name = "kullanımBilgileriToolStripMenuItem";
            this.kullanımBilgileriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.kullanımBilgileriToolStripMenuItem.Text = "Kullanım Bilgileri";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(101, 170);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(180, 116);
            this.txtAdres.TabIndex = 1;
            this.txtAdres.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(486, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyad.Location = new System.Drawing.Point(86, 142);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(110, 20);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "T.C Kimlik No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ana Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Baba Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.mskDoğumTarihi);
            this.groupBox1.Controls.Add(this.cmbDogumYeri);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtBabaAdi);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAnaAdi);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(379, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 368);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kimlik Bilgileri";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ayşe",
            "fatma",
            "Hasan",
            "Hayriye",
            "mustafa",
            "Talha",
            "Omer"});
            this.comboBox1.Location = new System.Drawing.Point(209, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox4);
            this.groupBox3.Controls.Add(this.maskedTextBox5);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Location = new System.Drawing.Point(367, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 329);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "c";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(101, 136);
            this.maskedTextBox4.Mask = "(999) 000-00-00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 6;
            this.maskedTextBox4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(101, 103);
            this.maskedTextBox5.Mask = "(999) 000-00-00";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox5.TabIndex = 6;
            this.maskedTextBox5.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(101, 64);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(89, 21);
            this.comboBox4.TabIndex = 5;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(101, 29);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(89, 21);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Medeni Hali  :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Eğitim Durumu :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 301);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "İş\'e Giriş Tarihi :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Cep No :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(180, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Adres Bilgileri :";
            this.label21.Click += new System.EventHandler(this.label10_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Ev No :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(101, 170);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 116);
            this.textBox8.TabIndex = 1;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(221, 247);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmbCinsiyet.TabIndex = 5;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mskDoğumTarihi
            // 
            this.mskDoğumTarihi.Location = new System.Drawing.Point(221, 294);
            this.mskDoğumTarihi.Mask = "00/00/0000";
            this.mskDoğumTarihi.Name = "mskDoğumTarihi";
            this.mskDoğumTarihi.Size = new System.Drawing.Size(100, 20);
            this.mskDoğumTarihi.TabIndex = 6;
            this.mskDoğumTarihi.ValidatingType = typeof(System.DateTime);
            this.mskDoğumTarihi.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cmbDogumYeri
            // 
            this.cmbDogumYeri.FormattingEnabled = true;
            this.cmbDogumYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbDogumYeri.Location = new System.Drawing.Point(86, 293);
            this.cmbDogumYeri.Name = "cmbDogumYeri";
            this.cmbDogumYeri.Size = new System.Drawing.Size(110, 21);
            this.cmbDogumYeri.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(209, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cinsiyet :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskEvNo);
            this.groupBox2.Controls.Add(this.mskCepNo);
            this.groupBox2.Controls.Add(this.mskİşeGirişTarihi);
            this.groupBox2.Controls.Add(this.cmbEğitimDurumu);
            this.groupBox2.Controls.Add(this.cmbMedeniHali);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Location = new System.Drawing.Point(741, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 367);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // mskEvNo
            // 
            this.mskEvNo.Location = new System.Drawing.Point(101, 136);
            this.mskEvNo.Mask = "(999) 000-00-00";
            this.mskEvNo.Name = "mskEvNo";
            this.mskEvNo.Size = new System.Drawing.Size(100, 20);
            this.mskEvNo.TabIndex = 6;
            this.mskEvNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mskCepNo
            // 
            this.mskCepNo.Location = new System.Drawing.Point(101, 103);
            this.mskCepNo.Mask = "(999) 000-00-00";
            this.mskCepNo.Name = "mskCepNo";
            this.mskCepNo.Size = new System.Drawing.Size(100, 20);
            this.mskCepNo.TabIndex = 6;
            this.mskCepNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mskİşeGirişTarihi
            // 
            this.mskİşeGirişTarihi.Location = new System.Drawing.Point(103, 298);
            this.mskİşeGirişTarihi.Mask = "00/00/0000";
            this.mskİşeGirişTarihi.Name = "mskİşeGirişTarihi";
            this.mskİşeGirişTarihi.Size = new System.Drawing.Size(100, 20);
            this.mskİşeGirişTarihi.TabIndex = 6;
            this.mskİşeGirişTarihi.ValidatingType = typeof(System.DateTime);
            this.mskİşeGirişTarihi.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cmbEğitimDurumu
            // 
            this.cmbEğitimDurumu.FormattingEnabled = true;
            this.cmbEğitimDurumu.Items.AddRange(new object[] {
            "Yok",
            "İlkÖğretim",
            "OrtaÖğretim",
            "Lise",
            "Üniversite"});
            this.cmbEğitimDurumu.Location = new System.Drawing.Point(101, 64);
            this.cmbEğitimDurumu.Name = "cmbEğitimDurumu";
            this.cmbEğitimDurumu.Size = new System.Drawing.Size(89, 21);
            this.cmbEğitimDurumu.TabIndex = 5;
            // 
            // cmbMedeniHali
            // 
            this.cmbMedeniHali.FormattingEnabled = true;
            this.cmbMedeniHali.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.cmbMedeniHali.Location = new System.Drawing.Point(101, 29);
            this.cmbMedeniHali.Name = "cmbMedeniHali";
            this.cmbMedeniHali.Size = new System.Drawing.Size(89, 21);
            this.cmbMedeniHali.TabIndex = 5;
            this.cmbMedeniHali.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Medeni Hali  :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Eğitim Durumu :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "İş\'e Giriş Tarihi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Adres Bilgileri :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 341);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTCAra
            // 
            this.txtTCAra.Location = new System.Drawing.Point(16, 19);
            this.txtTCAra.Name = "txtTCAra";
            this.txtTCAra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTCAra.Size = new System.Drawing.Size(165, 20);
            this.txtTCAra.TabIndex = 13;
            this.txtTCAra.Text = "                    ";
            this.txtTCAra.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            this.txtTCAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCAra_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAdAra
            // 
            this.txtAdAra.Location = new System.Drawing.Point(16, 21);
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.Size = new System.Drawing.Size(165, 20);
            this.txtAdAra.TabIndex = 16;
            this.txtAdAra.TextChanged += new System.EventHandler(this.txtAdAra_TextChanged);
            this.txtAdAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdAra_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTCAra);
            this.groupBox4.Location = new System.Drawing.Point(12, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 55);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tc No\'ya Göre Ara";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAdAra);
            this.groupBox5.Location = new System.Drawing.Point(12, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 58);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İsim\'e Göre Ara";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Bilgileri Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Personelbilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1063, 503);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Personelbilgi";
            this.Text = "Personel Bilgileri";
            this.Load += new System.EventHandler(this.Personelbilgi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAnaAdi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanımBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEğitimDurumu;
        private System.Windows.Forms.ComboBox cmbMedeniHali;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskDoğumTarihi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.MaskedTextBox mskEvNo;
        private System.Windows.Forms.MaskedTextBox mskCepNo;
        private System.Windows.Forms.MaskedTextBox mskİşeGirişTarihi;
        private System.Windows.Forms.ComboBox cmbDogumYeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTCAra;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtAdAra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}