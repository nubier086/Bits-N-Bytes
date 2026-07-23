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
    public partial class recent : Form
    {
        public recent()
        {
            InitializeComponent();
        }

        private void recent_Load(object sender, EventArgs e)
        {
            LoadRecentPurchases();
        }

        private void LoadRecentPurchases()
        {
            dgvRecent.DataSource = DatabaseHelper.GetRecentPurchases();
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


    }
}
