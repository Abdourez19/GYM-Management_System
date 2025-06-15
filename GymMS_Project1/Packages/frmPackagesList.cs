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

namespace GymMS_Project1.Packages
{
    public partial class frmPackagesList : Form
    {
        private DataTable _Packages = clsPackage.GetPackagesList();

        
        int _PackageID = -1; 
        clsPackage _Package;
        

        public frmPackagesList()
        {
            InitializeComponent();
        }

        private void _RefreshPackagesList()
        {
            _Packages = clsPackage.GetPackagesList();
            dgvPackagesList.DataSource = _Packages.DefaultView.ToTable();
            lblTotalPackages.Text = dgvPackagesList.RowCount.ToString();
        }

        private void frmPackagesList_Load(object sender, EventArgs e)
        {
            _RefreshPackagesList();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshPackagesList();
        }
        private void txtAddPackagePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void EmptyTxtBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError((TextBox)sender, "Field Must Have Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void _EmptyAddNewPackageFields ()
        {
            txtAddPackageName.Text = "";
            txtAddPackageDescription.Text = "";
            txtAddPackagePrice.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Package = new clsPackage();

            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields must have values", "Alert", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            _Package.PackageID = _PackageID;
            _Package.PackageName = txtAddPackageName.Text.Trim();
            _Package.PackageDescription = txtAddPackageDescription.Text.Trim();
            _Package.PricePerMonth = double.Parse(txtAddPackagePrice.Text.Trim());

            if (_Package.Save())
            {
                MessageBox.Show("Package Added Successfully", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Package Could not be Added, Something went wrong", "ERROR", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

            _RefreshPackagesList();
            _EmptyAddNewPackageFields();
        }
        private void deletePackageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this Package?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsPackage.Delete((int)dgvPackagesList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Package Deleted Successfully", "Deleted",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Package can't be Deleted, Package Attached with other Data", "Alert",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            _RefreshPackagesList();
        }


        //open Edit package from and subscribe in its event,
        //used for refresh packages list when package is updated
        private void editPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditPackage frm = new frmEditPackage((int)dgvPackagesList.CurrentRow.Cells[0].Value);
            frm.NotifyWhenPackageIsUpdated += Frm_NotifyWhenPackageIsUpdated;
            frm.ShowDialog();
        }
        private void Frm_NotifyWhenPackageIsUpdated(object sender)
        {
            _RefreshPackagesList();
        }
    }
}
