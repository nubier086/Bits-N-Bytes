namespace Bits_N_Bytes
{
    partial class recent
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
            dgvRecent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            SuspendLayout();
            // 
            // dgvRecent
            // 
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecent.Location = new Point(12, 12);
            dgvRecent.Name = "dgvRecent";
            dgvRecent.ReadOnly = true;
            dgvRecent.Size = new Size(776, 426);
            dgvRecent.TabIndex = 0;
            // 
            // recent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRecent);
            Name = "recent";
            Text = "recent";
            Load += recent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRecent;
    }
}