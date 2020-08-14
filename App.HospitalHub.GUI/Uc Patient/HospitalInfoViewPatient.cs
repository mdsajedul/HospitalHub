using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.HospitalHub.GUI
{
    public partial class HospitalInfoViewPatient : Form
    {
        public HospitalInfoViewPatient()
        {
            InitializeComponent();
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            Dashboard pDashboard = new Dashboard();
            pDashboard.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UcPatientProfile ucPatientProfile = new UcPatientProfile();
            ucPatientProfile.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HospitalInfoViewPatient_Load(object sender, EventArgs e)
        {
            this.ucHospitalDeptView1.Show();
            this.ucDiagnosisViewPatient1.Hide();
            this.ucOtherServicesPatients1.Hide();
            this.ucRatingPatient1.Hide();
            this.ucFoodPatientView1.Hide();
        }

        private void ucHospitalDeptView1_Load(object sender, EventArgs e)
        {

        }

        private void btnUcDeptDoctor_Click(object sender, EventArgs e)
        {
            this.ucFoodPatientView1.Hide();
            this.ucRatingPatient1.Hide();
            this.ucOtherServicesPatients1.Hide();
            this.ucDiagnosisViewPatient1.Hide();
            this.ucHospitalDeptView1.Show();
            this.ucHospitalDeptView1.BringToFront();
        }

        private void btnUcDiagnosis_Click(object sender, EventArgs e)
        {
            this.ucFoodPatientView1.Hide();
            this.ucRatingPatient1.Hide();
            this.ucOtherServicesPatients1.Hide();
            this.ucHospitalDeptView1.Hide();
            this.ucDiagnosisViewPatient1.Show();
            this.ucDiagnosisViewPatient1.BringToFront();
        }

        private void btnUcOther_Click(object sender, EventArgs e)
        {
            this.ucFoodPatientView1.Hide();
            this.ucRatingPatient1.Hide();
            this.ucDiagnosisViewPatient1.Hide();
            this.ucHospitalDeptView1.Hide();
            this.ucOtherServicesPatients1.Show();
            this.ucOtherServicesPatients1.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            this.ucFoodPatientView1.Hide();
            this.ucDiagnosisViewPatient1.Hide();
            this.ucHospitalDeptView1.Hide();
            this.ucOtherServicesPatients1.Hide();
            this.ucRatingPatient1.Show();
            this.ucRatingPatient1.BringToFront();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.ucDiagnosisViewPatient1.Hide();
            this.ucHospitalDeptView1.Hide();
            this.ucOtherServicesPatients1.Hide();
            this.ucRatingPatient1.Hide();
            this.ucFoodPatientView1.Show();
            this.ucFoodPatientView1.BringToFront();
        }
    }
}
