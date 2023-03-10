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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tex1_TextChanged(object sender, EventArgs e)
        {
             
        }
        // poga, kas veic darbībau prēķināt un tiek ievadīts failā
        private void but1_Click(object sender, EventArgs e)
        {
           
            {
               
                string dateTimePicker1 = this.dateTimePicker1.Text;
                string vards = this.vards.Text;
                string nauda = this.nauda.Text;
  
                
                double Rezultats_eur = 0.0;
              
                using (StreamWriter writer = new StreamWriter("ceks.txt"))
                {


                    //ieraksta failā
                    writer.WriteLine(vards.ToString());
                    writer.WriteLine(nauda.ToString());
    
                    // ja ieliek x tad tiek čekots
                    if (sula.Checked)
                    {

                        Rezultats_eur += 6.00;


                        writer.WriteLine("sula_6.00");
                    }
                    if (cepumi.Checked)
                    {

                        Rezultats_eur += 5.00;


                        writer.WriteLine("cepumi_5.00");
                    }
                    if (Šokolāde.Checked)
                    {

                        Rezultats_eur += 3.00;

                        writer.WriteLine("Šokolāde_3.00");
                    }
                    
                    if (sula.Checked && cepumi.Checked && Šokolāde.Checked)
                    {
                        this.daudzums.Text = Rezultats_eur.ToString("0.00");
                    }
                    else if (sula.Checked && cepumi.Checked)
                    {
                        this.daudzums.Text = Rezultats_eur.ToString("0.00");
                    }
                    else if (cepumi.Checked && Šokolāde.Checked)
                    {
                        this.daudzums.Text = Rezultats_eur.ToString("0.00");
                    }
                    if (sula.Checked && Šokolāde.Checked)
                    {
                        this.daudzums.Text = Rezultats_eur.ToString("0.00");
                    }
                    writer.WriteLine(Rezultats_eur.ToString());
                    writer.WriteLine(dateTimePicker1.ToString());


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
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
