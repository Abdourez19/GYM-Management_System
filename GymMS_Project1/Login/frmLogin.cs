using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Business;
using GymMS_Project1.Global;

namespace GymMS_Project1.Login
{
    public partial class frmLogin : Form
    {
        private clsUser _User;
        public frmLogin()
        {
            InitializeComponent();
        }


        private bool _IsUserFound(string Username, string Password)
        {
            _User = clsUser.Find(Username, Password);
            if (_User == null)
            {
                lblIncorrectCredentials.Visible = true;
                return false;
            }

            clsGlobal.CurrentUser = _User;
            lblIncorrectCredentials.Visible = false;
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            if (string.IsNullOrEmpty(temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "Field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbRememberMe.Checked)
            {
                clsGlobal.SaveCredentialsToRegistry(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            }
            else
                clsGlobal.DeleteCredentialsFromRegistry();




            if (_IsUserFound(txtUsername.Text, txtPassword.Text))
            {
                frmMain frm = new frmMain(this);
                frm.Show();
                this.Hide();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblIncorrectCredentials.Visible = false;
            string username = "", password = "";

            if (clsGlobal.GetStoredCredentialFromRegistry(ref username, ref password))
            {
                txtUsername.Text = username;
                txtPassword.Text = password;
                cbRememberMe.Checked = true;
            }
            else
                cbRememberMe.Checked = false;
        }
    }
}
