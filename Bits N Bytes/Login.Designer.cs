using Bits_N_Bytes.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bits_N_Bytes
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            USERNAME = new Guna.UI2.WinForms.Guna2TextBox();
            PASSWORD = new Guna.UI2.WinForms.Guna2TextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 138);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 192);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            label2.Click += label2_Click;
            // 
            // USERNAME
            // 
            USERNAME.CustomizableEdges = customizableEdges1;
            USERNAME.DefaultText = "";
            USERNAME.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            USERNAME.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            USERNAME.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            USERNAME.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            USERNAME.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            USERNAME.Font = new Font("Segoe UI", 9F);
            USERNAME.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            USERNAME.Location = new Point(162, 138);
            USERNAME.Name = "USERNAME";
            USERNAME.PlaceholderText = "";
            USERNAME.SelectedText = "";
            USERNAME.ShadowDecoration.CustomizableEdges = customizableEdges2;
            USERNAME.Size = new Size(315, 25);
            USERNAME.TabIndex = 2;
            USERNAME.TextChanged += USERNAME_TextChanged;
            // 
            // PASSWORD
            // 
            PASSWORD.CustomizableEdges = customizableEdges3;
            PASSWORD.DefaultText = "";
            PASSWORD.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PASSWORD.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PASSWORD.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PASSWORD.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PASSWORD.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PASSWORD.Font = new Font("Segoe UI", 9F);
            PASSWORD.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PASSWORD.Location = new Point(162, 192);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.PlaceholderText = "";
            PASSWORD.SelectedText = "";
            PASSWORD.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PASSWORD.Size = new Size(315, 25);
            PASSWORD.TabIndex = 3;
            PASSWORD.TextChanged += PASSWORD_TextChanged;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(629, 338);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "Login";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(448, 349);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(167, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Dont have an account? Sign in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(718, 402);
            Controls.Add(linkLabel1);
            Controls.Add(materialButton1);
            Controls.Add(PASSWORD);
            Controls.Add(USERNAME);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the signup form when user clicks the link
            signup Signup = new signup();
            Signup.Show();
            this.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string role = DatabaseHelper.LoginUser(USERNAME.Text, PASSWORD.Text);

            if (role == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            if (role == "Admin")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
            }
            else
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
        }

        private void PASSWORD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void USERNAME_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox USERNAME;
        private Guna.UI2.WinForms.Guna2TextBox PASSWORD;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private LinkLabel linkLabel1;
    }
}