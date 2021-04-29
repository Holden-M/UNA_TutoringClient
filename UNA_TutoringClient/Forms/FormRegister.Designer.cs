
namespace UNA_TutoringClient.Forms
{
    partial class FormRegister
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.txtRegister_Password = new System.Windows.Forms.TextBox();
            this.txtRegister_RePassword = new System.Windows.Forms.TextBox();
            this.txtRegister_Email = new System.Windows.Forms.TextBox();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRetype_Password = new System.Windows.Forms.Label();
            this.lblRegister_Password = new System.Windows.Forms.Label();
            this.lblRegister_Email = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Indigo;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.btnBack);
            this.panelMain.Controls.Add(this.txtRegister_Password);
            this.panelMain.Controls.Add(this.txtRegister_RePassword);
            this.panelMain.Controls.Add(this.txtRegister_Email);
            this.panelMain.Controls.Add(this.btnRegister);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.lblRetype_Password);
            this.panelMain.Controls.Add(this.lblRegister_Password);
            this.panelMain.Controls.Add(this.lblRegister_Email);
            this.panelMain.Controls.Add(this.lblRegister);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 500);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 25;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 29);
            this.btnBack.TabIndex = 5;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRegister_Password
            // 
            this.txtRegister_Password.BackColor = System.Drawing.Color.Indigo;
            this.txtRegister_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegister_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegister_Password.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRegister_Password.Location = new System.Drawing.Point(196, 240);
            this.txtRegister_Password.Name = "txtRegister_Password";
            this.txtRegister_Password.PasswordChar = '*';
            this.txtRegister_Password.Size = new System.Drawing.Size(265, 22);
            this.txtRegister_Password.TabIndex = 4;
            this.txtRegister_Password.UseSystemPasswordChar = true;
            // 
            // txtRegister_RePassword
            // 
            this.txtRegister_RePassword.BackColor = System.Drawing.Color.Indigo;
            this.txtRegister_RePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegister_RePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegister_RePassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRegister_RePassword.Location = new System.Drawing.Point(196, 294);
            this.txtRegister_RePassword.Name = "txtRegister_RePassword";
            this.txtRegister_RePassword.PasswordChar = '*';
            this.txtRegister_RePassword.Size = new System.Drawing.Size(265, 22);
            this.txtRegister_RePassword.TabIndex = 4;
            this.txtRegister_RePassword.UseSystemPasswordChar = true;
            // 
            // txtRegister_Email
            // 
            this.txtRegister_Email.BackColor = System.Drawing.Color.Indigo;
            this.txtRegister_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegister_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegister_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegister_Email.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRegister_Email.Location = new System.Drawing.Point(196, 173);
            this.txtRegister_Email.Name = "txtRegister_Email";
            this.txtRegister_Email.Size = new System.Drawing.Size(265, 22);
            this.txtRegister_Email.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnRegister.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegister.Location = new System.Drawing.Point(151, 349);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(166, 55);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(216, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Email must be a valid una.edu address)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(196, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 2);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(196, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 2);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(196, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 2);
            this.panel2.TabIndex = 1;
            // 
            // lblRetype_Password
            // 
            this.lblRetype_Password.AutoSize = true;
            this.lblRetype_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRetype_Password.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRetype_Password.Location = new System.Drawing.Point(14, 294);
            this.lblRetype_Password.Name = "lblRetype_Password";
            this.lblRetype_Password.Size = new System.Drawing.Size(176, 25);
            this.lblRetype_Password.TabIndex = 0;
            this.lblRetype_Password.Text = "Re-type Password:";
            // 
            // lblRegister_Password
            // 
            this.lblRegister_Password.AutoSize = true;
            this.lblRegister_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegister_Password.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRegister_Password.Location = new System.Drawing.Point(88, 240);
            this.lblRegister_Password.Name = "lblRegister_Password";
            this.lblRegister_Password.Size = new System.Drawing.Size(102, 25);
            this.lblRegister_Password.TabIndex = 0;
            this.lblRegister_Password.Text = "Password:";
            // 
            // lblRegister_Email
            // 
            this.lblRegister_Email.AutoSize = true;
            this.lblRegister_Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegister_Email.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRegister_Email.Location = new System.Drawing.Point(126, 173);
            this.lblRegister_Email.Name = "lblRegister_Email";
            this.lblRegister_Email.Size = new System.Drawing.Size(64, 25);
            this.lblRegister_Email.TabIndex = 0;
            this.lblRegister_Email.Text = "Email:";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRegister.Location = new System.Drawing.Point(68, 78);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(351, 45);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Register New Account";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.TextBox txtRegister_Password;
        private System.Windows.Forms.TextBox txtRegister_RePassword;
        private System.Windows.Forms.TextBox txtRegister_Email;
        private FontAwesome.Sharp.IconButton btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRetype_Password;
        private System.Windows.Forms.Label lblRegister_Password;
        private System.Windows.Forms.Label lblRegister_Email;
        private System.Windows.Forms.Label lblRegister;
    }
}