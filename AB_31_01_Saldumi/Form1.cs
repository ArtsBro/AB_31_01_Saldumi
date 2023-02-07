using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_31_01_Saldumi
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tex1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
           
            {
                double nauda_daudzums_eur = Convert.ToDouble(this.Nauda_daudzums_textbox.Text);
                double Rezultats_eur = 0;
                double cena = 9.88;
                Rezultats_eur = nauda_daudzums_eur / cena;
                Rezultats_eur = Math.Round(Rezultats_eur, 2);
                this.daudzums.Text = Rezultats_eur.ToString();
            }

        }

        private void tex2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
           
           if (checkbox1.Checked == true)
            {
              cena1 = 222.00;
            }
           else
            {
              cena1 = 2.00;
            }
           
           




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox2.Checked == true)
            {
                cena2 = 230.00;
            }
            else
            {
                cena2 = 2.50;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox3.Checked == true)
            {
                cena3 = 234.00;
            }
            else
            {
                cena3 = 3.00;
            }



        }
    }
}
