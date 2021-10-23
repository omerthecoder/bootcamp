using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminiOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int tutulanSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text)==tutulanSayi)
            {
                lblAsagiYukari.Text = "Tebrikler sayıyı doğru tahmin ettiniz.";
                btnStart.Enabled = true;
                button1.Enabled = false;
                textBox1.Enabled = false;
            }
            else if (Convert.ToInt32(textBox1.Text) < tutulanSayi)
            {
                lblAsagiYukari.Text = "Daha yüksek bir sayı giriniz.";
            }
            else if (Convert.ToInt32(textBox1.Text) > tutulanSayi)
            {
                lblAsagiYukari.Text="Daha düşük bir sayı giriniz.";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tutulanSayi = rnd.Next(0, 100);
            btnStart.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
        }
    }
}
