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

namespace GymMS_Project1.Members
{
    public partial class frmMemberDetails : Form
    {
        private clsMemberShip _Member;
        public frmMemberDetails(clsMemberShip member)
        {
            InitializeComponent();
            _Member = member;
            lblNoTrainoerSelected.Hide();
        }


        private void _FillPackageInfo (int PackageID)
        {
            clsPackage package = clsPackage.FindPackageByID(PackageID);

            if (package == null)
            {
                MessageBox.Show("No Package Attached with this Person!", "Warning", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                return;
            }

            txtPackageID.Text = package.PackageID.ToString();
            txtPackageName.Text = package.PackageName;
            txtPackageDescription.Text = package.PackageDescription;
        }
        private void _FillPlanInfo (int PlanID)
        {
            clsPlan plan = clsPlan.FindPlanInfoByID(PlanID);

            if (plan == null)
            {
                MessageBox.Show("No Plan Attached with this Person!", "Warning", MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                return;
            }

            txtPlanID.Text = plan.PlanID.ToString();
            txtPlanDuration.Text = plan.PlanDuration.ToString();
            txtPlanDescription.Text = plan.PlanDescription;
            if (plan.AdditionalNotes == "")
            {
                txtAdditionalNotes.Text = "No Additional info";
                txtAdditionalNotes.TextAlign = HorizontalAlignment.Center;
            }
                
            else
                txtAdditionalNotes.Text = plan.AdditionalNotes;
        }
        private void _FillTrainerInfo (int TrainerID)
        {
            clsTrainer trainer = clsTrainer.FindByID(TrainerID);

            if (trainer == null)
            {
                lblNoTrainoerSelected.Show();
                pnlTrainer.Enabled = false;
                return;
            }

            txtTrainerID.Text = trainer.TrainerID.ToString();
            txtTrainerName.Text = trainer.Person.FirstName + " " + trainer.Person.MiddleName 
                + " " + trainer.Person.LastName;
            txtSpecialty.Text = trainer.Specialty;

        }
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {

            crtlPersonCard2.LoadPersonInfo(_Member.PersonID);
            _FillPackageInfo(_Member.PackageID);
            _FillPlanInfo(_Member.PlanID);
            _FillTrainerInfo(_Member.TrainerID);

        }




        private void btnNext_Click(object sender, EventArgs e)
        {
            tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpMembershipInfo"];
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpPersonInfo"];
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _Member = null;
            this.Close();
        }

       
    }
}
