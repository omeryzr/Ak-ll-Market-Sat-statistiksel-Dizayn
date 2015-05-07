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
    
    public partial class Satis : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Akıllı_Market_Satış_Yazılımı ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public Satis()
        {
            InitializeComponent();
        }

        private void listele()
        {
            
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select Kod,Ürünİsmi,Barkod,Miktar,SatışFiyatı,Kdv,ToplamSatış From Adisyon", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Satis_Load(object sender, EventArgs e)
        {
            /*
            listele1();
            dataSatis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          */
            
            IDDoldur();
            cmbÜrünKodu.SelectedIndex = 0;
            topla();
            Tarih();
            
        }
        public void Sil(int Kod)
        {
            SqlCommand sil = new SqlCommand("DELETE  FROM Stok WHERE Kod=" + Kod + "", conn);


            try
            {
                conn.Open();
                sil.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void IDDoldur()
        {
            cmbÜrünKodu.Items.Clear();

            SqlCommand veri = new SqlCommand("SELECT Kod FROM Stok ORDER BY Kod", conn);
            SqlDataReader oku = null;
            try
            {
                conn.Open();
                oku = veri.ExecuteReader();
                while (oku.Read())
                {
                    cmbÜrünKodu.Items.Add(oku.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oku.Close();
                conn.Close();
            }
        }
        public void IDyeGoreFormDoldur(int Kod)
        {
            SqlCommand veri = new SqlCommand("SELECT Kod,Ürünİsmi,Barkod,SatışFiyatı,Kdv FROM Stok where Kod=" + Kod + "", conn);
            SqlDataReader oku = null;
            try
            {
                conn.Open();

                oku = veri.ExecuteReader();

                if (oku.Read())
                {
                    
                    txtÜrünİsmi.Text = oku["Ürünİsmi"].ToString();
                    txtBarkod.Text = oku["Barkod"].ToString();
                    txtÜrünFiyatı.Text = oku["SatışFiyatı"].ToString();
                    cmbKdv.Text = oku["Kdv"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oku.Close();
                conn.Close();
            }
        }
        public void topla()
        {
            
            Double topla = 0;
            int a = dataGridView1.Rows.Count;
            for (int i = 0; i < a - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value !=DBNull.Value)
                    topla = topla + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            txtGenelTop.Text = topla.ToString();


        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void Kaydet()
        {
            SqlCommand kaydet = new SqlCommand("INSERT INTO Adisyon(Kod,Ürünİsmi,Barkod,Miktar,SatışFiyatı,Kdv,ToplamSatış) VALUES ('" + cmbÜrünKodu.Text + "','"
                + txtÜrünİsmi.Text + "','" + txtBarkod.Text + "','" + nmrcMiktar.Value + "','" + txtÜrünFiyatı.Text + "','" + cmbKdv.Text + "','" + txtToplamFiyat.Text + "')", conn);

            try
            {
                conn.Open();
                kaydet.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void Tarih()
        {
            DateTime dt = DateTime.Now;

            lblTarih.Text = dt.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) 
        {
            
        }

        public void sil() 
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from Stok where Kod='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Kaydet();
            listele();
            IDDoldur();
            sil();
            topla();
            cmbÜrünKodu.SelectedIndex = cmbÜrünKodu.Items.Count - 1;
        }

        private void cmbKdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDyeGoreFormDoldur(Convert.ToInt32(cmbÜrünKodu.SelectedItem));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("INSERT INTO SatılanÜrünler(Kod,Ürünİsmi,Barkod,Miktar,SatışFiyatı,Kdv,ToplamSatış) VALUES ('" + cmbÜrünKodu.Text + "','"
                + txtÜrünİsmi.Text + "','" + txtBarkod.Text + "','" + nmrcMiktar.Value + "','" + txtÜrünFiyatı.Text + "','" + cmbKdv.Text + "','" + txtToplamFiyat.Text + "')", conn);

            try
            {
                conn.Open();
                kaydet.ExecuteNonQuery();
                string kaydet2 = "INSERT INTO Kasa(Satış)VALUES('" + txtGenelTop.Text + "')";
                SqlCommand cmd2 = new SqlCommand(kaydet2, conn);
                cmd2.ExecuteNonQuery();
                string kaydet3 = "INSERT INTO Satışlar(Satış,Tarih)VALUES('" + txtGenelTop.Text + "','"+lblTarih.Text+"')";
                SqlCommand cmd3 = new SqlCommand(kaydet3, conn);
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Delete  from Adisyon ";
            cmd.ExecuteNonQuery();
            listele();
            conn.Close();
            MessageBox.Show("Satış Tamamlandı.");

            
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void txtGenelTop_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            topla();
        }

        private void label5_Click(object sender, EventArgs e)
        {


            Tarih();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

            
        }
    }

