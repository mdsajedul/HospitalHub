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
    public partial class DashboardCoordinator : Form
    {
        Point lastPoint;
        public DashboardCoordinator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ucHospitalInfoInput1_Load(object sender, EventArgs e)
        {

        }

        private void DashboardCoordinator_Load(object sender, EventArgs e)
        {
            this.ucOrdinatorProfile1.Hide();
            this.ucViewHospitalBasicInfo1.Show();
            this.ucDepartmentUpdate1.Hide();
            this.ucDoctorUpdate1.Hide();
            this.ucDiagnosisAdd1.Hide();
            this.ucServicesAdd1.Hide();
            this.ucAppoinmentOrdinator1.Hide();
        }

        private void btnPatientDetails_Click(object sender, EventArgs e)
        {
            this.ucOrdinatorProfile1.Hide();
            this.ucAppoinmentOrdinator1.Hide();
            this.ucServicesAdd1.Hide();
            this.ucDiagnosisAdd1.Hide();
            this.ucDoctorUpdate1.Hide();
            this.ucDepartmentUpdate1.Hide();
            this.ucViewHospitalBasicInfo1.Show();
            this.ucViewHospitalBasicInfo1.BringToFront();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            this.ucOrdinatorProfile1.Hide();
            this.ucAppoinmentOrdinator1.Hide();
            this.ucServicesAdd1.Hide();
            this.ucDiagnosisAdd1.Hide();
            this.ucDoctorUpdate1.Hide();
            this.ucViewHospitalBasicInfo1.Hide();
            this.ucDepartmentUpdate1.Show();
            this.ucDepartmentUpdate1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ucOrdinatorProfile1.Hide();
            this.ucAppoinmentOrdinator1.Hide();
            this.ucServicesAdd1.Hide();
            this.ucDiagnosisAdd1.Hide();
            this.ucViewHospitalBasicInfo1.Hide();
            this.ucDepartmentUpdate1.Hide();
            this.ucDoctorUpdate1.Show();
            this.ucDoctorUpdate1.BringToFront();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            this.ucOrdinatorProfile1.Hide();
            this.ucAppoinmentOrdinator1.Hide();
            this.ucServicesAdd1.Hide();
            this.ucDoctorUpdate1.Hide();
            this.ucViewHospitalBasicInfo1.Hide();
            this.ucDepartmentUpdate1.Hide();
            this.ucDiagnosisAdd1.Show();
            this.ucDiagnosisAdd1.BringToFront();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.ucOrdinatorProfile1.Hide();
            this.ucAppoinmentOrdinator1.Hide();
            this.ucViewHospitalBasicInfo1.Hide();
            this.ucDepartmentUpdate1.Hide();
            this.ucDiagnosisAdd1.Hide();
            this.ucDoctorUpdate1.Hide();
            this.ucServicesAdd1.Show();
            this.ucServicesAdd1.BringToFront();

        }

        private void ucViewHospitalBasicInfo1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            this.ucOrdinatorProfile1.Hide();
            this.ucViewHospitalBasicInfo1.Hide();
            this.ucDepartmentUpdate1.Hide();
            this.ucDiagnosisAdd1.Hide();
            this.ucDoctorUpdate1.Hide();
            this.ucServicesAdd1.Hide();
            this.ucAppoinmentOrdinator1.Show();
            this.ucAppoinmentOrdinator1.BringToFront();
        }

        private void btnDashboad_Click(object sender, EventArgs e)
        {
            this.ucViewHospitalBasicInfo1.Hide();
            this.ucDepartmentUpdate1.Hide();
            this.ucDiagnosisAdd1.Hide();
            this.ucDoctorUpdate1.Hide();
            this.ucServicesAdd1.Hide();
            this.ucAppoinmentOrdinator1.Hide();
            this.ucOrdinatorProfile1.Show();
            this.ucOrdinatorProfile1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
