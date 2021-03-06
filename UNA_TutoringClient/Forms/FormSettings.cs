using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNA_TutoringClient.Forms
{
    public partial class FormSettings : Form
    {
        private Form currentChildForm;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSelfServicePasswordReset());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(childForm);
            panelDisplay.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
