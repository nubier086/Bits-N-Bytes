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
            string description = lblnameryzen9 + " " + lblspecryzen9;
            decimal price = decimal.Parse(
    lblpriceryzen9.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void mtbnryzen5_Click(object sender, EventArgs e)
        {
            string productName = "Ryzen 5 9600X";
            string description = lblnameryzen5 + " " + lblspecryen5;
            decimal price = decimal.Parse(
    lblpriceryzen5.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string productName = "Core Ultra 9 285K";
            string description = lblnameintel9 + " " + lblsppecintel9;
            decimal price = decimal.Parse(
    lblpriceintel9.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }
    }
}
