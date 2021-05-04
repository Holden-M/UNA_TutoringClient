
namespace UNA_TutoringClient.Forms
{
    partial class FormLogin
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.iconKey = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPasswordUnderline = new System.Windows.Forms.Panel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvalidCredentials = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.picLoginLogo = new System.Windows.Forms.PictureBox();
            this.panelIgnore = new System.Windows.Forms.Panel();
            this.btnRegisterNow = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconKey)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(110, 162);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(110, 217);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 28);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.Indigo;
            this.iconUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.Gainsboro;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.Location = new System.Drawing.Point(72, 162);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(32, 32);
            this.iconUser.TabIndex = 1;
            this.iconUser.TabStop = false;
            // 
            // iconKey
            // 
            this.iconKey.BackColor = System.Drawing.Color.Indigo;
            this.iconKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconKey.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconKey.IconColor = System.Drawing.Color.Gainsboro;
            this.iconKey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconKey.Location = new System.Drawing.Point(72, 217);
            this.iconKey.Margin = new System.Windows.Forms.Padding(0);
            this.iconKey.Name = "iconKey";
            this.iconKey.Size = new System.Drawing.Size(32, 32);
            this.iconKey.TabIndex = 1;
            this.iconKey.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Location = new System.Drawing.Point(221, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 3);
            this.panel2.TabIndex = 2;
            // 
            // panelPasswordUnderline
            // 
            this.panelPasswordUnderline.BackColor = System.Drawing.Color.GhostWhite;
            this.panelPasswordUnderline.Location = new System.Drawing.Point(221, 242);
            this.panelPasswordUnderline.Name = "panelPasswordUnderline";
            this.panelPasswordUnderline.Size = new System.Drawing.Size(213, 3);
            this.panelPasswordUnderline.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Indigo;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(180, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(126, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.Color.Indigo;
            this.input_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_username.ForeColor = System.Drawing.Color.Gainsboro;
            this.input_username.Location = new System.Drawing.Point(236, 162);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(182, 22);
            this.input_username.TabIndex = 4;
            this.input_username.UseWaitCursor = true;
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.Color.Indigo;
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_password.ForeColor = System.Drawing.Color.Gainsboro;
            this.input_password.Location = new System.Drawing.Point(236, 214);
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '*';
            this.input_password.Size = new System.Drawing.Size(182, 22);
            this.input_password.TabIndex = 4;
            this.input_password.UseSystemPasswordChar = true;
            this.input_password.UseWaitCursor = true;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRegister.Location = new System.Drawing.Point(159, 383);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(171, 21);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Don\'t have an account?";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Indigo;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.picLoginLogo);
            this.panel.Controls.Add(this.panelIgnore);
            this.panel.Controls.Add(this.btnRegisterNow);
            this.panel.Controls.Add(this.lblRegister);
            this.panel.Controls.Add(this.input_password);
            this.panel.Controls.Add(this.input_username);
            this.panel.Controls.Add(this.btnLogin);
            this.panel.Controls.Add(this.panelPasswordUnderline);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.iconKey);
            this.panel.Controls.Add(this.iconUser);
            this.panel.Controls.Add(this.lblPassword);
            this.panel.Controls.Add(this.lblUsername);
            this.panel.Controls.Add(this.panelMain);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(7);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 500);
            this.panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lblInvalidCredentials);
            this.panel1.Location = new System.Drawing.Point(98, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 39);
            this.panel1.TabIndex = 11;
            // 
            // lblInvalidCredentials
            // 
            this.lblInvalidCredentials.AutoSize = true;
            this.lblInvalidCredentials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvalidCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInvalidCredentials.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvalidCredentials.ForeColor = System.Drawing.Color.Maroon;
            this.lblInvalidCredentials.Location = new System.Drawing.Point(0, 0);
            this.lblInvalidCredentials.Name = "lblInvalidCredentials";
            this.lblInvalidCredentials.Size = new System.Drawing.Size(0, 25);
            this.lblInvalidCredentials.TabIndex = 10;
            this.lblInvalidCredentials.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(479, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(21, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLoginLogo
            // 
            this.picLoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLoginLogo.Image = global::UNA_TutoringClient.Properties.Resources.UNA_Logo;
            this.picLoginLogo.Location = new System.Drawing.Point(166, 26);
            this.picLoginLogo.Name = "picLoginLogo";
            this.picLoginLogo.Size = new System.Drawing.Size(164, 97);
            this.picLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginLogo.TabIndex = 8;
            this.picLoginLogo.TabStop = false;
            // 
            // panelIgnore
            // 
            this.panelIgnore.BackColor = System.Drawing.Color.GhostWhite;
            this.panelIgnore.Location = new System.Drawing.Point(110, 367);
            this.panelIgnore.Name = "panelIgnore";
            this.panelIgnore.Size = new System.Drawing.Size(275, 2);
            this.panelIgnore.TabIndex = 7;
            // 
            // btnRegisterNow
            // 
            this.btnRegisterNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterNow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterNow.Location = new System.Drawing.Point(180, 416);
            this.btnRegisterNow.Name = "btnRegisterNow";
            this.btnRegisterNow.Size = new System.Drawing.Size(126, 32);
            this.btnRegisterNow.TabIndex = 6;
            this.btnRegisterNow.Text = "Register Now";
            this.btnRegisterNow.UseVisualStyleBackColor = true;
            this.btnRegisterNow.Click += new System.EventHandler(this.btnRegisterNow_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 500);
            this.panelMain.TabIndex = 12;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconKey)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconKey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnRegisterNow;
        private System.Windows.Forms.Panel panelIgnore;
        private System.Windows.Forms.PictureBox picLoginLogo;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblInvalidCredentials;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
    }
}