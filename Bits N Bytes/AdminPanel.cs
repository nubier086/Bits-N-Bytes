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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridViewPRODUCTLIST1.DataSource = DatabaseHelper.GetProducts();
        }


        //ADMIN PANEL LOAD EVENT HANDLER
        private void ADMINLABEL1_Click(object sender, EventArgs e)
        {

        }

        //NUMERIC UP AND DOWN VALUE CHANGED EVENT HANDLER
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        //COLOR DATAGRIDVIEW EVENT HANDLER
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadProducts();

            dataGridViewPRODUCTLIST1.EnableHeadersVisualStyles = false;

            dataGridViewPRODUCTLIST1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPRODUCTLIST1.DefaultCellStyle.BackColor = Color.White;

            dataGridViewPRODUCTLIST1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPRODUCTLIST1.RowsDefaultCellStyle.BackColor = Color.White;

            dataGridViewPRODUCTLIST1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPRODUCTLIST1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dataGridViewPRODUCTLIST1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPRODUCTLIST1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        }

        private void searchbtn1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(producttextbox.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            DataTable table = DatabaseHelper.SearchProduct(productId);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            dataGridViewPRODUCTLIST1.DataSource = table;

            numericUpDown1.Value = Convert.ToDecimal(table.Rows[0]["Stock"]);
        }

        private void buttonUPDATESTOCK1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(producttextbox.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            DatabaseHelper.UpdateStock(productId, (int)numericUpDown1.Value);

            MessageBox.Show("Stock updated successfully!");

            LoadProducts();
        }
    }
}
