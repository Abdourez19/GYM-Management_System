using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymMS_Project1.Dashboard;
using GymMS_Project1.Global;
using GymMS_Project1.Login;
using GymMS_Project1.Members;
using GymMS_Project1.Packages;
using GymMS_Project1.Plans;
using GymMS_Project1.Trainers;
using GymMS_Project1.Users;

namespace GymMS_Project1
{
    public partial class frmMain : Form
    {

        private frmLogin _frm;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frm = frm;

        }


        bool _ExtendSideBar = false;
        private void _ExtendSidBar ()
        {
            if (_ExtendSideBar == false)
            {
                flpSideBar.Width -= 19;
                if (flpSideBar.Width == flpSideBar.MinimumSize.Width)
                {
                    _ExtendSideBar = true;
                    tmExtandSideBar.Stop();
                }
            }
            else
            {
                flpSideBar.Width += 19;
                if (flpSideBar.Width == flpSideBar.MaximumSize.Width)
                {
                    _ExtendSideBar = false;
                    tmExtandSideBar.Stop();
                }
            }
        }
        private void tmExtendSideBar_Tick(object sender, EventArgs e)
        {
            _ExtendSidBar();
        }
        private void pbMenuIcon_Click(object sender, EventArgs e)
        {
            tmExtandSideBar.Start();
        }


        //handling Menu Items Appearance 
        private void MenuButtons_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(44, 49, 70);
        }
        private void MenuButtons_OnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(13, 12, 44);

        }


        private bool _IsPermissionGranted(Button btn)
        {

            if (!((clsGlobal.CurrentUser.Permissions & Convert.ToInt32(btn.Tag)) == Convert.ToInt32(btn.Tag)))
            {

                MessageBox.Show("you don't have access authorization to this feature, Please contact the Admin", "Missed Permission",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }


            return true;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (_IsPermissionGranted(btnDashboard))
            {
                frmDashboard frm = new frmDashboard();
                frm.ShowDialog();
                
            }
        }
        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (_IsPermissionGranted(btnMembers))
            {
                var frmMembers = new frmMembersList();
                frmMembers.ShowDialog();
            }
        }
        private void btnPackages_Click(object sender, EventArgs e)
        {
            if (_IsPermissionGranted(btnPackages))
            {
                frmPackagesList frm = new frmPackagesList();
                frm.ShowDialog();
            }

        }
        private void btnPlans_Click(object sender, EventArgs e)
        {
            if (_IsPermissionGranted(btnPlans))
            {
                frmPlansList frm = new frmPlansList();
                frm.ShowDialog();
            }
        }
        private void btnTrainers_Click(object sender, EventArgs e)
        {

            if (_IsPermissionGranted(btnTrainers))
            {
                frmTrainersList frm = new frmTrainersList();
                frm.ShowDialog();
            }

        }
        private void btnUsers_Click(object sender, EventArgs e)
        {

            if (_IsPermissionGranted(btnUsers))
            {
                var frm = new frmUsersList();
                frm.ShowDialog();
            }
            
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frm.Show();
            this.Close();
        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(clsGlobal.CurrentUser);
            frm.ShowDialog();
        }
    }
}
