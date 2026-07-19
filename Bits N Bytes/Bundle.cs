using Bits_N_Bytes.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bits_N_Bytes
{
    public partial class Bundle : Form
    {
        public Bundle()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Bundle bundle = new Bundle();
            bundle.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
        }

        private void Bundle_Load(object sender, EventArgs e)
        {

        }

        private void mbtnbndl1_Click(object sender, EventArgs e)
        {
            string productName = "Low Range Bundle";
            string description = lblnamebndl1.Text + " " + lblspecbndl1.Text;
            decimal price = decimal.Parse(
    lblpricebndl1.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //VIEWCART

            Viewcart viewcart = new Viewcart();
            viewcart.Show();
            //idk why they duplicate 
        }

        private void mbtnbndl2_Click(object sender, EventArgs e)
        {
            string productName = "Mid Range Bundle";
            string description = lblnamebndl2.Text + " " + lblspecbndl2.Text;
            decimal price = decimal.Parse(
    lblpricebndl2.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnbndl3_Click(object sender, EventArgs e)
        {
            string productName = "High Range Bundle";
            string description = lblnamebndl3.Text + " " + lblspecbndl3.Text;
            decimal price = decimal.Parse(
    lblpricebndl3.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }
    }
}
