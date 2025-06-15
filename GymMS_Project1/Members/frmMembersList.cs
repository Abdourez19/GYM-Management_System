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
    public partial class frmMembersList : Form
    {

        private static DataTable _dtMembers = clsMemberShip.GetMemberShipsList();

        private DataTable _ALlMembersList = _dtMembers.DefaultView.ToTable(false, "MemberID", "FirstName", "MiddleName",
                                                        "LastName", "Gender_Caption", "Email", "Phone",
                                                        "PackageName", "PlanDuration", "Specialty");
        public frmMembersList()
        {
            InitializeComponent();
        }

        private void _RefreshMembersList()
        {

            _dtMembers = clsMemberShip.GetMemberShipsList();

            _ALlMembersList = _dtMembers.DefaultView.ToTable(false, "MemberID", "FirstName", "MiddleName",
                                                                          "LastName" , "Gender_Caption", "Email", "Phone",
                                                                          "PackageName", "PlanDuration", "Specialty");

            

            dgvMembersList.DataSource = _ALlMembersList;
            lblTotalMembers.Text = dgvMembersList.Rows.Count.ToString();
            
            cbFilterBy.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMembersList_Load(object sender, EventArgs e)
        {
            _RefreshMembersList();
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            
            switch (cbFilterBy.Text)
            {
                
                case "Member ID":
                    FilterColumn = "MemberID";
                    break;
                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (FilterColumn == "None" || txtSearch.Text == "")
            {
                _ALlMembersList.DefaultView.RowFilter = "";
                lblTotalMembers.Text = _ALlMembersList.Rows.Count.ToString();
                return;
            }
            
            if (FilterColumn == "MemberID")
                _ALlMembersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());
            else
                _ALlMembersList.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtSearch.Text.Trim());

        }
        private void cbFilterBy_TextChanged(object sender, EventArgs e)
        {

            txtSearch.Enabled = (cbFilterBy.Text != "None");
            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Member ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddEditMember frm = new frmAddEditMember();
            frm.RefreshMembersList += Delegate_RefreshMembersList;
            frm.ShowDialog();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MemberID = -1;

            if (int.TryParse(dgvMembersList.CurrentRow.Cells["MemberID"].Value.ToString(), out int ID))
                MemberID = ID;

            clsMemberShip Member = clsMemberShip.FindMember(MemberID);

            if (Member == null)
            {
                MessageBox.Show("Can't Find This Member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmMemberDetails frm = new frmMemberDetails(Member);
            frm.ShowDialog();

        }

        private void tsmiAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditMember frm = new frmAddEditMember();
            frm.RefreshMembersList += Delegate_RefreshMembersList;
            frm.ShowDialog();
        }

        private void Delegate_RefreshMembersList()
        {
            _RefreshMembersList();
        }

        private void tsmiUpdateMember_Click(object sender, EventArgs e)
        {
            frmAddEditMember frm = new frmAddEditMember(Convert.ToInt32(dgvMembersList.CurrentRow.Cells[0].Value));
            frm.RefreshMembersList += Delegate_RefreshMembersList;
            frm.ShowDialog();
        }

        private void tsmiDeleteMember_Click(object sender, EventArgs e)
        {
            int MemberID = Convert.ToInt32(dgvMembersList.CurrentRow.Cells[0].Value);

                if (MessageBox.Show(@"Are you Sure You Want to Delete this Membership?", "Warning",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)

                    if (clsMemberShip.DeleteMembership(MemberID))
                        MessageBox.Show(@"Membership Deleted Successfully ", "Deleted",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            _RefreshMembersList();

        }
    }
}
