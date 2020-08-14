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
using App.HospitalHub.Repo;
using App.HospitalHub.GUI;

namespace App.HospitalHub.GUI
{
    public partial class Dashboard : Form
    {
        private PatientRepo patientRepo { get; set; }
        private Login login = new Login();
        Patient patient = new Patient();
        Point lastPoint;
        public Dashboard()
        {
            InitializeComponent();
            this.patientRepo = new PatientRepo();
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void PnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
       
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            this.ucAppointmentPatient1.Hide();
            this.ucPatientProfile1.Hide();
            this.ucHospitalListView1.Show();
            //ViewInfo();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            
            this.ucAppointmentPatient1.Hide();
            this.ucPatientProfile1.Hide();
            this.ucHospitalListView1.Show();
            this.ucHospitalListView1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
           
            this.ucAppointmentPatient1.Hide();
            this.ucHospitalListView1.Hide();
            this.ucPatientProfile1.Show();
            this.ucPatientProfile1.BringToFront();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
           
            this.ucHospitalListView1.Hide();
            this.ucPatientProfile1.Hide();
            this.ucAppointmentPatient1.Show();
            this.ucAppointmentPatient1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

       
    }
}

