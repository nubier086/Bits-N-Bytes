namespace Bits_N_Bytes
{
    partial class AdminPanel
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            ADMINLABEL1 = new Label();
            dataGridViewPRODUCTLIST1 = new DataGridView();
            labelPRODUCTNAME2 = new Label();
            producttextbox = new TextBox();
            labelSTOCK3 = new Label();
            numericUpDown1 = new NumericUpDown();
            buttonUPDATESTOCK1 = new Button();
            searchbtn1 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPRODUCTLIST1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // ADMINLABEL1
            // 
            ADMINLABEL1.AutoSize = true;
            ADMINLABEL1.BackColor = Color.Transparent;
            ADMINLABEL1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADMINLABEL1.ForeColor = SystemColors.ActiveCaptionText;
            ADMINLABEL1.Location = new Point(287, 9);
            ADMINLABEL1.Name = "ADMINLABEL1";
            ADMINLABEL1.Size = new Size(215, 21);
            ADMINLABEL1.TabIndex = 0;
            ADMINLABEL1.Text = "ADMIN INVENTORY PANEL";
            ADMINLABEL1.Click += ADMINLABEL1_Click;
            // 
            // dataGridViewPRODUCTLIST1
            // 
            dataGridViewPRODUCTLIST1.AllowUserToAddRows = false;
            dataGridViewPRODUCTLIST1.AllowUserToDeleteRows = false;
            dataGridViewPRODUCTLIST1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewPRODUCTLIST1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPRODUCTLIST1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPRODUCTLIST1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPRODUCTLIST1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPRODUCTLIST1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewPRODUCTLIST1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPRODUCTLIST1.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewPRODUCTLIST1.Location = new Point(12, 98);
            dataGridViewPRODUCTLIST1.MultiSelect = false;
            dataGridViewPRODUCTLIST1.Name = "dataGridViewPRODUCTLIST1";
            dataGridViewPRODUCTLIST1.ReadOnly = true;
            dataGridViewPRODUCTLIST1.RowHeadersVisible = false;
            dataGridViewPRODUCTLIST1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPRODUCTLIST1.Size = new Size(776, 226);
            dataGridViewPRODUCTLIST1.TabIndex = 1;
            // 
            // labelPRODUCTNAME2
            // 
            labelPRODUCTNAME2.AutoSize = true;
            labelPRODUCTNAME2.BackColor = Color.Transparent;
            labelPRODUCTNAME2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPRODUCTNAME2.ForeColor = SystemColors.ActiveCaptionText;
            labelPRODUCTNAME2.Location = new Point(12, 50);
            labelPRODUCTNAME2.Name = "labelPRODUCTNAME2";
            labelPRODUCTNAME2.Size = new Size(99, 21);
            labelPRODUCTNAME2.TabIndex = 2;
            labelPRODUCTNAME2.Text = "Product ID: ";
            // 
            // producttextbox
            // 
            producttextbox.Location = new Point(106, 52);
            producttextbox.Name = "producttextbox";
            producttextbox.Size = new Size(55, 23);
            producttextbox.TabIndex = 4;
            // 
            // labelSTOCK3
            // 
            labelSTOCK3.AutoSize = true;
            labelSTOCK3.BackColor = Color.Transparent;
            labelSTOCK3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSTOCK3.ForeColor = SystemColors.ActiveCaptionText;
            labelSTOCK3.Location = new Point(12, 339);
            labelSTOCK3.Name = "labelSTOCK3";
            labelSTOCK3.Size = new Size(61, 21);
            labelSTOCK3.TabIndex = 5;
            labelSTOCK3.Text = "Stock: ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(71, 337);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 29);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // buttonUPDATESTOCK1
            // 
            buttonUPDATESTOCK1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUPDATESTOCK1.ForeColor = SystemColors.ActiveCaptionText;
            buttonUPDATESTOCK1.Location = new Point(12, 374);
            buttonUPDATESTOCK1.Name = "buttonUPDATESTOCK1";
            buttonUPDATESTOCK1.Size = new Size(121, 32);
            buttonUPDATESTOCK1.TabIndex = 7;
            buttonUPDATESTOCK1.Text = "UPDATE STOCK";
            buttonUPDATESTOCK1.UseVisualStyleBackColor = true;
            buttonUPDATESTOCK1.Click += buttonUPDATESTOCK1_Click;
            // 
            // searchbtn1
            // 
            searchbtn1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbtn1.ForeColor = SystemColors.ActiveCaptionText;
            searchbtn1.Location = new Point(167, 49);
            searchbtn1.Name = "searchbtn1";
            searchbtn1.Size = new Size(100, 25);
            searchbtn1.TabIndex = 8;
            searchbtn1.Text = "SEARCH";
            searchbtn1.UseVisualStyleBackColor = true;
            searchbtn1.Click += searchbtn1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(657, 420);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 21);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recent Purchases";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(searchbtn1);
            Controls.Add(buttonUPDATESTOCK1);
            Controls.Add(numericUpDown1);
            Controls.Add(labelSTOCK3);
            Controls.Add(producttextbox);
            Controls.Add(labelPRODUCTNAME2);
            Controls.Add(dataGridViewPRODUCTLIST1);
            Controls.Add(ADMINLABEL1);
            ForeColor = SystemColors.Control;
            Name = "AdminPanel";
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPRODUCTLIST1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ADMINLABEL1;
        private DataGridView dataGridViewPRODUCTLIST1;
        private Label labelPRODUCTNAME2;
        private TextBox producttextbox;
        private Label labelSTOCK3;
        private NumericUpDown numericUpDown1;
        private Button buttonUPDATESTOCK1;
        private Button searchbtn1;
        private LinkLabel linkLabel1;
    }
}