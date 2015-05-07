using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string islem = String.Empty;
        public double sayi1 = 0;

        private void Ekle(object sender, EventArgs e)
        {
            txt_ekran.Text += (sender as Button).Text;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_ekran.Text = "0";
            islem = String.Empty;
        }

        private void Islem(object sender, EventArgs e)
        {
            islem = (sender as Button).Text;
            sayi1 = Convert.ToDouble(txt_ekran.Text);
            txt_ekran.Text = "0";
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(txt_ekran.Text);

            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "x":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    MessageBox.Show("İşlem seçmelisiniz!", "Hata");
                    break;
            }

            txt_ekran.Text = sonuc.ToString();
            islem = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

