using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                string vards = this.vards.Text;
                string nauda = this.nauda.Text;
                double nauda_daudzums_eur = Convert.ToDouble(this.nauda.Text);
                double Rezultats_eur = 0;
                double cena = 9.88;
                Rezultats_eur = nauda_daudzums_eur / cena;
                Rezultats_eur = Math.Round(Rezultats_eur, 2);
                this.daudzums.Text = Rezultats_eur.ToString();
                using (StreamWriter writer = new StreamWriter("ceks.txt"))
                {
                    //ieraksta failā
                    writer.WriteLine(vards.ToString());
                    writer.WriteLine(nauda.ToString());
                    writer.WriteLine(Rezultats_eur.ToString());
                }

            }

        }

        private void tex2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
           
           try
            {
                double nauda_daudzums_eur = Convert.ToDouble(this.nauda.Text);
                double Rezultats_eur = 0;
                double cena = 3.00;
                Rezultats_eur = nauda_daudzums_eur / cena;
                Rezultats_eur = Math.Round(Rezultats_eur, 2);
                this.daudzums.Text = Rezultats_eur.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nebija ievadīts korekti dati!!!");
                MessageBox.Show(ex.Message);

            }
           




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double nauda_daudzums_eur = Convert.ToDouble(this.nauda.Text);
                double Rezultats_eur = 0;
                double cena = 5.00;
                Rezultats_eur = nauda_daudzums_eur / cena;
                Rezultats_eur = Math.Round(Rezultats_eur, 2);
                this.daudzums.Text = Rezultats_eur.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nebija ievadīts korekti dati!!!");
                MessageBox.Show(ex.Message);

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double nauda_daudzums_eur = Convert.ToDouble(this.nauda.Text);
                double Rezultats_eur = 0;
                double cena = 6.00;
                Rezultats_eur = nauda_daudzums_eur / cena;
                Rezultats_eur = Math.Round(Rezultats_eur, 2);
                this.daudzums.Text = Rezultats_eur.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nebija ievadīts korekti dati!!!");
                MessageBox.Show(ex.Message);

            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("ceks.txt"))
            {
                // Write the result to the file
                writer.WriteLine(vards.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
