using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.HospitalHub.Entity;
using App.HospitalHub.Framework;
using App.HospitalHub.Repo;


namespace App.HospitalHub.GUI
{
    public partial class FormOrdinatorProfileEdit : Form
    {

        Coordinator coordinator = new Coordinator();
        CoordinatorRepo coordinatorRepo = new CoordinatorRepo();
        HospitalRepo hospitalRepo = new HospitalRepo();
        Hospital hospital = new Hospital();


        public FormOrdinatorProfileEdit()
        {
            InitializeComponent();
        }



        private void ViewInfo()
        {
            coordinator.username = Login.username;
            Coordinator c = coordinatorRepo.GetInfo(coordinator);
            tbUsername.Text = c.username;
            tbFirstname.Text = c.firstName;
            tbLastname.Text = c.lastName;
            tbPhone.Text = c.phone;
            tbEmail.Text = c.email;
            tbPassword.Text = c.password;


        }


        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = hospitalRepo.GetHospitalId(coordinator);
            hospital.hospitalId = h.hospitalId;
        }


        private void ViewHospitalInfo()
        {
            GetHospitaLId();
            Hospital h = hospitalRepo.ViewInfo(hospital);
            tbHospitalId.Text = hospital.hospitalId;
            tbHospitalname.Text = h.name;
        }

        private void FormOrdinatorProfileEdit_Load(object sender, EventArgs e)
        {
            ViewInfo();
            ViewHospitalInfo();
        }

        private void FillEntity()
        {
            coordinator.username = tbUsername.Text;
            coordinator.firstName = tbFirstname.Text;
            coordinator.lastName = tbLastname.Text;
            coordinator.email = tbEmail.Text;
            coordinator.password = tbPassword.Text;
            coordinator.phone = tbPhone.Text;
            hospital.hospitalId = tbHospitalId.Text;
            hospital.name = tbHospitalname.Text;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillEntity();
            bool b = coordinatorRepo.CoordinatorRegistration(coordinator);
            bool d = hospitalRepo.HospitalNameAdd(hospital);

            if(b && d == true)
            {
                MessageBox.Show("Update Done");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
