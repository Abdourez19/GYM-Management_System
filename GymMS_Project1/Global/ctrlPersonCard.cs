using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Business;
using GymMS_Project1.Properties;

namespace GymMS_Project1.Global
{
    public partial class ctrlPersonCard : UserControl
    {
        
        private int _PersonID = -1;
        private clsPerson _Person;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.person_man;
            if (_Person.Gender == 1)
                pbPersonImage.Image = Resources.person_girl;

            string ImagePath = _Person.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show($"Can't Find this Image = {ImagePath}", "ERROR",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                
        }
        private void _FillPersonInfo ()
        {
            txtFirstName.Text = _Person.FirstName.ToString();
            txtMiddleName.Text = _Person.MiddleName.ToString();
            txtLastName.Text = _Person.LastName.ToString();
            txtIdCardNumber.Text = _Person.IDCardNumber.ToString();
            txtPhone.Text = _Person.Phone.ToString();
            txtEmail.Text = _Person.Email.ToString();
            dtpDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            txtGender.Text = (_Person.Gender == 0 ? "Male" : "Female");
            txtAddress.Text = _Person.Address.ToString();
            _LoadPersonImage();
        }
        public void LoadPersonInfo (int PersonID)
        {
            if (clsPerson.FindByID(PersonID) == null)
            {
                MessageBox.Show($"Person with ID {PersonID} Doesn't exist!", "Alert",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //clsMemberShip.FindMember(PersonID);

            _Person = clsPerson.FindByID(PersonID);

            _FillPersonInfo();

        }

        public void LoadPersonInfo(string IDCardNumber)
        {
            if (clsPerson.FindByIDCardNumber(IDCardNumber) == null)
            {
                MessageBox.Show($"Person with ID Card Number{IDCardNumber} Doesn't exist!", "Alert",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            _Person = clsPerson.FindByIDCardNumber(IDCardNumber);

            _FillPersonInfo();

        }
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            txtFirstName.Text = "";
            txtMiddleName.Text ="";
            txtLastName.Text = "";
            txtIdCardNumber.Text ="";
            txtPhone.Text = "";
            txtEmail.Text = "";
            dtpDateOfBirth.Text ="";
            txtGender.Text = "";
            txtAddress.Text = "";
            pbPersonImage.Image = Resources.person_man;
        }

        private void llRemovePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ///////////////////////////////////////////
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
