using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Giris : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=OMER;Initial Catalog=Akıllı_Market_Satış_Yazılımı;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        int c = 10;
         
        public Giris()
        {
            InitializeComponent();
        }
        public string kullanici;
        void kgiris()
        {
            string kadi = txtKadi.Text;
            string sifre = txtSifre.Text;
            
            if (comboBox1.SelectedItem == "Yönetici")
            {
            if (txtKadi.Text == "" && txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Girilemez...");
            }
            try
            {
                
                if (kadi != "" && sifre != "")
                {

                    
                    SqlCommand sorgu = new SqlCommand("SELECT KullanıcıAdı,Şifre FROM Yönetici", conn);
                    SqlDataReader okuyucu;
                    bool onay = false;
                    try
                    {
                        conn.Open();
                        okuyucu = sorgu.ExecuteReader();
                        while (okuyucu.Read())
                        {
                            if ((kadi == okuyucu["KullanıcıAdı"].ToString()) && (sifre == okuyucu["Şifre"].ToString()))
                            {

                                onay = true;
                                
                                break;// veri tabanıyla doğru ise kullanıcı girişi yap
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (onay == true)
                    {
                        kullanici = kadi;
                        Yönetici c1 = new Yönetici();
                        c1.label1.Text = kullanici;
                        
                        
                        c1.ShowDialog();
                        this.Hide();

                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Kullanıcı Adı ve Şifreyi Yanlış Girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKadi.Text = "";
                        txtSifre.Text = "";
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());

            }}
            else if(comboBox1.SelectedItem=="Personel")
            {

                if (txtKadi.Text == "" && txtSifre.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Boş Girilemez...");
                }
                try
                {

                    if (kadi != "" && sifre != "")
                    {

                        
                        SqlCommand sorgu = new SqlCommand("SELECT KullanıcıAdı,Şifre FROM Personel", conn);
                        SqlDataReader okuyucu;
                        bool onay = false;
                        try
                        {
                            conn.Open();
                            okuyucu = sorgu.ExecuteReader();
                            while (okuyucu.Read())
                            {
                                if ((kadi == okuyucu["KullanıcıAdı"].ToString()) && (sifre == okuyucu["Şifre"].ToString()))
                                {

                                    onay = true;
                                    break;// veri tabanıyla doğru ise kullanıcı girişi yap
                                }
                            }
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        if (onay == true)
                        {
                            kullanici = kadi;
                            Personel p1 = new Personel();
                            p1.label1.Text = kullanici;
                            
                           
                           
                            p1.ShowDialog();
                            this.Hide();

                            

                        }
                        else
                        {
                            conn.Close();
                            MessageBox.Show("Kullanıcı Adı ve Şifreyi Yanlış Girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtKadi.Text = "";
                            txtSifre.Text = "";
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());

                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
            kgiris();
            loglamakaydet();
           
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            c = 9;

        }

        private void ddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            c = 10;
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            Tarih();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        public void Tarih()
        {
            DateTime dt = DateTime.Now;

            lblTarih.Text = dt.ToString();
        }
        public void loglamakaydet() 
        {
            try
            {

                conn.Open();
                string kaydet1 = "INSERT INTO SistemKullanimi(Tarih,Kullanıcı,Vasıf,İslevi)VALUES('"+lblTarih.Text+"','"+txtKadi.Text+"','"+comboBox1.SelectedItem+"','"+lblGiris.Text+"')";
                SqlCommand cmd = new SqlCommand(kaydet1, conn);
                cmd.ExecuteNonQuery();                  
                conn.Close();
            }
            catch (SqlException exe)
            {

                MessageBox.Show(exe.ToString());

            }
        }

        private void lblTarih_Click(object sender, EventArgs e)
        {
            Tarih();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKadi_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
