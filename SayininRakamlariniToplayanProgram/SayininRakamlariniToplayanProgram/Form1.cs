using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayininRakamlariniToplayanProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sayi = txtSayi.Text;
            int toplam=0;
            try
            {
                for (int i = 0; i < sayi.Length; i++)
                {
                    toplam += Convert.ToInt32(sayi[i].ToString());
                }
                MessageBox.Show(toplam.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
