using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.HospitalHub.Entity;
using App.HospitalHub.Framework;
using App.HospitalHub.Repo;

namespace App.HospitalHub.GUI
{
    public partial class UcOrdinatorReg : UserControl
    {
        Hospital hospital = new Hospital();
        Coordinator coordinator = new Coordinator();
        CoordinatorRepo coordinatorRepo = new CoordinatorRepo();
        HospitalRepo hospitalRepo = new HospitalRepo();


        public UcOrdinatorReg()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FillEntity()
        {
            if (!IsValidToRegistration())
                return;
            coordinator.username = this.tbUsername.Text;
            coordinator.password = this.tbPassword.Text;
            coordinator.firstName = this.tbFirstName.Text;
            coordinator.lastName = this.tbLastName.Text;
            coordinator.phone = this.tbPhone.Text;
            coordinator.email = this.tbEmail.Text;
            hospital.hospitalId = this.tbHospitalId.Text;
            hospital.name = this.tbHospitalName.Text;


           
        }


        private bool IsValidToRegistration()
        {
            if (Validation.IsStringValid(this.tbUsername.Text) && Validation.IsStringValid(this.tbPassword.Text) &&
                Validation.IsStringValid(this.tbFirstName.Text) && Validation.IsStringValid(this.tbLastName.Text) &&
                Validation.IsStringValid(this.tbPhone.Text) && Validation.IsStringValid(this.tbEmail.Text) && 
                    Validation.IsStringValid(this.tbHospitalId.Text) && Validation.IsStringValid(this.tbHospitalName.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.FillEntity();
            bool d = coordinatorRepo.CoordinatorRegistration(coordinator);
            bool h = hospitalRepo.HospitalNameAdd(hospital);
            bool n = hospitalRepo.CoordinatorHospitalTable(coordinator, hospital);
            

            if (d == true && h == true && n == true)
            {
                MessageBox.Show("Insert Done");
            }
            else
                MessageBox.Show("Insert Not Done");
        }
    }
}
