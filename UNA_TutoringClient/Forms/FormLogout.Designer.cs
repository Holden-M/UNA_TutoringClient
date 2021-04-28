
namespace UNA_TutoringClient.Forms
{
    partial class FormLogout
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
            this.panelLogout = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblPromptLogout = new System.Windows.Forms.Label();
            this.panelLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogout
            // 
            this.panelLogout.AutoSize = true;
            this.panelLogout.BackColor = System.Drawing.Color.Indigo;
            this.panelLogout.Controls.Add(this.iconButton1);
            this.panelLogout.Controls.Add(this.lblPromptLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogout.Location = new System.Drawing.Point(0, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(721, 365);
            this.panelLogout.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(276, 148);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(151, 49);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "LOGOUT";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblPromptLogout
            // 
            this.lblPromptLogout.AutoSize = true;
            this.lblPromptLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPromptLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPromptLogout.Location = new System.Drawing.Point(190, 105);
            this.lblPromptLogout.Name = "lblPromptLogout";
            this.lblPromptLogout.Size = new System.Drawing.Size(321, 30);
            this.lblPromptLogout.TabIndex = 1;
            this.lblPromptLogout.Text = "Are you sure you want to logout?";
            // 
            // FormLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 365);
            this.Controls.Add(this.panelLogout);
            this.Name = "FormLogout";
            this.Text = "Logout";
            this.panelLogout.ResumeLayout(false);
            this.panelLogout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogout;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblPromptLogout;
    }
}