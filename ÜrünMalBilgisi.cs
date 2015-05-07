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
    public partial class ÜrünMalBilgisi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Akıllı_Market_Satış_Yazılımı ;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public ÜrünMalBilgisi()
        {
            InitializeComponent();
        }
        public void listele()
        {
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Stok", conn);
            da.Fill(dt);
            dataStok.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtMarkaİleAra.Text.Trim() == "")
            {
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Stok", conn);
                da.Fill(dt);
                dataStok.DataSource = dt;
            }
            else
            {

                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Stok where Ürünİsmi Like '%" + txtMarkaİleAra.Text + "%'", conn);
                da.Fill(dt);
                dataStok.DataSource = dt;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ÜrünMalBilgisi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtİsimİleAra.Text.Trim() == "")
            {
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Stok", conn);
                da.Fill(dt);
                dataStok.DataSource = dt;
            }
            else
            {

                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Stok where Marka Like '%" + txtİsimİleAra.Text + "%'", conn);
                da.Fill(dt);
                dataStok.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
