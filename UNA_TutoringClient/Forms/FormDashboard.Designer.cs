
namespace UNA_TutoringClient
{
    partial class FormDashboard
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
            this.lblUpcomingAppointments = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblUpcomingAppointments
            // 
            this.lblUpcomingAppointments.AutoSize = true;
            this.lblUpcomingAppointments.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpcomingAppointments.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUpcomingAppointments.Location = new System.Drawing.Point(12, 9);
            this.lblUpcomingAppointments.Name = "lblUpcomingAppointments";
            this.lblUpcomingAppointments.Size = new System.Drawing.Size(294, 32);
            this.lblUpcomingAppointments.TabIndex = 0;
            this.lblUpcomingAppointments.Text = "Upcoming appointments...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 2);
            this.panel1.TabIndex = 1;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUpcomingAppointments);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpcomingAppointments;
        private System.Windows.Forms.Panel panel1;
    }
}