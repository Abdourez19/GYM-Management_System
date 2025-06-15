using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Business;

namespace GymMS_Project1.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private int _GetActiveMembersCount()
        {
            return clsMemberShip.GetActiveMembersCountNumber();
        }


        //take it to its class later clsPlans
        private int _GetMemberShipPlansCount ()
        {
            return clsPlan.GetPlansCountNumber();
            
        }

        private int _GetPackagesCountNumber()
        {
            return clsPackage.GetPackagesCountNumber();
        }



        private void _RefreshDashboardInfo()
        {
            int ActiveMembersCount, MemberShipPlansCount, PackagesCountNumber;

            ActiveMembersCount = _GetActiveMembersCount();
            MemberShipPlansCount = _GetMemberShipPlansCount();
            PackagesCountNumber = _GetPackagesCountNumber();

            lblActiveMembers.Text = ActiveMembersCount.ToString();
            lblTotalMembershipPlans.Text = MemberShipPlansCount.ToString();
            lblTotalPackages.Text = PackagesCountNumber.ToString();

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _RefreshDashboardInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
