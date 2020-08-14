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
using App.HospitalHub.Repo;

namespace App.HospitalHub.GUI
{
    public partial class UcPatientProfile : UserControl
    {
        private PatientRepo patientRepo { get; set; }
        private Login login = new Login();
        Patient patient = new Patient();
        public UcPatientProfile()
        {
            InitializeComponent();
            this.patientRepo = new PatientRepo();
        }

        private void UcPatientProfile_Load(object sender, EventArgs e)
        {
            string v = Login.username.ToUpper();
            lblname.Text = v;

            // this.ViewInfo();
            /*
            patient.username = Login.username;
            Patient p = patientRepo.PatientView(patient);
            lblUsername.Text = p.username;
            lblFirstName.Text = p.firstName;
            lblLastName.Text = p.lastName;
            lblDob.Text = p.dob;
            lblPhone.Text = p.phone;
            lblEmail.Text = p.email;
            lblDistrict.Text = p.district;
            lblDivision.Text = p.division;
            lblArea.Text = p.area;
            lblHouse.Text = p.houseNo;
            lblRoad.Text = p.roadNo;
            lblSex.Text = p.sex;
            */
        }

        /*
        public void ViewInfo()
        {
            patient.username = Login.username;
            Patient p = patientRepo.PatientView(patient);
            lblUsername.Text = p.username;
            lblFirstName.Text = p.firstName;
            lblLastName.Text = p.lastName;
            lblDob.Text = p.dob;
            lblPhone.Text = p.phone;
            lblEmail.Text = p.email;
            lblDistrict.Text = p.district;
            lblDivision.Text = p.division;
            lblArea.Text = p.area;
            lblHouse.Text = p.houseNo;
            lblRoad.Text = p.roadNo;
            lblSex.Text = p.sex;
           
        }
        */
        private void btnEdit_Click(object sender, EventArgs e)
        {
            patient.username = Login.username;
            FormEditProfilePatient formEditProfile = new FormEditProfilePatient();
            formEditProfile.Show();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            patient.username = Login.username;
            Patient p = patientRepo.PatientView(patient);
            lblUsername.Text = p.username;
            lblFirstName.Text = p.firstName;
            lblLastName.Text = p.lastName;
            lblDob.Text = p.dob;
            lblPhone.Text = p.phone;
            lblEmail.Text = p.email;
            lblDistrict.Text = p.district;
            lblDivision.Text = p.division;
            lblArea.Text = p.area;
            lblHouse.Text = p.houseNo;
            lblRoad.Text = p.roadNo;
            lblSex.Text = p.sex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            patient.username = Login.username;
            bool b = patientRepo.ProfileDelete(patient);

            if (b == true)
            {
                MessageBox.Show("Delete Confirmed");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Id");
        }
    }
}
