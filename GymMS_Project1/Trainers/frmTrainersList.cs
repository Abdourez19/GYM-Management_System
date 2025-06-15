using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Business;
using GymMS_Project1.Members;
using GymMS_Project1.Plans;

namespace GymMS_Project1.Trainers
{
    public partial class frmTrainersList : Form
    {

        private static DataTable _TrainersList = clsTrainer.GetTrainersList();
        private DataTable _AllTrainersList = _TrainersList.DefaultView.ToTable(false, "TrainerID", "FirstName", "LastName",
            "Specialty", "Rate", "Phone", "Email", "Gendor", "ImagePath");


        private void _RefreshTrainersList ()
        {
            _TrainersList = clsTrainer.GetTrainersList();
            _AllTrainersList = _TrainersList.DefaultView.ToTable(false, "TrainerID", "FirstName", "LastName",
            "Specialty", "Rate", "Phone", "Email", "Gendor");
            
            dgvTrainersList.DataSource = _AllTrainersList;
            lblTarinersCount.Text = $"Trainers Count: {dgvTrainersList.RowCount}";

        }

        public frmTrainersList()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmTrainersList_Load(object sender, EventArgs e)
        {
            _RefreshTrainersList();
        }


        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dgvTrainersList.CurrentCell.Value.ToString(), out int TrainerID))
            {
                MessageBox.Show("Must Select 1 Trainer at Time To Show Its Details", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmTrainerDetails frm = new frmTrainerDetails(TrainerID);
            frm.ShowDialog();

        }
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dgvTrainersList.CurrentCell.Value.ToString(), out int TrainerID))
            {
                MessageBox.Show("Select One Trainer at Time", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Delete this Trainer?", "Alert",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (!clsTrainer.DeleteTrainer(TrainerID))
            {
                MessageBox.Show("The trainer cannot be deleted because some data is associated with them.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Trainer Deleted Successfully", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _RefreshTrainersList();
        }
        private void tsmiAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditTrainer frm = new frmAddEditTrainer();
            frm.RefreshTrainersList += Frm_RefreshTrainersList;
            frm.ShowDialog();
        }
        private void btnAddNewTrainer_Click(object sender, EventArgs e)
        {
            frmAddEditTrainer frm = new frmAddEditTrainer();
            frm.RefreshTrainersList += Frm_RefreshTrainersList;
            frm.ShowDialog();
        }
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dgvTrainersList.CurrentRow.Cells["TrainerID"].Value.ToString(), out int ID))
            {
                MessageBox.Show("Please select only 1 trainer to Update", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddEditTrainer frm = new frmAddEditTrainer(ID);
            frm.RefreshTrainersList += Frm_RefreshTrainersList;
            frm.ShowDialog();

        }

        //delegate to refresh trainers list
        private void Frm_RefreshTrainersList()
        {
            _RefreshTrainersList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTarinersCount_Click(object sender, EventArgs e)
        {

        }
    }
}
