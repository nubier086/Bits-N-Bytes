using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bits_N_Bytes
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //HOME LOGO
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //PRODUCT
            PRODUCT product = new PRODUCT();
            product.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //HOME BUTTON

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
