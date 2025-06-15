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
    public partial class frmEditPackage : Form
    {

        public delegate void OnPackageEditedSucceeded(object sender);

        public event OnPackageEditedSucceeded NotifyWhenPackageIsUpdated;



        private int _PackageID;
        private clsPackage _Package;
        public frmEditPackage(int PackageID)
        {
            InitializeComponent();
            _PackageID = PackageID;
            _Package = clsPackage.FindPackageByID(PackageID);
        }

        
        private void _FillFormTxtBoxesByInfo()
        {
            txtPackageName.Text = _Package.PackageName.Trim();
            txtPackageDescription.Text = _Package.PackageDescription.Trim();
            txtPackagePrice.Text = _Package.PricePerMonth.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmptyTxtBoxValidating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "Field must Have Value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void txtPackagePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void frmEditPackage_Load(object sender, EventArgs e)
        {
            _FillFormTxtBoxesByInfo();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Package.PackageName = txtPackageName.Text.Trim();
            _Package.PackageDescription = txtPackageDescription.Text.Trim();
            _Package.PricePerMonth = double.Parse(txtPackagePrice.Text.Trim());


            if (_Package.Save())
            {
                MessageBox.Show("Package Updated Successfully", "Updated",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotifyWhenPackageIsUpdated?.Invoke(this);
                
            }
            else
            {
                MessageBox.Show("Something went wrong, ", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Close();
        }
    }
}
