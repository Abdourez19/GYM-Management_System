using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Business;
using GymMS_Project1.Global;
using GymMS_Project1.Properties;

namespace GymMS_Project1.Users
{
    public partial class frmAddEditUser : Form
    {

        public delegate void OnAddingOrUpdatingSuccess();

        public event OnAddingOrUpdatingSuccess RefreshUsersList;

        enum enMode {AddNew = 0, Update = 1, ManageCurrentUser = 2}

        enMode _Mode;
        private string _ImagePath;
        private int _UserID;
        private clsUser _User;
        private clsPerson _Person;

        public frmAddEditUser()
        {
            InitializeComponent();
            _UserID = -1;
            _User = new clsUser();
            _Person = new clsPerson();
            _Mode = enMode.AddNew;
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _User = clsUser.Find(UserID);
            _Person = clsPerson.FindByID(_User.PersonID);
            _ImagePath = _Person.ImagePath;
            _Mode = enMode.Update;
        }
        public frmAddEditUser(clsUser User)
        {
            InitializeComponent();
            _UserID = User.UserID;
            _User = User;
            _Person = clsPerson.FindByID(_User.PersonID);
            _ImagePath = _Person.ImagePath;
            _Mode = enMode.ManageCurrentUser;
        }


        private void _FillPersonObjectAndBoxes_SaveIt()
        {
            _Person.IDCardNumber = txtIdCardNumber.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.MiddleName = txtMiddleName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.Gender = cbGender.SelectedIndex;
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (!_Person.Save())
                MessageBox.Show("Something Went Wrong With Person Info Adding!", "PersonInfo Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _FillUserObject()
        {
            _User.PersonID = _Person.PersonID;
            _User.Username = txtUsername.Text.Trim();
            _User.Password = clsGlobal.ComputeHash(txtPassword.Text.Trim());


            int Permissions = Convert.ToInt32(cbDashboard.Tag.ToString());

            if (cbManageMemberships.Checked)
                Permissions += Convert.ToInt32(cbManageMemberships.Tag.ToString());

            if (cbManagePackages.Checked)
                Permissions += Convert.ToInt32(cbManagePackages.Tag.ToString());

            if (cbManagePlans.Checked)
                Permissions += Convert.ToInt32(cbManagePlans.Tag.ToString());

            if (cbManageTrainers.Checked)
                Permissions += Convert.ToInt32(cbManageTrainers.Tag.ToString());

            if (cbManageUsers.Checked)
                Permissions += Convert.ToInt32(cbManageUsers.Tag.ToString());


            _User.Permissions = Permissions;

        }
        private bool _ConfirmPassword()
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password Doesn't match", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void _SetCheckBoxPermissions(int Permissions)
        {
            if (Permissions == -1 || Permissions == 63)
            {
                cbDashboard.Checked = true;
                cbManageMemberships.Checked = true;
                cbManagePackages.Checked = true;
                cbManagePlans.Checked = true;
                cbManageTrainers.Checked = true;
                cbManageUsers.Checked = true;
                return;
            }
            if (Permissions == 1)
                cbDashboard.Checked = true;

            if ((Permissions & Convert.ToInt32(cbDashboard.Tag)) == Convert.ToInt32(cbDashboard.Tag))
                cbDashboard.Checked = true;

            if ((Permissions & Convert.ToInt32(cbManageMemberships.Tag)) == Convert.ToInt32(cbManageMemberships.Tag))
                cbManageMemberships.Checked = true;

            if ((Permissions & Convert.ToInt32(cbManagePackages.Tag)) == Convert.ToInt32(cbManagePackages.Tag))
                cbManagePackages.Checked = true;

            if ((Permissions & Convert.ToInt32(cbManagePlans.Tag)) == Convert.ToInt32(cbManagePlans.Tag))
                cbManagePlans.Checked = true;

            if ((Permissions & Convert.ToInt32(cbManageTrainers.Tag)) == Convert.ToInt32(cbManageTrainers.Tag))
                cbManageTrainers.Checked = true;

            if ((Permissions & Convert.ToInt32(cbManageUsers.Tag)) == Convert.ToInt32(cbManageUsers.Tag))
                cbManageTrainers.Checked = true;


        }


        private void _Add_UpdateUser()
        {
            
            _FillPersonObjectAndBoxes_SaveIt();
            _FillUserObject();
        }
        private void _Load_AddNewUserScreen()
        {
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-90);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-14);
            cbGender.SelectedIndex = 0;

            llRemovePic.Visible = false;
            lblNote.Visible = false;
        }
        private void _Load_UpdateUserScreen() 
        {
            lblTitle.Text = "Update User";
            txtFirstName.Text = _Person.FirstName;
            txtMiddleName.Text = _Person.MiddleName;
            txtLastName.Text = _Person.LastName;
            txtIdCardNumber.Text = _Person.IDCardNumber;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbGender.SelectedIndex = _Person.Gender;

            if (string.IsNullOrEmpty(_ImagePath))
            {
                if (_Person.Gender == 0)
                    pbPersonImage.Image = Resources.person_man;
                else
                    pbPersonImage.Image = Resources.person_girl;
            }
            else
            {
                llRemovePic.Visible = true;
                if (File.Exists(_ImagePath))
                    pbPersonImage.Load(_ImagePath);
                else
                    MessageBox.Show("Image path Doesn't Match", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtUsername.Text = _User.Username;
            //txtPassword.Text = _User.Password;
            _SetCheckBoxPermissions(_User.Permissions);
            lblNote.Visible = false;

        }
        private void _Load_ManageCurrentUserScreen()
        {
            lblTitle.Text = "Manage User info";
            txtFirstName.Text = _Person.FirstName;
            txtMiddleName.Text = _Person.MiddleName;
            txtLastName.Text = _Person.LastName;
            txtIdCardNumber.Text = _Person.IDCardNumber;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbGender.SelectedIndex = _Person.Gender;

            if (string.IsNullOrEmpty(_ImagePath))
            {
                if (_Person.Gender == 0)
                    pbPersonImage.Image = Resources.person_man;
                else
                    pbPersonImage.Image = Resources.person_girl;
            }
            else
            {
                llRemovePic.Visible = true;   
                if (File.Exists(_ImagePath))
                    pbPersonImage.Load(_ImagePath);
                else
                    MessageBox.Show("Image path Doesn't Match", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtUsername.Text = _User.Username;
            //txtPassword.Text = _User.Password;
            _SetCheckBoxPermissions(_User.Permissions);
            pnlPermissions.Enabled = false;
            lblNote.Visible = true;



        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            tcAddEditUser.SelectedTab = tcAddEditUser.TabPages["tpUserLogin"];
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            tcAddEditUser.SelectedTab = tcAddEditUser.TabPages["tpPersonInfo"];
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EmptyTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            if (string.IsNullOrEmpty(temp.Text))
            {
                btnSave.Enabled = false;
                e.Cancel = true;
                errorProvider1.SetError(temp, "Field is Required");
            }
            else
            {
                btnSave.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
        }
        private void llAddPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ImagePath = "";
            ofdChooseImage.Filter = "Image Files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            ofdChooseImage.FilterIndex = 1;
            ofdChooseImage.RestoreDirectory = true;


            if (ofdChooseImage.ShowDialog() == DialogResult.OK)
            {
                
                ImagePath = ofdChooseImage.FileName;
                try
                {
                    pbPersonImage.Load(ImagePath);
                    llRemovePic.Visible = true;
                    _Person.ImagePath = ImagePath;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                
            }
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _Load_AddNewUserScreen();
                    return;

                case enMode.Update:
                    _Load_UpdateUserScreen();
                    return;

                case enMode.ManageCurrentUser:
                    _Load_ManageCurrentUserScreen();
                    return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields must have Value", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_ConfirmPassword())
                return;


            

            _Add_UpdateUser();


            switch (_Mode)
            {
                case enMode.AddNew:

                    if (clsUser.IsExists(txtUsername.Text.Trim()))
                    {
                        MessageBox.Show("Username Is Already used, Please enter new one", "Alert",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (_User.Save())
                    {
                        MessageBox.Show("User Added Successfully", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _Mode = enMode.Update;
                        RefreshUsersList?.Invoke();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Something Went wrong, please Contact your admin", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case enMode.Update:
                    if (_User.Save())
                        if (_User.Save())
                        {
                            MessageBox.Show("User Updated Successfully", "Information",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshUsersList?.Invoke();
                            this.Close();
                        }
                        else
                            MessageBox.Show("User Can't be Updated, please Contact your admin", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case enMode.ManageCurrentUser:
                    if (_User.Save())
                        if (_User.Save())
                        {
                            MessageBox.Show("You Info Updated Successfully", "Information",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clsGlobal.CurrentUser = _User;
                            this.Close();
                        }
                        else
                            MessageBox.Show("Something went wrong!", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

            }
        }
        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex == 0)
                pbPersonImage.Image = Resources.person_man;
            else
                pbPersonImage.Image = Resources.person_girl;


            if (string.IsNullOrEmpty(_ImagePath))
            {
                pbPersonImage.ImageLocation = _ImagePath;
            }
        }
        private void llRemovePic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            pbPersonImage.ImageLocation = null;
            llRemovePic.Visible = false;
            _Person.ImagePath = "";
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.person_man;
            else
                pbPersonImage.Image = Resources.person_girl;

        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
