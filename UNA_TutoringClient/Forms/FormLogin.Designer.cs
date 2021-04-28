
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
            this.panelUsernameUnderline = new System.Windows.Forms.Panel();
            this.panelIgnore = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconKey)).BeginInit();
            this.panelUsernameUnderline.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(227, 135);
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
            this.lblPassword.Location = new System.Drawing.Point(227, 190);
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
            this.iconUser.Location = new System.Drawing.Point(189, 135);
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
            this.iconKey.Location = new System.Drawing.Point(189, 190);
            this.iconKey.Margin = new System.Windows.Forms.Padding(0);
            this.iconKey.Name = "iconKey";
            this.iconKey.Size = new System.Drawing.Size(32, 32);
            this.iconKey.TabIndex = 1;
            this.iconKey.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Location = new System.Drawing.Point(338, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 3);
            this.panel2.TabIndex = 2;
            // 
            // panelPasswordUnderline
            // 
            this.panelPasswordUnderline.BackColor = System.Drawing.Color.GhostWhite;
            this.panelPasswordUnderline.Location = new System.Drawing.Point(338, 215);
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
            this.btnLogin.Location = new System.Drawing.Point(307, 242);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(126, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.Color.Indigo;
            this.input_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_username.ForeColor = System.Drawing.Color.Gainsboro;
            this.input_username.Location = new System.Drawing.Point(353, 135);
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
            this.input_password.Location = new System.Drawing.Point(353, 187);
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
            this.lblRegister.Location = new System.Drawing.Point(286, 334);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(171, 21);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Don\'t have an account?";
            // 
            // panelUsernameUnderline
            // 
            this.panelUsernameUnderline.BackColor = System.Drawing.Color.Indigo;
            this.panelUsernameUnderline.Controls.Add(this.panelIgnore);
            this.panelUsernameUnderline.Controls.Add(this.button1);
            this.panelUsernameUnderline.Controls.Add(this.lblRegister);
            this.panelUsernameUnderline.Controls.Add(this.input_password);
            this.panelUsernameUnderline.Controls.Add(this.input_username);
            this.panelUsernameUnderline.Controls.Add(this.btnLogin);
            this.panelUsernameUnderline.Controls.Add(this.panelPasswordUnderline);
            this.panelUsernameUnderline.Controls.Add(this.panel2);
            this.panelUsernameUnderline.Controls.Add(this.iconKey);
            this.panelUsernameUnderline.Controls.Add(this.iconUser);
            this.panelUsernameUnderline.Controls.Add(this.lblPassword);
            this.panelUsernameUnderline.Controls.Add(this.lblUsername);
            this.panelUsernameUnderline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsernameUnderline.Location = new System.Drawing.Point(0, 0);
            this.panelUsernameUnderline.Name = "panelUsernameUnderline";
            this.panelUsernameUnderline.Size = new System.Drawing.Size(800, 450);
            this.panelUsernameUnderline.TabIndex = 0;
            // 
            // panelIgnore
            // 
            this.panelIgnore.BackColor = System.Drawing.Color.GhostWhite;
            this.panelIgnore.Location = new System.Drawing.Point(237, 318);
            this.panelIgnore.Name = "panelIgnore";
            this.panelIgnore.Size = new System.Drawing.Size(275, 2);
            this.panelIgnore.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(307, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Register Now";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelUsernameUnderline);
            this.Name = "FormLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconKey)).EndInit();
            this.panelUsernameUnderline.ResumeLayout(false);
            this.panelUsernameUnderline.PerformLayout();
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
        private System.Windows.Forms.Panel panelUsernameUnderline;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelIgnore;
    }
}