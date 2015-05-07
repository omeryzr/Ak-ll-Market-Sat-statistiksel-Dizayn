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
    public partial class Yönetici : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OMER;Initial Catalog=Akıllı_Market_Satış_Yazılımı;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public Yönetici()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÜrünMalBilgisi üm1 = new ÜrünMalBilgisi();
            üm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Personelbilgi p2 = new Personelbilgi();
            p2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            loglamakaydet();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Satis s1 = new Satis();
            s1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Yönetici_Load(object sender, EventArgs e)
        {

            Tarih();
            
        }
        public void loglamakaydet()
        {
            try
            {

                conn.Open();
                string kaydet1 = "INSERT INTO SistemKullanimi(Tarih,Kullanıcı,İslevi)VALUES('" + label5.Text+ "','" + label1.Text + "','" + lblCıkıs.Text + "')";
                SqlCommand cmd = new SqlCommand(kaydet1, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException exe)
            {

                MessageBox.Show(exe.ToString());

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            ÜrünEkleme ü1 = new ÜrünEkleme();
            ü1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Personelbilgi p1 = new Personelbilgi();
            p1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kasa k1 = new Kasa();
            k1.Show();
        }
        public void Tarih()
        {
            DateTime dt = DateTime.Now;

            label5.Text = dt.ToString();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Tarih();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris g1 = new Giris();
            g1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            İkili_Ürün i1 = new İkili_Ürün();
            i1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblVasif_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Yönetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            loglamakaydet();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Sistem_Kullanimi s1 = new Sistem_Kullanimi();
            s1.ShowDialog();
        }
    }
}
