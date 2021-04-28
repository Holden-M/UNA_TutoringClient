
namespace UNA_TutoringClient.Forms
{
    partial class FormSearch
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblPrompt_Search = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.lblSearch_Results = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(55)))), ((int)(((byte)(192)))));
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.panel1);
            this.panelSearch.Controls.Add(this.txtClass);
            this.panelSearch.Controls.Add(this.lblPrompt_Search);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(800, 75);
            this.panelSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(55)))), ((int)(((byte)(192)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 35;
            this.btnSearch.Location = new System.Drawing.Point(578, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 43);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(269, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 2);
            this.panel1.TabIndex = 2;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(55)))), ((int)(((byte)(192)))));
            this.txtClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClass.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtClass.Location = new System.Drawing.Point(269, 22);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(255, 32);
            this.txtClass.TabIndex = 1;
            this.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrompt_Search
            // 
            this.lblPrompt_Search.AutoSize = true;
            this.lblPrompt_Search.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrompt_Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrompt_Search.Location = new System.Drawing.Point(67, 21);
            this.lblPrompt_Search.Name = "lblPrompt_Search";
            this.lblPrompt_Search.Size = new System.Drawing.Size(167, 37);
            this.lblPrompt_Search.TabIndex = 0;
            this.lblPrompt_Search.Text = "Enter a class:";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.Indigo;
            this.panelBody.Controls.Add(this.lblSearch_Results);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 75);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 375);
            this.panelBody.TabIndex = 1;
            // 
            // lblSearch_Results
            // 
            this.lblSearch_Results.AutoSize = true;
            this.lblSearch_Results.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearch_Results.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSearch_Results.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSearch_Results.Location = new System.Drawing.Point(0, 0);
            this.lblSearch_Results.Name = "lblSearch_Results";
            this.lblSearch_Results.Size = new System.Drawing.Size(0, 30);
            this.lblSearch_Results.TabIndex = 0;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearch";
            this.Text = "Search for appointments";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblPrompt_Search;
        private System.Windows.Forms.Panel panelBody;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label lblSearch_Results;
    }
}