using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01
{
    public partial class Form2 : Form
    {
        public double teaspoon = 4.80;
        public double tablespoon = 14.3;
        public double ounce = 28.35;
        public double cup = 226.8;
        public double pound = 453.59;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtGram_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
        private void btnExchange_Click(object sender, EventArgs e)
        {           
            if (cbxSelectUnit.Text == "Teaspoon")
                txtGram.Text = (double.Parse(txtVolume.Text) * teaspoon).ToString();

            if (cbxSelectUnit.Text == "Tablespoon")
                txtGram.Text = (double.Parse(txtVolume.Text) * tablespoon).ToString();

            if (cbxSelectUnit.Text == "Ounce")
                txtGram.Text = (double.Parse(txtVolume.Text) * ounce).ToString();

            if (cbxSelectUnit.Text == "Cup")
                txtGram.Text = (double.Parse(txtVolume.Text) * cup).ToString();

            if (cbxSelectUnit.Text == "Pound")
                txtGram.Text = (double.Parse(txtVolume.Text) * pound).ToString();


        }

        private void cbxSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {           
           
        }
    }
}
