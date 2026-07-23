using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bits_N_Bytes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Hide();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
