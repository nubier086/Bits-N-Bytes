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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            ADMINLABEL1 = new Label();
            dataGridViewPRODUCTLIST1 = new DataGridView();
            labelPRODUCTNAME2 = new Label();
            producttextbox = new TextBox();
            labelSTOCK3 = new Label();
            numericUpDown1 = new NumericUpDown();
            buttonUPDATESTOCK1 = new Button();
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
            ADMINLABEL1.Location = new Point(330, 9);
            ADMINLABEL1.Name = "ADMINLABEL1";
            ADMINLABEL1.Size = new Size(120, 21);
            ADMINLABEL1.TabIndex = 0;
            ADMINLABEL1.Text = "ADMIN PANEL";
            ADMINLABEL1.Click += ADMINLABEL1_Click;
            // 
            // dataGridViewPRODUCTLIST1
            // 
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewPRODUCTLIST1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewPRODUCTLIST1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewPRODUCTLIST1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewPRODUCTLIST1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewPRODUCTLIST1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewPRODUCTLIST1.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewPRODUCTLIST1.Location = new Point(12, 45);
            dataGridViewPRODUCTLIST1.Name = "dataGridViewPRODUCTLIST1";
            dataGridViewPRODUCTLIST1.Size = new Size(776, 296);
            dataGridViewPRODUCTLIST1.TabIndex = 1;
            // 
            // labelPRODUCTNAME2
            // 
            labelPRODUCTNAME2.AutoSize = true;
            labelPRODUCTNAME2.BackColor = Color.Transparent;
            labelPRODUCTNAME2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPRODUCTNAME2.ForeColor = SystemColors.ActiveCaptionText;
            labelPRODUCTNAME2.Location = new Point(12, 354);
            labelPRODUCTNAME2.Name = "labelPRODUCTNAME2";
            labelPRODUCTNAME2.Size = new Size(128, 21);
            labelPRODUCTNAME2.TabIndex = 2;
            labelPRODUCTNAME2.Text = "Product Name: ";
            // 
            // producttextbox
            // 
            producttextbox.Location = new Point(136, 354);
            producttextbox.Name = "producttextbox";
            producttextbox.Size = new Size(225, 23);
            producttextbox.TabIndex = 4;
            // 
            // labelSTOCK3
            // 
            labelSTOCK3.AutoSize = true;
            labelSTOCK3.BackColor = Color.Transparent;
            labelSTOCK3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSTOCK3.ForeColor = SystemColors.ActiveCaptionText;
            labelSTOCK3.Location = new Point(12, 391);
            labelSTOCK3.Name = "labelSTOCK3";
            labelSTOCK3.Size = new Size(61, 21);
            labelSTOCK3.TabIndex = 5;
            labelSTOCK3.Text = "Stock: ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(78, 391);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 29);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // buttonUPDATESTOCK1
            // 
            buttonUPDATESTOCK1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUPDATESTOCK1.ForeColor = SystemColors.ActiveCaptionText;
            buttonUPDATESTOCK1.Location = new Point(146, 389);
            buttonUPDATESTOCK1.Name = "buttonUPDATESTOCK1";
            buttonUPDATESTOCK1.Size = new Size(121, 32);
            buttonUPDATESTOCK1.TabIndex = 7;
            buttonUPDATESTOCK1.Text = "UPDATE STOCK";
            buttonUPDATESTOCK1.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
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
    }
}