namespace Bits_N_Bytes
{
    partial class signup
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            linkLabel1 = new LinkLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            PASSWORD = new Guna.UI2.WinForms.Guna2TextBox();
            USERNAME = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(571, 410);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Have an account? Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(723, 399);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(77, 36);
            materialButton1.TabIndex = 10;
            materialButton1.Text = "Sign up";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // PASSWORD
            // 
            PASSWORD.CustomizableEdges = customizableEdges1;
            PASSWORD.DefaultText = "";
            PASSWORD.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PASSWORD.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PASSWORD.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PASSWORD.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PASSWORD.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PASSWORD.Font = new Font("Segoe UI", 9F);
            PASSWORD.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PASSWORD.Location = new Point(188, 189);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.PlaceholderText = "";
            PASSWORD.SelectedText = "";
            PASSWORD.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PASSWORD.Size = new Size(315, 25);
            PASSWORD.TabIndex = 9;
            // 
            // USERNAME
            // 
            USERNAME.CustomizableEdges = customizableEdges3;
            USERNAME.DefaultText = "";
            USERNAME.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            USERNAME.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            USERNAME.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            USERNAME.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            USERNAME.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            USERNAME.Font = new Font("Segoe UI", 9F);
            USERNAME.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            USERNAME.Location = new Point(188, 135);
            USERNAME.Name = "USERNAME";
            USERNAME.PlaceholderText = "";
            USERNAME.SelectedText = "";
            USERNAME.ShadowDecoration.CustomizableEdges = customizableEdges4;
            USERNAME.Size = new Size(315, 25);
            USERNAME.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 189);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 7;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 135);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 6;
            label1.Text = "Username :";
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(materialButton1);
            Controls.Add(PASSWORD);
            Controls.Add(USERNAME);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signup";
            Text = "signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Guna.UI2.WinForms.Guna2TextBox PASSWORD;
        private Guna.UI2.WinForms.Guna2TextBox USERNAME;
        private Label label2;
        private Label label1;
    }
}