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
    
    public partial class Personelbilgi : Form

    {
        
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Akıllı_Market_Satış_Yazılımı ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
       
        public Personelbilgi()
        {
            InitializeComponent();
        }
       
               
                
        
       public void listele()      
      {



                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * From personellist",conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
                
                
       }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void Personelbilgi_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[1].HeaderText = "Tc Kimlik No";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
        TckimlikNo Sorgulama = new TckimlikNo();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sira;
            sira = dataGridView1.CurrentRow.Index;

            txtTc.Text = dataGridView1.Rows[sira].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[sira].Cells[2].Value.ToString();
            txtAd.Text = dataGridView1.Rows[sira].Cells[3].Value.ToString();
            txtBabaAdi.Text=dataGridView1.Rows[sira].Cells[4].Value.ToString();
            txtAnaAdi.Text=dataGridView1.Rows[sira].Cells[5].Value.ToString();
            cmbDogumYeri.SelectedItem=dataGridView1.Rows[sira].Cells[6].Value.ToString();
            cmbCinsiyet.SelectedItem=dataGridView1.Rows[sira].Cells[7].Value.ToString();
            mskDoğumTarihi.Text=dataGridView1.Rows[sira].Cells[8].Value.ToString();
            cmbMedeniHali.SelectedItem=dataGridView1.Rows[sira].Cells[9].Value.ToString();
            cmbEğitimDurumu.SelectedItem=dataGridView1.Rows[sira].Cells[10].Value.ToString();
            mskCepNo.Text=dataGridView1.Rows[sira].Cells[11].Value.ToString();
            mskEvNo.Text=dataGridView1.Rows[sira].Cells[12].Value.ToString();
            txtAdres.Text=dataGridView1.Rows[sira].Cells[13].Value.ToString();
            mskİşeGirişTarihi.Text=dataGridView1.Rows[sira].Cells[14].Value.ToString();

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTCAra.Text.Trim() == "")
            {
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from personellist", conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from personellist where TCNo Like '%" +txtTCAra.Text+ "%'", conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }    
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
        //Cinsiyet,DoğumTarihi,MedeniHali,EğitimDurumu,CepNo,EvNo,AdresBilgileri,İşeGirişTarihi,DoğumYeri

      
        private void button3_Click(object sender, EventArgs e)
        {

            if (Sorgulama.TcNoSorgula(txtTc.Text))
            {
            try
            {
                
                conn.Open();
                string DoğumTarihi = mskDoğumTarihi.Text;
                string CepNo = mskCepNo.Text;
                string EvNo = mskEvNo.Text;
                string İşeGirişTarihi = mskİşeGirişTarihi.Text;
                string komut = "INSERT INTO personellist(TCNo,Soyadı,Adı,BabaAdı,AnaAdı,DoğumYeri,Cinsiyet,DoğumTarihi,MedeniHali,EğitimDurumu,CepNo,EvNo,AdresBilgileri,İşeGirişTarihi)VALUES('" + txtTc.Text + "','" + txtSoyad.Text + "','" + txtAd.Text + "','" + txtBabaAdi.Text + "','" + txtAnaAdi.Text + "','" + cmbDogumYeri.SelectedItem + "','" + cmbCinsiyet.SelectedItem + "','" + mskDoğumTarihi.Text + "','" + cmbMedeniHali.SelectedItem + "','" + cmbEğitimDurumu.SelectedItem + "','" + mskCepNo.Text + "','" + mskEvNo.Text + "','" + txtAdres.Text + "','" + mskİşeGirişTarihi.Text + "')";
                SqlCommand cmd = new SqlCommand(komut, conn);
                cmd.ExecuteNonQuery();
                listele();
                conn.Close();
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.ToString());

            }
            }
            else
                MessageBox.Show("Tc kimlik Numarasını Yanlış Girdiniz");
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Silme Menüsü", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from personellist where TCNo='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                listele();
                MessageBox.Show("Personel Kaydı Silindi.");
            }
            /*
            string komut = "Delete from personellist where TCNo '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            
            cmd.ExecuteNonQuery();
            listele();
            conn.Close();
           */
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAdAra.Text.Trim() == "")
            {
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from personellist", conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {

                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from personellist where Adı Like '%" + txtAdAra.Text + "%'", conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }  
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int sira;
            sira = dataGridView1.CurrentRow.Index;

            txtTc.Text = dataGridView1.Rows[sira].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[sira].Cells[2].Value.ToString();
            txtAd.Text = dataGridView1.Rows[sira].Cells[3].Value.ToString();
            txtBabaAdi.Text = dataGridView1.Rows[sira].Cells[4].Value.ToString();
            txtAnaAdi.Text = dataGridView1.Rows[sira].Cells[5].Value.ToString();
            cmbDogumYeri.SelectedItem = dataGridView1.Rows[sira].Cells[6].Value.ToString();
            cmbCinsiyet.SelectedItem = dataGridView1.Rows[sira].Cells[7].Value.ToString();
            mskDoğumTarihi.Text = dataGridView1.Rows[sira].Cells[8].Value.ToString();
            cmbMedeniHali.SelectedItem = dataGridView1.Rows[sira].Cells[9].Value.ToString();
            cmbEğitimDurumu.SelectedItem = dataGridView1.Rows[sira].Cells[10].Value.ToString();
            mskCepNo.Text = dataGridView1.Rows[sira].Cells[11].Value.ToString();
            mskEvNo.Text = dataGridView1.Rows[sira].Cells[12].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[sira].Cells[13].Value.ToString();
            mskİşeGirişTarihi.Text = dataGridView1.Rows[sira].Cells[14].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        private void txtBabaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        private void txtAnaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        private void txtTCAra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAdAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int secilen = comboBox1.SelectedIndex;
            switch (secilen)
            {
                case 0: pictureBox1.Image = PersonelResim.ayşe; break;
                case 1: pictureBox1.Image = PersonelResim.fatma; break;
                case 2: pictureBox1.Image = PersonelResim.Hasan; break;
                case 3: pictureBox1.Image = PersonelResim.Hayriye; break;
                case 4: pictureBox1.Image = PersonelResim.mustafa; break;
                case 5: pictureBox1.Image = PersonelResim.Talha; break;
                default:
                    pictureBox1.Image = PersonelResim.Omer;break;

                

            }
        }
    }
}
