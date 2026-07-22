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
            LoadStocks();
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

        private void AddProductToCart(
         int productId,
         string productName,
         Label nameLabel,
         Label specLabel,
         Label priceLabel)



        {
            int stock = DatabaseHelper.GetStock(productId);

            if (stock <= 0)
            {
                MessageBox.Show("Out of Stock!");
                return;
            }

            string description = nameLabel.Text + " " + specLabel.Text;

            decimal price = decimal.Parse(
                priceLabel.Text.Replace("₱", "").Replace(",", "")
            );

            DatabaseHelper.AddToCart(productId, productName, description, price);

            DatabaseHelper.DecreaseStock(productId);

            MessageBox.Show("Added to cart!");

            LoadStocks();
        }


        private void LoadStocks()
        {
            lblStock21.Text = "Stock: " + DatabaseHelper.GetStock(21);
            lblStock22.Text = "Stock: " + DatabaseHelper.GetStock(22);
            lblStock23.Text = "Stock: " + DatabaseHelper.GetStock(23);
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {

            //BUNDLE 1


            AddProductToCart(
            21,
            "Bundle 1",
            lblnamebun1,
            lblspecbun1,
            lblpricebun1);
        }

        

        private void materialButton2_Click(object sender, EventArgs e)
        {
            //BUNDLE 2

            AddProductToCart(
        22,
            "Bundle 2",
            lblnamebun2,
            lblspecbun2,
            lblpricebun2);
        }
        


        

        private void materialButton3_Click(object sender, EventArgs e)
        {
            // BUNDLE 3
            AddProductToCart(
                23,
                "Bundle 3",
                lblnamebun3,
                lblspecbun3,
                lblpricebun3);
        }
    }
}




    
    

