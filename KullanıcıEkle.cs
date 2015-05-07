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
    public partial class İkili_Ürün : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Akıllı_Market_Satış_Yazılımı ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public İkili_Ürün()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void İkili_Ürün_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbVasıf.SelectedItem=="Yönetici")
            {
                try
                {
                    conn.Open();
                    string komut = "INSERT INTO Yönetici(KullanıcıAdı,Şifre)VALUES('"+txtKulAdı.Text+"','"+txtSifre.Text+"')";
                    SqlCommand cmd = new SqlCommand(komut, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (SqlException exe)
                {
                    MessageBox.Show(exe.ToString());

                }
            }
            else if(cmbVasıf.SelectedItem=="Personel")
            {
                try
                {
                    conn.Open();
                    string komut = "INSERT INTO Personel(KullanıcıAdı,Şifre)VALUES('" + txtKulAdı.Text + "','" + txtSifre.Text + "')";
                    SqlCommand cmd = new SqlCommand(komut, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (SqlException exe)
                {
                    MessageBox.Show(exe.ToString());

                }
            }
                
        
        }
                
        }
    }

