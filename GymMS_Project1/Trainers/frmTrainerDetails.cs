using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Business;

namespace GymMS_Project1.Plans
{
    public partial class frmTrainerDetails : Form
    {
        private int _TrainerID;
        private clsTrainer _Trainer;
        private clsPerson _Person;

        public frmTrainerDetails(int TrainerID)
        {
            InitializeComponent();
            this._TrainerID = TrainerID;
            this._Trainer = clsTrainer.FindByID(TrainerID);
            this._Person = new clsPerson();
        }

        private void _FillTrainerDetails() 
        {
           
                crtlPersonCard1.LoadPersonInfo(_Trainer.PersonID);
                txtTrainerID.Text = _Trainer.TrainerID.ToString();
                txtSpecialty.Text = _Trainer.Specialty;
                txtRate.Text = _Trainer.Rate.ToString();
                txtSalary.Text = _Trainer.Salary.ToString();
                return;

            
        }

        private void frmTrainerDetails_Load(object sender, EventArgs e)
        {
            _FillTrainerDetails();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
