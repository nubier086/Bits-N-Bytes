namespace Bits_N_Bytes
{
    partial class RECEIPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label9 = new Label();
            bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            label1 = new Label();
            bigTextBox2 = new ReaLTaiizor.Controls.BigTextBox();
            bigTextBox3 = new ReaLTaiizor.Controls.BigTextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            productModelsBindingSource = new BindingSource(components);
            dgvCart = new DataGridView();
            lblTotal = new Label();
            bigTextBox7 = new ReaLTaiizor.Controls.BigTextBox();
            label4 = new Label();
            bigTextBox4 = new ReaLTaiizor.Controls.BigTextBox();
            bigTextBox5 = new ReaLTaiizor.Controls.BigTextBox();
            label2 = new Label();
            label3 = new Label();
            airRadioButton1 = new ReaLTaiizor.Controls.AirRadioButton();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)productModelsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(44, 85);
            label9.Name = "label9";
            label9.Size = new Size(87, 32);
            label9.TabIndex = 20;
            label9.Text = "EMAIL";
            // 
            // bigTextBox1
            // 
            bigTextBox1.BackColor = Color.Transparent;
            bigTextBox1.Font = new Font("Tahoma", 11F);
            bigTextBox1.ForeColor = Color.DimGray;
            bigTextBox1.Image = null;
            bigTextBox1.Location = new Point(44, 135);
            bigTextBox1.MaxLength = 32767;
            bigTextBox1.Multiline = false;
            bigTextBox1.Name = "bigTextBox1";
            bigTextBox1.PlaceholderText = "example12345@gmail.com";
            bigTextBox1.ReadOnly = false;
            bigTextBox1.Size = new Size(403, 41);
            bigTextBox1.TabIndex = 21;
            bigTextBox1.TextAlignment = HorizontalAlignment.Left;
            bigTextBox1.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(44, 205);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 22;
            label1.Text = "NAME";
            // 
            // bigTextBox2
            // 
            bigTextBox2.BackColor = Color.Transparent;
            bigTextBox2.Font = new Font("Tahoma", 11F);
            bigTextBox2.ForeColor = Color.DimGray;
            bigTextBox2.Image = null;
            bigTextBox2.Location = new Point(44, 264);
            bigTextBox2.MaxLength = 32767;
            bigTextBox2.Multiline = false;
            bigTextBox2.Name = "bigTextBox2";
            bigTextBox2.ReadOnly = false;
            bigTextBox2.Size = new Size(184, 41);
            bigTextBox2.TabIndex = 23;
            bigTextBox2.Text = "First Name";
            bigTextBox2.TextAlignment = HorizontalAlignment.Left;
            bigTextBox2.UseSystemPasswordChar = false;
            // 
            // bigTextBox3
            // 
            bigTextBox3.BackColor = Color.Transparent;
            bigTextBox3.Font = new Font("Tahoma", 11F);
            bigTextBox3.ForeColor = Color.DimGray;
            bigTextBox3.Image = null;
            bigTextBox3.Location = new Point(263, 264);
            bigTextBox3.MaxLength = 32767;
            bigTextBox3.Multiline = false;
            bigTextBox3.Name = "bigTextBox3";
            bigTextBox3.ReadOnly = false;
            bigTextBox3.Size = new Size(184, 41);
            bigTextBox3.TabIndex = 24;
            bigTextBox3.Text = "Last Name";
            bigTextBox3.TextAlignment = HorizontalAlignment.Left;
            bigTextBox3.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1112, 699);
            materialButton1.Margin = new Padding(4, 7, 4, 7);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(98, 36);
            materialButton1.TabIndex = 32;
            materialButton1.Text = "CHECKOUT";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.Location = new Point(500, 119);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.Size = new Size(498, 442);
            dgvCart.TabIndex = 33;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Black;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(880, 564);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 30);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "Total: ₱0.00";
            // 
            // bigTextBox7
            // 
            bigTextBox7.BackColor = Color.Transparent;
            bigTextBox7.Font = new Font("Tahoma", 11F);
            bigTextBox7.ForeColor = Color.DimGray;
            bigTextBox7.Image = null;
            bigTextBox7.Location = new Point(44, 385);
            bigTextBox7.MaxLength = 32767;
            bigTextBox7.Multiline = false;
            bigTextBox7.Name = "bigTextBox7";
            bigTextBox7.PlaceholderText = "ADDRESS LINE 1";
            bigTextBox7.ReadOnly = false;
            bigTextBox7.Size = new Size(403, 41);
            bigTextBox7.TabIndex = 42;
            bigTextBox7.Tag = "";
            bigTextBox7.Text = " ADDRESS LINE 1";
            bigTextBox7.TextAlignment = HorizontalAlignment.Left;
            bigTextBox7.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(44, 335);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 41;
            label4.Text = "ADDRESS";
            // 
            // bigTextBox4
            // 
            bigTextBox4.BackColor = Color.Transparent;
            bigTextBox4.Font = new Font("Tahoma", 11F);
            bigTextBox4.ForeColor = Color.DimGray;
            bigTextBox4.Image = null;
            bigTextBox4.Location = new Point(263, 496);
            bigTextBox4.MaxLength = 32767;
            bigTextBox4.Multiline = false;
            bigTextBox4.Name = "bigTextBox4";
            bigTextBox4.ReadOnly = false;
            bigTextBox4.Size = new Size(184, 41);
            bigTextBox4.TabIndex = 44;
            bigTextBox4.Text = "Last Name";
            bigTextBox4.TextAlignment = HorizontalAlignment.Left;
            bigTextBox4.UseSystemPasswordChar = false;
            // 
            // bigTextBox5
            // 
            bigTextBox5.BackColor = Color.Transparent;
            bigTextBox5.Font = new Font("Tahoma", 11F);
            bigTextBox5.ForeColor = Color.DimGray;
            bigTextBox5.Image = null;
            bigTextBox5.Location = new Point(44, 496);
            bigTextBox5.MaxLength = 32767;
            bigTextBox5.Multiline = false;
            bigTextBox5.Name = "bigTextBox5";
            bigTextBox5.ReadOnly = false;
            bigTextBox5.Size = new Size(184, 41);
            bigTextBox5.TabIndex = 43;
            bigTextBox5.Text = "First Name";
            bigTextBox5.TextAlignment = HorizontalAlignment.Left;
            bigTextBox5.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(44, 457);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 45;
            label2.Text = "CITY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(263, 457);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 46;
            label3.Text = "Zip Code";
            // 
            // airRadioButton1
            // 
            airRadioButton1.Checked = false;
            airRadioButton1.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            airRadioButton1.Field = 16;
            airRadioButton1.Font = new Font("Segoe UI", 9F);
            airRadioButton1.Image = null;
            airRadioButton1.Location = new Point(86, 641);
            airRadioButton1.Name = "airRadioButton1";
            airRadioButton1.NoRounding = false;
            airRadioButton1.Size = new Size(110, 17);
            airRadioButton1.TabIndex = 47;
            airRadioButton1.Text = "Cash on Delivery";
            airRadioButton1.Transparent = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(56, 590);
            label5.Name = "label5";
            label5.Size = new Size(243, 32);
            label5.TabIndex = 48;
            label5.Text = "MODE OF PAYMENT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(106, 641);
            label6.Name = "label6";
            label6.Size = new Size(113, 17);
            label6.TabIndex = 49;
            label6.Text = "Cash on Delivery";
            // 
            // RECEIPT
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1223, 793);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(airRadioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bigTextBox4);
            Controls.Add(bigTextBox5);
            Controls.Add(bigTextBox7);
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(dgvCart);
            Controls.Add(materialButton1);
            Controls.Add(bigTextBox3);
            Controls.Add(bigTextBox2);
            Controls.Add(label1);
            Controls.Add(bigTextBox1);
            Controls.Add(label9);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "RECEIPT";
            Text = "RECEIPT";
            ((System.ComponentModel.ISupportInitialize)productModelsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private Label label1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox2;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private BindingSource productModelsBindingSource;
        private DataGridView dgvCart;
        private Label lblTotal;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox7;
        private Label label4;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox4;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox5;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.AirRadioButton airRadioButton1;
        private Label label5;
        private Label label6;
    }
}