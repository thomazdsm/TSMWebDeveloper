namespace TSM.AppUI.Forms.User
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.registerButton = new MaterialSkin.Controls.MaterialButton();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.mailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "CREATE A NEW ACCOUNT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 460);
            this.panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(76, 436);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account? Login!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = false;
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerButton.Depth = 0;
            this.registerButton.HighEmphasis = true;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(93, 361);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerButton.Size = new System.Drawing.Size(150, 36);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "CREATE ACCOUNT";
            this.registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerButton.UseAccentColor = false;
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.Hint = "Password";
            this.passwordTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.LeadingIcon")));
            this.passwordTextBox.LeaveOnEnterKey = true;
            this.passwordTextBox.Location = new System.Drawing.Point(32, 265);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Password = true;
            this.passwordTextBox.Size = new System.Drawing.Size(279, 50);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.TrailingIcon = null;
            // 
            // mailTextBox
            // 
            this.mailTextBox.AnimateReadOnly = false;
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTextBox.Depth = 0;
            this.mailTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mailTextBox.Hint = "Email";
            this.mailTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("mailTextBox.LeadingIcon")));
            this.mailTextBox.Location = new System.Drawing.Point(32, 209);
            this.mailTextBox.MaxLength = 50;
            this.mailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.mailTextBox.Multiline = false;
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(279, 50);
            this.mailTextBox.TabIndex = 1;
            this.mailTextBox.Text = "";
            this.mailTextBox.TrailingIcon = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.Hint = "Full Name";
            this.nameTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("nameTextBox.LeadingIcon")));
            this.nameTextBox.Location = new System.Drawing.Point(32, 153);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(279, 50);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialTextBox mailTextBox;
        private MaterialSkin.Controls.MaterialTextBox nameTextBox;
        private LinkLabel linkLabel1;
    }
}