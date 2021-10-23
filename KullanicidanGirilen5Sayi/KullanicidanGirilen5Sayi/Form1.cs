﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicidanGirilen5Sayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblToplam_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null & textBox2.Text != null & textBox3.Text != null & textBox4.Text != null & textBox5.Text != null)
                {
                    int toplam = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox5.Text);
                    lblToplam.Text = toplam.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
