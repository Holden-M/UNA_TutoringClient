
namespace UNA_TutoringClient.Forms
{
    partial class FormSettings
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
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnResetPassword = new FontAwesome.Sharp.IconButton();
            this.panelMain.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Indigo;
            this.panelMain.Controls.Add(this.panelDisplay);
            this.panelMain.Controls.Add(this.panelSettings);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 450);
            this.panelMain.TabIndex = 0;
            // 
            // panelDisplay
            // 
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(200, 0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(600, 450);
            this.panelDisplay.TabIndex = 1;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.btnResetPassword);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(200, 450);
            this.panelSettings.TabIndex = 0;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResetPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnResetPassword.IconColor = System.Drawing.Color.Black;
            this.btnResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetPassword.Location = new System.Drawing.Point(28, 12);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(146, 29);
            this.btnResetPassword.TabIndex = 0;
            this.btnResetPassword.Text = "Password Reset";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.panelMain.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel panelSettings;
        private FontAwesome.Sharp.IconButton btnResetPassword;
    }
}