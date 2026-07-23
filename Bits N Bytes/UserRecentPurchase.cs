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
    public partial class UserRecentPurchase : Form
    {
        public UserRecentPurchase()
        {
            InitializeComponent();
        }

        private void UserRecentPurchase_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserSession.Username))
            {
                MessageBox.Show("Please log in first.");
                Close();
                return;
            }

            dataGridViewURP1.DataSource =
                DatabaseHelper.GetRecentPurchasesByUser(UserSession.Username);

            dataGridViewURP1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewURP1.DefaultCellStyle.Font =
                new Font("Segoe UI", 12);

            dataGridViewURP1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);

            dataGridViewURP1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewURP1.DefaultCellStyle.BackColor = Color.White;
            dataGridViewURP1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewURP1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }


    }
}
