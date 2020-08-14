using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.HospitalHub.Repo;
using App.HospitalHub.Entity;
using App.HospitalHub.Framework;

namespace App.HospitalHub.GUI
{
    public partial class UcAppoinmentOrdinator : UserControl
    {
        Appointment appointment = new Appointment();
        AppointmentRepo appointmentRepo = new AppointmentRepo();
        Coordinator coordinator = new Coordinator();
        Hospital hospital = new Hospital();
        HospitalRepo hospitalRepo = new HospitalRepo();


        public UcAppoinmentOrdinator()
        {
            InitializeComponent();
        }

        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = appointmentRepo.GetHospitalId(coordinator);
            appointment.hospitalId = h.hospitalId;
            hospital.hospitalId = h.hospitalId;
        }


        private void PopulatedGridView()
        {
            GetHospitaLId();
            this.dgvAppointment.AutoGenerateColumns = false;
            this.dgvAppointment.DataSource = appointmentRepo.GetAll(appointment);
            this.dgvAppointment.ClearSelection();
            this.dgvAppointment.Refresh();
        }

        private void UcAppoinmentOrdinator_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
        }

        private void Fill()
        {
            appointment.hospitalId = this.dgvAppointment.CurrentRow.Cells["hospitalId"].Value.ToString();
            appointment.patientId = this.dgvAppointment.CurrentRow.Cells["patientId"].Value.ToString();
            appointment.patientName = this.dgvAppointment.CurrentRow.Cells["patientName"].Value.ToString();
            appointment.patientPhone = this.dgvAppointment.CurrentRow.Cells["patientPhone"].Value.ToString();
            appointment.patientEmail = this.dgvAppointment.CurrentRow.Cells["patientEmail"].Value.ToString();
            appointment.district = this.dgvAppointment.CurrentRow.Cells["district"].Value.ToString();
            appointment.division = this.dgvAppointment.CurrentRow.Cells["division"].Value.ToString();
            appointment.doctorName = this.dgvAppointment.CurrentRow.Cells["doctorName"].Value.ToString();
            appointment.department = this.dgvAppointment.CurrentRow.Cells["department"].Value.ToString();
            appointment.time = this.dtpTime.Value;
            appointment.date = this.dtpDate.Value;

           GetHospitaLId();
            hospital.hospitalId = hospital.hospitalId;
            Hospital h= hospitalRepo.ViewInfo(hospital);
            appointment.hospitalName = h.name;

            string acceptMessage = "Your appointment has been accepted ";
            appointment.message = acceptMessage;
        }


       



        private void confirmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Fill();
            bool b = appointmentRepo.ConfirmAppointment(appointment);
            bool m= appointmentRepo.SendMessageByCoordinator(appointment);

            appointment.id = this.dgvAppointment.CurrentRow.Cells["id"].Value.ToString();
            bool decision = appointmentRepo.RejectAppointment(appointment);

            if (b == true && m==true && decision )
            {
                MessageBox.Show("Accepted");
                this.PopulatedGridView();
            }
            else
            {
                MessageBox.Show(appointmentRepo.exeption);
            }


        }

        private void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvAppointment.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            appointment.id = this.dgvAppointment.CurrentRow.Cells["id"].Value.ToString();

            string rejectMessage = "Your Appointment request has not accepted";
            appointment.message = rejectMessage;


            appointment.hospitalId = this.dgvAppointment.CurrentRow.Cells["hospitalId"].Value.ToString();
            appointment.patientId = this.dgvAppointment.CurrentRow.Cells["patientId"].Value.ToString();

            bool decision = appointmentRepo.RejectAppointment(appointment);
            bool m = appointmentRepo.SendMessageByCoordinator(appointment);

            if (decision && m== true )
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmList_Click(object sender, EventArgs e)
        {
            ConfirmAppointment confirmAppointment = new ConfirmAppointment();
            confirmAppointment.Show();
        }

      

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            appointment.patientName = tbSearch.Text;
            appointment.district = tbSearch.Text;
            appointment.division = tbSearch.Text;
            appointmentRepo.SearchPatient(appointment);
            dgvAppointment.DataSource = appointmentRepo.SearchPatient(appointment);
        }

        /*
        private void dgvAppointment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConfirmAppointment confirmAppointment = new ConfirmAppointment();
            confirmAppointment.Show();

        }
        */
    }
}
