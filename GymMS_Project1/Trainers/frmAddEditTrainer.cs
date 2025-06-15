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
using System.IO;
using GymMS_Project1.Properties;

namespace GymMS_Project1.Trainers
{
    public partial class frmAddEditTrainer : Form
    {

        //delegate for refreshing trainers list after add or update trainer
        public delegate void OnTrainerAddedOrUpdated();
        public event OnTrainerAddedOrUpdated RefreshTrainersList;


        enum enMode { AddNew = 0, Update = 1 };

        string _ImagePath;
        private enMode _Mode;
        private clsPerson _Person;
        private clsTrainer _trainer;


        public frmAddEditTrainer()
        {
            InitializeComponent();
            this._Mode = enMode.AddNew;
            this._trainer = new clsTrainer();
            this._Person = new clsPerson();

        }
        public frmAddEditTrainer(int TrainerID)
        {
            InitializeComponent();
            this._trainer = clsTrainer.FindByID(TrainerID);
            this._Person = clsPerson.FindByID(_trainer.PersonID);
            this._ImagePath = _Person.ImagePath;
            _Mode = enMode.Update;

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
        private void _FillTrainerObject ()
        {
            _trainer.PersonID = _Person.PersonID;
            _trainer.Specialty = txtSprecialty.Text.Trim();
            _trainer.Rate = Convert.ToInt16(txtRate.Text.Trim());
            _trainer.Salary= Convert.ToInt16(txtSalary.Text.Trim());
        }

        // here we'll save the person and job info 
        private void _Add_UpdateTrainer ()
        {
            _FillPersonObjectAndBoxes_SaveIt();
            _FillTrainerObject();
        }
        private void _LoadAddNewTrainerScreen()
        {
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-90);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-14);
            cbGender.SelectedIndex = 0;

            llRemovePic.Visible = false;

        }
        private void _LoadUpdateTrainerScreen()
        {
            lblTitle.Text = "Update Member";
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
                if (File.Exists(_ImagePath))
                    pbPersonImage.Load(_ImagePath);
                else
                    MessageBox.Show("Image Doesn't exist, Please check Image Source path", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            txtSprecialty.Text = _trainer.Specialty.Trim();
            txtRate.Text = _trainer.Rate.ToString();
            txtSalary.Text = _trainer.Salary.ToString();

        }
        private void llAddPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = "";
            ofdChooseImage.Filter = "File Name |*.png ; *.jpeg; *. jpg";
            ofdChooseImage.FilterIndex = 1;


            //use try catch is better
            if (ofdChooseImage.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdChooseImage.FileName;
                llRemovePic.Visible = true;
                pbPersonImage.Load(fileName);
                _Person.ImagePath = fileName;
            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpTrainerInfo"];
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpPersonInfo"];
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSaveTrainer_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Are Required, Make sure to fill them with valid values", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Add_UpdateTrainer();

            // rest of work
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_trainer.Save())
                    {
                        MessageBox.Show("Trainer Added Successfully", "Added",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _Mode = enMode.Update;
                        RefreshTrainersList?.Invoke();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Trainer Can not be Added", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;


                case enMode.Update:
                    
                    if (_trainer.Save())
                    {
                        MessageBox.Show("Trainer Updated Successfully", "Updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshTrainersList?.Invoke();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Trainer Can not be Updated", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }





        }
        private void EmptyTxtBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;


            if (string.IsNullOrEmpty(temp.Text))
            {
                btnSaveTrainer.Enabled = false;
                e.Cancel = true;
                errorProvider1.SetError(temp, "Field is Required");
            }
            else
            {
                btnSaveTrainer.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(temp, null);
            }
        }
        private void JustNumbers_validating(object sender, KeyPressEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cbGender_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = (ComboBox)sender;

            if (temp.SelectedIndex < 0 || temp.SelectedIndex > 1 || string.IsNullOrEmpty(temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "choose item from the list");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, null);

            }
        }
        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex == 0)
                pbPersonImage.Image = Resources.person_man;
            else
                pbPersonImage.Image = Resources.person_girl;
        }
        private void frmAddEditTrainer_Load(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _LoadAddNewTrainerScreen();
                    return;

                case enMode.Update:
                    _LoadUpdateTrainerScreen();
                    return;
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
    }
}
