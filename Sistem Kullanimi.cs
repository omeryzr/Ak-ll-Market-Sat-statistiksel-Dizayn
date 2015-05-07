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
    public partial class Sistem_Kullanimi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OMER;Initial Catalog=Akıllı_Market_Satış_Yazılımı;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
       
        public Sistem_Kullanimi()
        {
            InitializeComponent();
        }
        public void listele()
        {
            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * From SistemKullanimi", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Sistem_Kullanimi_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
