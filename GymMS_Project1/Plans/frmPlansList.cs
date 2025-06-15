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

namespace GymMS_Project1.Plans
{
    public partial class frmPlansList : Form
    {
        public frmPlansList()
        {
            InitializeComponent();
        }


        private static DataTable _PlansList = clsPlan.GetPlansList();

        private DataTable _AllPlansList = _PlansList.DefaultView.ToTable(false, "PlanID", "PlanDuration",
                                                            "PlanDescription", "AdditionalNotes");


        private void _RefreshPlansList()
        {
            _PlansList = clsPlan.GetPlansList();
            _AllPlansList = _PlansList.DefaultView.ToTable(false, "PlanID", "PlanDuration",
                                                            "PlanDescription", "AdditionalNotes");

            dgvPlansList.DataSource = _AllPlansList;
            lblTotalPlans.Text = dgvPlansList.RowCount.ToString();

        }
        private void frmPlansList_Load(object sender, EventArgs e)
        {
            _RefreshPlansList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
