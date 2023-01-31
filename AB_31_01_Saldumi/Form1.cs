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
            double nauda = Convert.ToDouble(this.nauda);
            double saldums = 9.88;
            double daudzums = nauda / saldums;
            daudzums = Math.Round(daudzums, 2);
            this.izmaksa.Text = Convert.ToString(daudzums);


        }

        private void tex2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
