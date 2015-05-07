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
    public partial class ÜrünEkleme : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Akıllı_Market_Satış_Yazılımı ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlCommand cmd3 = new SqlCommand();
        DataTable dt = new DataTable();
               
        public ÜrünEkleme()
        {
            InitializeComponent();
        }
        
        private void listele()
        {
            
           
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * From personellist", conn);
            da.Fill(dt);
            
            
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ÜrünEkleme_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kapatmak istediğinize emin misiniz", "Kapatma Ekranı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public bool Kontrol()
        {
            if (txtBarkodKodu.Text == "")
            {
                MessageBox.Show("Barkodu Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            else if (txtÜrünAdı.Text == "")
            {
                MessageBox.Show("Ürün Adını Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            else if (txtMarka.Text == "")
            {
                MessageBox.Show("Marka'yı Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            else if (txtGrup.Text == "")
            {
                MessageBox.Show("Grubu Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            else if (cmbBirim.Text == "")
            {
                MessageBox.Show("Birimi Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            else if (nmrcMiktar.Text == "")
            {
                MessageBox.Show("Miktarı Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            else if (cmbKdv.Text == "")
            {
                MessageBox.Show("Kdv'yi Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            else if (txtAlış.Text == "")
            {
                MessageBox.Show("Alış Fiyatını Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            else if (txtSatış.Text == "")
            {
                MessageBox.Show("Satış Fiyatını Giriniz");
                txtBarkodKodu.Focus();
                return false;
            }
            
            
            else
            {
                return true;
            }
        } 

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Kontrol() == true)
            {
                
                try
                {

                    conn.Open();
                    string kaydet1 = "INSERT INTO stok(Ürünİsmi,Barkod,Marka,Birim,Giriş,Grup,Kdv,SatışFiyatı,AlışFiyatı,Miktar)VALUES('" + txtÜrünAdı.Text + "','" + txtBarkodKodu.Text + "','" + txtMarka.Text + "','" + cmbBirim.SelectedItem + "','" + nmrcMiktar.Value + "','" + txtGrup.Text + "','" + cmbKdv.SelectedItem + "','" + txtAlış.Text + "','" + txtSatış.Text + "','" + nmrcMiktar.Value + "')";
                    SqlCommand cmd = new SqlCommand(kaydet1, conn);
                    cmd.ExecuteNonQuery();
                    string kaydet2 = "INSERT INTO Kasa(Alış)VALUES('" + txtAlış.Text + "')";
                    SqlCommand cmd2 = new SqlCommand(kaydet2, conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Yeni ürün Kaydedilmiştir.");
                    conn.Close();
                }
                catch (SqlException exe)
                {

                    MessageBox.Show(exe.ToString());

                }
            }
        }
             

        public void Temizle()
        {
            txtÜrünAdı.Text = ""; txtAlış.Text = "";
            txtBarkodKodu.Text = ""; txtMarka.Text = ""; txtSatış.Text = ""; txtGrup.Text = "";
            txtPerakende.Text = ""; nmrcMiktar.Value = 1; cmbBirim.SelectedItem = null;
            txtBarkodKodu.Focus();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void nmrcUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkodKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAlış_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSatış_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPerakende_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtÜrünAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        private void txtMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        private void txtGrup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

      
        
    }
}
