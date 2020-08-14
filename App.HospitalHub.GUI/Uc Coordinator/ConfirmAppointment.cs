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
    public partial class ConfirmAppointment : Form
    {

        Appointment appointment = new Appointment();
        AppointmentRepo appointmentRepo = new AppointmentRepo();
        Coordinator coordinator = new Coordinator();
        public ConfirmAppointment()
        {
            InitializeComponent();
        }

        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = appointmentRepo.GetHospitalId(coordinator);
            appointment.hospitalId = h.hospitalId;
        }



        private void PopulatedGridView()
        {
            GetHospitaLId();
            this.dgvConfirmAppointment.AutoGenerateColumns = false;
            this.dgvConfirmAppointment.DataSource = appointmentRepo.GetAllConfirmList(appointment);
            this.dgvConfirmAppointment.ClearSelection();
            this.dgvConfirmAppointment.Refresh();
        }

        private void ConfirmAppointment_Load(object sender, EventArgs e)
        {
            PopulatedGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void consultationCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvConfirmAppointment.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            appointment.id = this.dgvConfirmAppointment.CurrentRow.Cells["id"].Value.ToString();


            bool decision = appointmentRepo.DeleteAppointment(appointment);
           
            if (decision )
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
