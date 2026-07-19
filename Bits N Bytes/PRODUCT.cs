using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bits_N_Bytes.Database;

namespace Bits_N_Bytes
{
    public partial class PRODUCT : Form
    {
        public PRODUCT()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //HOME
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            //ABOUT

            About about = new About();
            about.Show();
            this.Hide();




        }

        private void label5_Click(object sender, EventArgs e)
        {




        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //HOME
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //VIEWCART



            Viewcart viewcart = new Viewcart();
            viewcart.Show();
            //idk why they duplicate 
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //VIEWCART

            Viewcart viewcart = new Viewcart();
            viewcart.Show();
            //idk why they duplicate 

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            //VIEWCART

            Viewcart viewcart = new Viewcart();
            viewcart.Show();
            //idk why they duplicate 
        }

        //MATERIALBUTTON CODE CONNECTED TO DATABASE
        private void materialButton1_Click(object sender, EventArgs e)
        {
            string productName = "AMD Ryzen 7 5700";
            string description = label4.Text + " " + label5.Text;
            decimal price = decimal.Parse(label3.Text.Replace("₱", "").Replace(",", ""));

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");


        }

        private void mbtnryzen9_Click(object sender, EventArgs e)
        {
            string productName = "AMD Ryzen 9 9950X3D";
            string description = lblnameryzen9.Text + " " + lblspecryzen9.Text;
            decimal price = decimal.Parse(
    lblpriceryzen9.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mtbnryzen5_Click(object sender, EventArgs e)
        {
            string productName = "Ryzen 5 9600X";
            string description = lblnameryzen5.Text + " " + lblspecryen5.Text;
            decimal price = decimal.Parse(
    lblpriceryzen5.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string productName = "Core Ultra 9 285K";
            string description = lblnameintel9.Text + " " + lblsppecintel9.Text;
            decimal price = decimal.Parse(
    lblpriceintel9.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnintel7_Click(object sender, EventArgs e)
        {
            string productName = "Core Ultra 7 265K";
            string description = lblnameintel7.Text + " " + lblspecintel7.Text;
            decimal price = decimal.Parse(
    lblpriceintel7.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnintel5_Click(object sender, EventArgs e)
        {
            string productName = "Core Ultra 5 245K";
            string description = lblnameintel5.Text + " " + lblspecintel5.Text;
            decimal price = decimal.Parse(
    lblpriceintel5.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnrtx5070_Click(object sender, EventArgs e)
        {
            string productName = "RTX 5070";
            string description = lblnamertx5070.Text + " " + lblspecrtx5070.Text;
            decimal price = decimal.Parse(
    lblpricertx5070.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void mbtnrtx5070ti_Click(object sender, EventArgs e)
        {
            string productName = "RTX 5070 ti";
            string description = lblnamertx5070ti.Text + " " + lblspecrtx5070ti.Text;
            decimal price = decimal.Parse(
    lblpricertx5070ti.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnrtx5080_Click(object sender, EventArgs e)
        {
            string productName = "RTX 5080";
            string description = lblnamertx5080.Text + " " + lblspecrtx5080.Text;
            decimal price = decimal.Parse(
    lblpricertx5080.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnrtx5090_Click(object sender, EventArgs e)
        {
            string productName = "RTX 5090";
            string description = lblnamertx5090.Text + " " + lblspecrtx5090;
            decimal price = decimal.Parse(
    lblpricertx5090.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnrtx5060ti_Click(object sender, EventArgs e)
        {
            string productName = "RTX 5060 ti";
            string description = lblnamertx5060ti.Text + " " + lblspecrtx5060ti.Text;
            decimal price = decimal.Parse(
    lblpricertx5060ti.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnmb1_Click(object sender, EventArgs e)
        {
            string productName = "MEG Z890 ACE";
            string description = lblnamemb1.Text + " " + lblspecmb1.Text;
            decimal price = decimal.Parse(
    lblpricemb1.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnmb2_Click(object sender, EventArgs e)
        {
            string productName = "MEG Z890 ACE";
            string description = lblnamemb2.Text + " " + lblspecmb2.Text;
            decimal price = decimal.Parse(
    lblpricemb2.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnmb3_Click(object sender, EventArgs e)
        {
            string productName = "MEG Z890 ACE";
            string description = lblnamemb3.Text + " " + lblspecmb3.Text;
            decimal price = decimal.Parse(
    lblpricemb3.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void mbtnmb4_Click(object sender, EventArgs e)
        {
            string productName = "MAG Z890 Tomahawk WiFi";
            string description = lblnamemb4.Text + " " + lblspecmb4.Text;
            decimal price = decimal.Parse(
    lblpricemb4.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnmb5_Click(object sender, EventArgs e)
        {
            string productName = "PRO Z890-P WiFi";
            string description = lblnamemb5.Text + " " + lblspecmb5.Text;
            decimal price = decimal.Parse(
    lblpricemb5.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnram1_Click(object sender, EventArgs e)
        {
            string productName = "Trident Z5 Royal Neo";
            string description = lblnameram1.Text + " " + lblspecram1.Text;
            decimal price = decimal.Parse(
    lblpriceram1.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnram2_Click(object sender, EventArgs e)
        {
            string productName = "Trident Z5 RGB";
            string description = lblnameram2.Text + " " + lblspecram2.Text;
            decimal price = decimal.Parse(
    lblpriceram2.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnram3_Click(object sender, EventArgs e)
        {
            string productName = "Ripjaws M5 RGB";
            string description = lblnameram3.Text + " " + lblspecram3.Text;
            decimal price = decimal.Parse(
    lblpriceram3.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mbtnram4_Click(object sender, EventArgs e)
        {
            string productName = "Flare X5 ";
            string description = lblnameram4.Text + " " + lblspecram4.Text;
            decimal price = decimal.Parse(
    lblpriceram4.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Bundle bundle = new Bundle();
            bundle.Show();
        }
    }
}
