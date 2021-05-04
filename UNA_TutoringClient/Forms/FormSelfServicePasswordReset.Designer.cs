
namespace UNA_TutoringClient.Forms
{
    partial class FormSelfServicePasswordReset
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
            this.panelSelfService = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.txtReTypeNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelIgnore = new System.Windows.Forms.Panel();
            this.lblReTypeNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.labelSelfServicePasswordReset = new System.Windows.Forms.Label();
            this.panelSelfService.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelfService
            // 
            this.panelSelfService.BackColor = System.Drawing.Color.Indigo;
            this.panelSelfService.Controls.Add(this.btnBack);
            this.panelSelfService.Controls.Add(this.txtReTypeNewPassword);
            this.panelSelfService.Controls.Add(this.txtNewPassword);
            this.panelSelfService.Controls.Add(this.txtCurrentPassword);
            this.panelSelfService.Controls.Add(this.btnResetPassword);
            this.panelSelfService.Controls.Add(this.panel2);
            this.panelSelfService.Controls.Add(this.panel1);
            this.panelSelfService.Controls.Add(this.panelIgnore);
            this.panelSelfService.Controls.Add(this.lblReTypeNewPassword);
            this.panelSelfService.Controls.Add(this.lblNewPassword);
            this.panelSelfService.Controls.Add(this.lblCurrentPassword);
            this.panelSelfService.Controls.Add(this.labelSelfServicePasswordReset);
            this.panelSelfService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelfService.Location = new System.Drawing.Point(0, 0);
            this.panelSelfService.Name = "panelSelfService";
            this.panelSelfService.Size = new System.Drawing.Size(484, 461);
            this.panelSelfService.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 28;
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 38);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtReTypeNewPassword
            // 
            this.txtReTypeNewPassword.BackColor = System.Drawing.Color.Indigo;
            this.txtReTypeNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReTypeNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReTypeNewPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtReTypeNewPassword.Location = new System.Drawing.Point(182, 189);
            this.txtReTypeNewPassword.Name = "txtReTypeNewPassword";
            this.txtReTypeNewPassword.PasswordChar = '*';
            this.txtReTypeNewPassword.Size = new System.Drawing.Size(236, 22);
            this.txtReTypeNewPassword.TabIndex = 4;
            this.txtReTypeNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Indigo;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNewPassword.Location = new System.Drawing.Point(182, 142);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(236, 22);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.Indigo;
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCurrentPassword.Location = new System.Drawing.Point(183, 106);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(236, 22);
            this.txtCurrentPassword.TabIndex = 4;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResetPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnResetPassword.IconColor = System.Drawing.Color.Black;
            this.btnResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetPassword.Location = new System.Drawing.Point(144, 251);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(174, 41);
            this.btnResetPassword.TabIndex = 3;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(182, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 2);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(182, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 2);
            this.panel1.TabIndex = 2;
            // 
            // panelIgnore
            // 
            this.panelIgnore.BackColor = System.Drawing.Color.Gainsboro;
            this.panelIgnore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelIgnore.Location = new System.Drawing.Point(182, 128);
            this.panelIgnore.Name = "panelIgnore";
            this.panelIgnore.Size = new System.Drawing.Size(237, 2);
            this.panelIgnore.TabIndex = 2;
            // 
            // lblReTypeNewPassword
            // 
            this.lblReTypeNewPassword.AutoSize = true;
            this.lblReTypeNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReTypeNewPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReTypeNewPassword.Location = new System.Drawing.Point(3, 198);
            this.lblReTypeNewPassword.Name = "lblReTypeNewPassword";
            this.lblReTypeNewPassword.Size = new System.Drawing.Size(173, 21);
            this.lblReTypeNewPassword.TabIndex = 1;
            this.lblReTypeNewPassword.Text = "Re-type New Password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNewPassword.Location = new System.Drawing.Point(61, 151);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(115, 21);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentPassword.Location = new System.Drawing.Point(40, 109);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(136, 21);
            this.lblCurrentPassword.TabIndex = 1;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // labelSelfServicePasswordReset
            // 
            this.labelSelfServicePasswordReset.AutoSize = true;
            this.labelSelfServicePasswordReset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSelfServicePasswordReset.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSelfServicePasswordReset.Location = new System.Drawing.Point(112, 52);
            this.labelSelfServicePasswordReset.Name = "labelSelfServicePasswordReset";
            this.labelSelfServicePasswordReset.Size = new System.Drawing.Size(256, 25);
            this.labelSelfServicePasswordReset.TabIndex = 0;
            this.labelSelfServicePasswordReset.Text = "Self Service Password Reset";
            // 
            // FormSelfServicePasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelSelfService);
            this.Name = "FormSelfServicePasswordReset";
            this.Text = "FormSelfServicePasswordReset";
            this.panelSelfService.ResumeLayout(false);
            this.panelSelfService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSelfService;
        private FontAwesome.Sharp.IconButton btnResetPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelIgnore;
        private System.Windows.Forms.Label lblReTypeNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label labelSelfServicePasswordReset;
        private System.Windows.Forms.TextBox txtReTypeNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}