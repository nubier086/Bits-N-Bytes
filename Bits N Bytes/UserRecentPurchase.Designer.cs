namespace Bits_N_Bytes
{
    partial class UserRecentPurchase
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
            dataGridViewURP1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewURP1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewURP1
            // 
            dataGridViewURP1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewURP1.Location = new Point(12, 12);
            dataGridViewURP1.Name = "dataGridViewURP1";
            dataGridViewURP1.Size = new Size(776, 426);
            dataGridViewURP1.TabIndex = 0;
            // 
            // UserRecentPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewURP1);
            Name = "UserRecentPurchase";
            Text = "UserRecentPurchase";
            ((System.ComponentModel.ISupportInitialize)dataGridViewURP1).EndInit();
            ResumeLayout(false);
            Load += UserRecentPurchase_Load;
        }

        #endregion

        private DataGridView dataGridViewURP1;
    }
}