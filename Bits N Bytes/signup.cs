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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Login login = new Login();
            login.Show();
            this.Hide();


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(USERNAME.Text) ||
       string.IsNullOrWhiteSpace(PASSWORD.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool success = DatabaseHelper.RegisterUser(
                USERNAME.Text,
                PASSWORD.Text);

            if (!success)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            MessageBox.Show("Account created successfully!");

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }

 }
