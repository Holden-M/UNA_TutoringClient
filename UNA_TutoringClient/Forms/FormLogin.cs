using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNA_TutoringClient.Forms
{
    public partial class FormLogin : Form
    {


        private bool auth = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblInvalidCredentials.Text = "";
            string username = input_username.Text;
            string password = input_password.Text;

            string tmpUsername = "root";
            string tmpPassword = "password";

            if (username == "" || password == "")
            {
                lblInvalidCredentials.Text = "Empty username or password fields.";
                this.input_username.Text = "";
                this.input_password.Text = "";
            }
            else if (!(username == tmpUsername && password == tmpPassword))
            {
                lblInvalidCredentials.Text = "Invalid username or password.";
                this.input_username.Text = "";
                this.input_password.Text = "";
            }
            else if (username == tmpUsername && password == tmpPassword)
            {
                auth = true;
                this.Close();
            }
        }

        public bool valid_user()
        {
            return auth;
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
