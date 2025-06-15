using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Business;
using GymMS_Project1.Properties;

namespace GymMS_Project1.Members
{
    public partial class frmAddEditMember : Form
    {

        public delegate void OnMemberAdded();
        
        public event OnMemberAdded RefreshMembersList;



        enum enMode { AddNew = 0, Update = 1};
        string _ImagePath;

        private enMode _Mode;
        private int _MemberID;
        private clsPerson _Person;
        private clsMemberShip _Member ;
        private clsPackage _package ;
        private clsPlan _plan ;
        private clsTrainer _trainer ;


        public frmAddEditMember()
        {
            InitializeComponent();

            _MemberID = -1;

            _Member = new clsMemberShip();
            _Person = new clsPerson();
            _Member = new clsMemberShip();
            _plan = new clsPlan();
            _trainer = new clsTrainer();
            
            _Mode = enMode.AddNew;
        }
        public frmAddEditMember(int MemberID)
        {
            InitializeComponent();
            this._MemberID = MemberID;
            this._Member = clsMemberShip.FindMember(_MemberID);
            this._Person = clsPerson.FindByID(_Member.PersonID);
            this._plan = clsPlan.FindPlanInfoByID(_Member.PlanID);
            this._package = clsPackage.FindPackageByID(_Member.PackageID);
            this._trainer = clsTrainer.FindByID(_Member.TrainerID);
            this._ImagePath = _Person.ImagePath;
            this._Mode = enMode.Update;
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
        private void _FillPackageObjectAndCb()
        {
            _package = clsPackage.FindPackageByName(cbPackage.Text.Trim());
        }
        private void _FillPlanObjectAndCb()
        {
            if (int.TryParse(cbPlan.Text, out int SelectedDuration))
                _plan = clsPlan.GetPlanByDuration(SelectedDuration);
            else
                MessageBox.Show("Something went wrong with Duration Selecting!", "Duration Plan Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _FillTrainerObjectAndCb()
        {
            if (!string.IsNullOrEmpty(cbTrainer.Text.Trim()))
            {
                _trainer = clsTrainer.FindTrainerBySpecialty(cbTrainer.Text.Trim());
            }
            else
                _trainer = null;
        }
        private void _FillMemberObject()
        {
            _Member.PersonID = _Person.PersonID;
            _Member.PackageID = _package.PackageID;
            _Member.PlanID = _plan.PlanID;

            if (_trainer != null)
                _Member.TrainerID = _trainer.TrainerID;
            else
                _Member.TrainerID = -1;


            _Member.SubscriptionDate = dtpSubscriptionDate.Value;
            _Member.Amount = (_package.PricePerMonth * Convert.ToDouble(_plan.PlanDuration));
            _Member.AdditionalNotes = txtNotes.Text;

            //Read Only TextBox
            txtAmount.Text = _Member.Amount.ToString();

        }


        private void _Add_UpdateMember_NewValues()
        {
            _FillPersonObjectAndBoxes_SaveIt();
            _FillPackageObjectAndCb();
            _FillPlanObjectAndCb();
            _FillTrainerObjectAndCb();

            //At this point the "Member Object" is ready to save
            _FillMemberObject();
        }




        private void _FillPlansCB()
        {
            DataTable dt = clsPlan.GetPlansList();

            foreach (DataRow row in dt.Rows)
            {
                cbPlan.Items.Add(row["PlanDuration"].ToString());
            }
        }
        private void _FillPackagesCB()
        {
            DataTable dt = clsPackage.GetPackagesList();

            foreach (DataRow row in dt.Rows)
            {
                cbPackage.Items.Add(row["PackageName"].ToString());
            }
        }
        private void _FillTrainerCB()
        {
            DataTable dt = clsTrainer.GetTrainersList();

            foreach (DataRow row in dt.Rows)
            {
                cbTrainer.Items.Add(row["Specialty"]);
            }
        }


        //// if Add New
        private void _LoadAddNewMemberScreen()
        {
            _FillPlansCB();
            _FillPackagesCB();
            _FillTrainerCB();

            cbPlan.SelectedIndex = 0;
            cbPackage.SelectedIndex = 0;
            cbTrainer.SelectedIndex = 0;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-90);
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-14);


            cbGender.SelectedIndex = 0;

            dtpSubscriptionDate.MinDate = DateTime.Now;
            dtpSubscriptionDate.MaxDate = DateTime.Now.AddYears(5);
            llRemovePic.Visible = false;
            
        }

        //// if Update
        private void _LoadUpdateMemberScreen ()
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
                    MessageBox.Show("Image Doesn't exist, Please check Image Path", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                

            _FillPlansCB();
            _FillPackagesCB();
            _FillTrainerCB();

            cbPlan.SelectedItem = _plan.PlanDuration.ToString();
            cbPackage.SelectedItem = _package.PackageName;

            if (_trainer != null)
                cbTrainer.SelectedItem = _trainer.Specialty;
            else
                cbTrainer.SelectedItem = -1;


            txtNotes.Text = _Member.AdditionalNotes;
            txtAmount.Text = _Member.Amount.ToString();




        }

        
        private void frmAddEditMember_Load(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _LoadAddNewMemberScreen();
                    return;

                case enMode.Update:
                    _LoadUpdateMemberScreen();
                    return;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EmptyTxtBoxValidating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                btnSave.Enabled = false;
                e.Cancel = true;
                errorProvider1.SetError(temp, "Some Fields Must Have Values");
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
            ofdAddPic.Filter = "File Name| *.png; *.jpg; .*jpeg";
            ofdAddPic.FilterIndex = 0;
            ofdAddPic.RestoreDirectory = true;

            if (ofdAddPic.ShowDialog()== DialogResult.OK)
            {
                ImagePath = ofdAddPic.FileName;
                pbPersonImage.Load(ImagePath);
                llRemovePic.Visible = true;
                _Person.ImagePath = ImagePath;
            }
        }
        private void llRemovePic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            llRemovePic.Visible = false;
            _Person.ImagePath = "";
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpMembershipInfo"];
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            tcMemberInfo.SelectedTab = tcMemberInfo.TabPages["tpPersonInfo"];
        }
        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex == 0)
                pbPersonImage.Image = Resources.person_man;
            else
                pbPersonImage.Image = Resources.person_girl;
        }
        private void EmptyCb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = (ComboBox)sender;

            if (temp.SelectedIndex < 0 || temp.SelectedIndex > temp.Items.Count - 1)
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "Choose Item from List");
            }

            else
                errorProvider1.SetError(temp, null);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate all the Controls of the form that accept validation
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Must Have Value", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _Add_UpdateMember_NewValues();

            switch (_Mode)
            {
                case enMode.AddNew:
                    //_Add_UpdateMember_NewValues();

                    if (_Member.Save())
                    {
                        MessageBox.Show("MemberShip Added Successfully", "Added",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshMembersList?.Invoke();
                        this.Close();
                    }
                    else
                        MessageBox.Show("MemberShip Can't be Added", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;




                case enMode.Update:
                    //_Add_UpdateMember_NewValues();
                    if (_Member.Save())
                    {
                        MessageBox.Show("MemberShip Added Successfully", "Added",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshMembersList?.Invoke();
                        this.Close();
                    }
                    else
                        MessageBox.Show("MemberShip Can't be Updated", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

            }
            
        }

        

        
    }
}
