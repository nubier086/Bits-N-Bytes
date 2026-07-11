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
    public partial class Viewcart : Form
    {
        public Viewcart()
        {
            InitializeComponent();
            LoadCart();
        }

        private void LoadCart()
        {
            dgvCart.DataSource = DatabaseHelper.GetCartItems();

            if (dgvCart.Columns.Contains("CartID"))
            {
                dgvCart.Columns["CartID"].Visible = false;
            }

            if (!dgvCart.Columns.Contains("Plus"))
            {
                DataGridViewButtonColumn plus = new DataGridViewButtonColumn();
                plus.Name = "Plus";
                plus.HeaderText = "";
                plus.Text = "+";
                plus.UseColumnTextForButtonValue = true;

                dgvCart.Columns.Add(plus);
            }

            if (!dgvCart.Columns.Contains("Minus"))
            {
                DataGridViewButtonColumn minus = new DataGridViewButtonColumn();
                minus.Name = "Minus";
                minus.HeaderText = "";
                minus.Text = "-";
                minus.UseColumnTextForButtonValue = true;

                dgvCart.Columns.Add(minus);
            }
        }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            DatabaseHelper.ClearCart();

            dgvCart.DataSource = DatabaseHelper.GetCartItems();

            if (!dgvCart.Columns.Contains("Plus"))
            {
                DataGridViewButtonColumn plus = new DataGridViewButtonColumn();
                plus.Name = "Plus";
                plus.HeaderText = "";
                plus.Text = "+";
                plus.UseColumnTextForButtonValue = true;

                dgvCart.Columns.Add(plus);
            }

            if (!dgvCart.Columns.Contains("Minus"))
            {
                DataGridViewButtonColumn minus = new DataGridViewButtonColumn();
                minus.Name = "Minus";
                minus.HeaderText = "";
                minus.Text = "-";
                minus.UseColumnTextForButtonValue = true;

                dgvCart.Columns.Add(minus);
            }

            MessageBox.Show("Cart has been cleared.");
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


    }
}
