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
    }
}
