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

            dgvCart.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            dgvCart.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCart.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCart.RowTemplate.Height = 40;

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

            // Get the ProductID from the Cart table
            int productId = DatabaseHelper.GetProductIdFromCart(cartId);

            if (dgvCart.Columns[e.ColumnIndex].Name == "Plus")
            {
                // Increase cart quantity
                DatabaseHelper.IncreaseQuantity(cartId);

                // Decrease available stock
                DatabaseHelper.DecreaseStock(productId);

                LoadCart();
            }

            if (dgvCart.Columns[e.ColumnIndex].Name == "Minus")
            {
                // Decrease cart quantity
                DatabaseHelper.DecreaseQuantity(cartId);

                // Return one item to stock
                DatabaseHelper.IncreaseStock(productId);

                LoadCart();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {


            RECEIPT receipt = new RECEIPT();
            receipt.Show();
            this.Hide();


        }


        
    }



}
