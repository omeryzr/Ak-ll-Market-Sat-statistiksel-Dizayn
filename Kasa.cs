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
    public partial class Kasa : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Akıllı_Market_Satış_Yazılımı ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public Kasa()
        {
            InitializeComponent();
        }
        public void listele()
        {

            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select Kod,Alış,Satış From Kasa", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Kasa_Load(object sender, EventArgs e)
        {
            listele();
            topla1();
            topla2();
            karhesapla();
            KasaHesap();
        }
        public void topla1()
        {
            

            Double topla = 0;
            int a = dataGridView1.Rows.Count;
            for (int i = 0; i < a - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value != DBNull.Value)
                    topla = topla + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            textBox1.Text = topla.ToString();


        }
        public void topla2()
        {

            Double topla = 0;
            int a = dataGridView1.Rows.Count;
            for (int i = 0; i < a - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != DBNull.Value)
                    topla = topla + Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            textBox2.Text = topla.ToString();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void KasaHesap()
        {
            string b = textBox2.Text;
            string c = textBox3.Text;
            int sayi = Convert.ToInt32(b);
            int sayi1 = Convert.ToInt32(c);
            int toplam = sayi + sayi1;
            string sonuc = Convert.ToString(toplam);
            textBox4.Text = sonuc;

        }
        public void karhesapla()
    {
        string a = textBox1.Text;
        string b = textBox2.Text;

        int sayi = Convert.ToInt32(a);
        int sayi1 = Convert.ToInt32(b);
        int cikarma = sayi - sayi1;
        string sonuc = Convert.ToString(cikarma);
        textBox3.Text = sonuc;

    }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topla1();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            karhesapla();
        }
    }
}
