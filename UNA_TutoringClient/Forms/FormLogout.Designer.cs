
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
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.lblPromptLogout = new System.Windows.Forms.Label();
            this.panelLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogout
            // 
            this.panelLogout.AutoSize = true;
            this.panelLogout.BackColor = System.Drawing.Color.Indigo;
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Controls.Add(this.lblPromptLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogout.Location = new System.Drawing.Point(0, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(784, 461);
            this.panelLogout.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.DarkRed;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(315, 210);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(151, 49);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPromptLogout
            // 
            this.lblPromptLogout.AutoSize = true;
            this.lblPromptLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPromptLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPromptLogout.Location = new System.Drawing.Point(229, 167);
            this.lblPromptLogout.Name = "lblPromptLogout";
            this.lblPromptLogout.Size = new System.Drawing.Size(321, 30);
            this.lblPromptLogout.TabIndex = 1;
            this.lblPromptLogout.Text = "Are you sure you want to logout?";
            // 
            // FormLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
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
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Label lblPromptLogout;
    }
}