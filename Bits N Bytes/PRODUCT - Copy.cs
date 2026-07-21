using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bits_N_Bytes.Database;
using System.Data.SqlClient;

namespace Bits_N_Bytes
{
    public partial class PRODUCT1 : Form
    {

        string connectionString = @"Server=Bits_N_Bytes.Database;Database=Bits_N_Bytes.Database;Trusted_Connection=True;";
        public PRODUCT1()
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


        private void PRODUCT_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

            PRODUCT product = new PRODUCT();
            product.Show();
            this.Hide();


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            //BUNDLE 1


            string productName = "AMD Ryzen 9 9950X3D";
            string description = lblnamebun1.Text + " " + lblspecbun1.Text;
            decimal price = decimal.Parse(
    lblpricebun1.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }

        

        private void materialButton2_Click(object sender, EventArgs e)
        {
            //BUNDLE 2


            string productName = "AMD Ryzen 9 9950X3D";
            string description = lblnamebun2.Text + " " + lblspecbun2.Text;
            decimal price = decimal.Parse(
    lblpricebun2.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }


        

        private void materialButton3_Click(object sender, EventArgs e)
        {
            //BUNDLE 3


            string productName = "AMD Ryzen 9 9950X3D";
            string description = lblnamebun3.Text + " " + lblspecbun3.Text;
            decimal price = decimal.Parse(
    lblpricebun3.Text.Replace("₱", "").Replace(",", "")
);

            DatabaseHelper.AddToCart(productName, description, price);

            MessageBox.Show("Added to cart!");
        }
    }
}




    
    

