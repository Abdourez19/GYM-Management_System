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

namespace GymMS_Project1.Users
{
    public partial class frmUserDetails : Form
    {

        private int _UserID;
        private clsUser _User;


        public frmUserDetails(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _User = clsUser.Find(UserID);
        }
        private void _SetPermissionsLevel ()
        {
            if (_User.Permissions == -1 || _User.Permissions == 63)
                txtPermissionsLevel.Text = "Full";

            else if (_User.Permissions == 3)
                txtPermissionsLevel.Text = "Basic";

            else
                txtPermissionsLevel.Text = "Customized";
        }
        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            txtUserID.Text = _UserID.ToString();
            txtUsername.Text = _User.Username;
            _SetPermissionsLevel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
