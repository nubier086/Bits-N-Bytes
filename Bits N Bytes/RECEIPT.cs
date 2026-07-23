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
    public partial class RECEIPT : Form
    {
        public RECEIPT()
        {
            InitializeComponent();
            LoadCart();

            dgvCart.DefaultCellStyle.ForeColor = Color.Black;
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCart.DefaultCellStyle.BackColor = Color.White;
            dgvCart.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Price"].Value != null &&
                    row.Cells["Quantity"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

                    total += price * qty;
                }
            }

            lblTotal.Text = "Total: ₱" + total.ToString("N2");
        }


        private void LoadCart()
        {
            dgvCart.DataSource = DatabaseHelper.GetCartItems();

            if (dgvCart.Columns.Contains("CartID"))
            {
                dgvCart.Columns["CartID"].Visible = false;
            }
            dgvCart.DataSource = DatabaseHelper.GetCartItems();

            if (dgvCart.Columns.Contains("CartID"))
            {
                dgvCart.Columns["CartID"].Visible = false;
            }

            CalculateTotal();

        }



        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            int cartId = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells["CartID"].Value);

            if (dgvCart.Columns[e.ColumnIndex].Name == "Plus")
            {
                DatabaseHelper.IncreaseQuantity(cartId);
                LoadCart();
            }

            if (dgvCart.Columns[e.ColumnIndex].Name == "Minus")
            {
                DatabaseHelper.DecreaseQuantity(cartId);
                LoadCart();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(UserSession.Username))
            {
                DialogResult result = MessageBox.Show(
                    "You need to create an account or log in before checking out.\n\nWould you like to go to the Login page?",
                    "Account Required",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();   // or this.Close();
                }

                return;
            }

            DatabaseHelper.SaveCartReceipt(UserSession.Username);

            MessageBox.Show("Receipt Sent to Email. Thank you for purchasing!");

            DatabaseHelper.ClearCart2();

            LoadCart();

        }
    }
}

