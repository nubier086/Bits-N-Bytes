using Bits_N_Bytes.Database;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bits_N_Bytes
{
    public partial class PRODUCT : Form
    {
        public PRODUCT()
        {
            InitializeComponent();
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

            LoadStocks();

            MessageBox.Show("Added to cart!");
        }

        private void LoadStocks()
        {
            lblStock1.Text = "Stock: " + DatabaseHelper.GetStock(1);
            lblStock2.Text = "Stock: " + DatabaseHelper.GetStock(2);
            lblStock3.Text = "Stock: " + DatabaseHelper.GetStock(3);
            lblStock4.Text = "Stock: " + DatabaseHelper.GetStock(4);
            lblStock5.Text = "Stock: " + DatabaseHelper.GetStock(5);
            lblStock6.Text = "Stock: " + DatabaseHelper.GetStock(6);
            lblStock7.Text = "Stock: " + DatabaseHelper.GetStock(7);
            lblStock8.Text = "Stock: " + DatabaseHelper.GetStock(8);
            lblStock9.Text = "Stock: " + DatabaseHelper.GetStock(9);
            lblStock10.Text = "Stock: " + DatabaseHelper.GetStock(10);
            lblStock11.Text = "Stock: " + DatabaseHelper.GetStock(11);
            lblStock12.Text = "Stock: " + DatabaseHelper.GetStock(12);
            lblStock13.Text = "Stock: " + DatabaseHelper.GetStock(13);
            lblStock14.Text = "Stock: " + DatabaseHelper.GetStock(14);
            lblStock15.Text = "Stock: " + DatabaseHelper.GetStock(15);
            lblStock16.Text = "Stock: " + DatabaseHelper.GetStock(16);
            lblStock17.Text = "Stock: " + DatabaseHelper.GetStock(17);
            lblStock18.Text = "Stock: " + DatabaseHelper.GetStock(18);
            lblStock19.Text = "Stock: " + DatabaseHelper.GetStock(19);
            lblStock20.Text = "Stock: " + DatabaseHelper.GetStock(20);
        }



        private void PRODUCT_Load(object sender, EventArgs e)
        {
            LoadStocks();
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
            AddProductToCart(
            1,
                "AMD Ryzen 7 5700",
                 label4,
                 label5,
                 label3);
        }

        private void mbtnryzen9_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            2,
            "AMD Ryzen 9 9950X3D",
             lblnameryzen9,
             lblspecryzen9,
             lblpriceryzen9);
        }

        private void mtbnryzen5_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            3,
            "Ryzen 5 9600X",
            lblnameryzen5,
            lblspecryen5,
            lblpriceryzen5);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            4,
            "Core Ultra 9 285K",
            lblnameintel9,
            lblsppecintel9,
            lblpriceintel9);
        }

        private void mbtnintel7_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            5,
            "Core Ultra 7 265K",
            lblnameintel7,
            lblspecintel7,
            lblpriceintel7);
        }

        private void mbtnintel5_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            6,
            "Core Ultra 5 245K",
            lblnameintel5,
            lblspecintel5,
            lblpriceintel5);
        }

        private void mbtnrtx5070_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            7,
            "RTX 5070",
            lblnamertx5070,
            lblspecrtx5070,
            lblpricertx5070);
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void mbtnrtx5070ti_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            8,
            "RTX 5070 Ti",
            lblnamertx5070ti,
            lblspecrtx5070ti,
            lblpricertx5070ti);
        }

        private void mbtnrtx5080_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            9,
            "RTX 5080",
            lblnamertx5080,
            lblspecrtx5080,
            lblpricertx5080);
        }

        private void mbtnrtx5090_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            10,
            "RTX 5090",
            lblnamertx5090,
            lblspecrtx5090,
            lblpricertx5090);
        }

        private void mbtnrtx5060ti_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            11,
            "RTX 5060 Ti",
            lblnamertx5060ti,
            lblspecrtx5060ti,
            lblpricertx5060ti);
        }

        private void mbtnmb1_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            12,
            "MEG Z890 ACE",
            lblnamemb1,
            lblspecmb1,
            lblpricemb1);
        }

        private void mbtnmb2_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            13,
            "MEG Z890 ACE",
            lblnamemb2,
            lblspecmb2,
            lblpricemb2);
        }

        private void mbtnmb3_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            14,
            "MEG Z890 ACE",
            lblnamemb3,
            lblspecmb3,
            lblpricemb3);
        }


        private void mbtnmb4_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            15,
            "MAG Z890 Tomahawk WiFi",
            lblnamemb4,
            lblspecmb4,
            lblpricemb4);
        }

        private void mbtnmb5_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            16,
            "PRO Z890-P WiFi",
            lblnamemb5,
            lblspecmb5,
            lblpricemb5);
        }

        private void mbtnram1_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            17,
            "Trident Z5 Royal Neo",
            lblnameram1,
            lblspecram1,
            lblpriceram1);
        }

        private void mbtnram2_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            18,
            "Trident Z5 RGB",
            lblnameram2,
            lblspecram2,
            lblpriceram2);
        }

        private void mbtnram3_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            19,
            "Ripjaws M5 RGB",
            lblnameram3,
            lblspecram3,
            lblpriceram3);
        }

        private void mbtnram4_Click(object sender, EventArgs e)
        {
            AddProductToCart(
            20,
            "Flare X5",
            lblnameram4,
            lblspecram4,
            lblpriceram4);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

            PRODUCT1 product1 = new PRODUCT1();
            product1.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {

            PRODUCT product = new PRODUCT();
            product.Show();
            this.Hide();

        }

        private void label7_Click_1(object sender, EventArgs e)
        {


            PRODUCT1 product1 = new PRODUCT1();
            product1.Show();
            this.Hide();


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text.Trim().ToLower();
            SearchPanel(flowLayoutPanel3, keyword);
        }

        private bool ContainsKeyword(Control control, string keyword)
        {
            if (control is Label lbl &&
                lbl.Text.ToLower().Contains(keyword))
            {
                return true;
            }

            foreach (Control child in control.Controls)
            {
                if (ContainsKeyword(child, keyword))
                    return true;
            }

            return false;
        }

        private void SearchPanel(Control container, string keyword)
        {
            int index = 0;

            foreach (Control product in container.Controls)
            {
                if (!(product is Panel))
                    continue;

                bool found = ContainsKeyword(product, keyword);

                product.Visible = string.IsNullOrWhiteSpace(keyword) || found;

                if (found)
                {
                    container.Controls.SetChildIndex(product, index);
                    index++;
                }
            }
        }

        private void SearchControls(Control parent, string keyword)
        {
            foreach (Control product in parent.Controls)
            {
                bool found = ContainsKeyword(product, keyword);
                product.Visible = string.IsNullOrEmpty(keyword) || found;
            }
        }

        // Handle Enter key in the search textbox
        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsearch.PerformClick();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblStock20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
