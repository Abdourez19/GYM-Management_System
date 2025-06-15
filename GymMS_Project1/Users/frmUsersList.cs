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
    public partial class frmUsersList : Form
    {

        private static DataTable _UsersList = clsUser.UsersList();

        private DataTable _AllUsersList = _UsersList.DefaultView.ToTable(false, "UserID", "Username", "FirstName", "LastName", "Phone",
                                                                    "Email", "Gender", "Permissions_Level");


        private clsUser _User;
        private int _PersonID;

        
        public frmUsersList()
        {
            InitializeComponent();
        }
        private void _RefreshUsersList()
        {
            _UsersList = clsUser.UsersList();
            _AllUsersList = _UsersList.DefaultView.ToTable(false, "UserID", "Username", "FirstName", "LastName", "Phone", "Email",
                                                                "Gender", "Permissions_Level");

            dgvUsersList.DataSource = _AllUsersList;
            lblUsersCount.Text = $"Total Users Number: {dgvUsersList.RowCount}";
            cbFilter.SelectedItem = "None";
        }



        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbFilter_TextChanged(object sender, EventArgs e)
        {
            txtUserSearch.Enabled = (cbFilter.Text != "None");

            if (txtUserSearch.Enabled)
            {
                txtUserSearch.Text = "";
                txtUserSearch.Focus();
            }
        }
        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "None":
                    FilterColumn = "None";
                    break;
                case "Username":
                    FilterColumn = "Username";
                    break;
                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
            }

            if (FilterColumn == "None" || FilterColumn == "")
            {
                _AllUsersList.DefaultView.RowFilter = "";
                lblUsersCount.Text = $"total users count: {dgvUsersList.RowCount}";
                return;
            }

            _AllUsersList.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtUserSearch.Text.Trim());
            lblUsersCount.Text = $"total users count: {dgvUsersList.RowCount}";


        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.RefreshUsersList += Frm_RefreshUsersList;
            frm.ShowDialog();
        }



        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dgvUsersList.CurrentRow.Cells["UserID"].Value.ToString(), out int ID))
            {
                MessageBox.Show("Must select only one (1) user at time", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User = clsUser.Find(ID);

            if (_User == null)
            {
                MessageBox.Show("No User Found", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _PersonID = _User.PersonID;

            if (MessageBox.Show($"Are you sure you want to delete \"{_User.Username}\" from Users? ", "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.Delete(_User.UserID) && clsPerson.DeletePerson(_PersonID))
                {
                    MessageBox.Show("User deleted successfully", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                    return;
                }
            }
            else
            {
                _RefreshUsersList();
                return;
            }



        }
        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (!int.TryParse(dgvUsersList.CurrentRow.Cells["UserID"].Value.ToString(), out int ID))
            {
                MessageBox.Show("Must select only one (1) user at time", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmUserDetails frm = new frmUserDetails(ID);
            frm.ShowDialog();

        }
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.RefreshUsersList += Frm_RefreshUsersList;
            frm.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dgvUsersList.CurrentRow.Cells["UserID"].Value.ToString(), out int ID))
            {
                MessageBox.Show("Must select only one (1) user at time", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddEditUser frm = new frmAddEditUser(ID);
            frm.RefreshUsersList += Frm_RefreshUsersList;
            frm.ShowDialog();
        }
        private void Frm_RefreshUsersList()
        {
            _RefreshUsersList();
        }





    }
}
