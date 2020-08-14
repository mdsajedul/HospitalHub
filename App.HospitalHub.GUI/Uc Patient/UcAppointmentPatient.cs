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


namespace App.HospitalHub.GUI
{
    public partial class UcAppointmentPatient : UserControl
    {
        Appointment appointment = new Appointment();
        AppointmentRepo appointmentRepo = new AppointmentRepo();
        Hospital hospital = new Hospital();
        HospitalRepo hospitalRepo = new HospitalRepo();

        public UcAppointmentPatient()
        {
            InitializeComponent();
        }

        private void PopulatedGridView()
        {
            appointment.patientId = Login.username;
            this.dgvRappointment.AutoGenerateColumns = false;
            this.dgvRappointment.DataSource = appointmentRepo.GetDataByPatient(appointment);
            this.dgvRappointment.Refresh();
            this.dgvRappointment.ClearSelection();
        }

        private void PopulatedGridViewConfirm()
        {
            appointment.patientId = Login.username;
            this.dgvCappointment.AutoGenerateColumns = false;
            this.dgvCappointment.DataSource = appointmentRepo.GetAllConfirmListByPatient(appointment);
            this.dgvCappointment.Refresh();
            this.dgvCappointment.ClearSelection();
        }

        private void UcAppointmentPatient_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
            this.PopulatedGridViewConfirm();
            this.GetMessage();


        }

        private void GetHospitaLId()
        {
            hospital.name = this.dgvRappointment.CurrentRow.Cells["hospitalName"].Value.ToString();
            Hospital h = hospitalRepo.GetHospitalIdbyPatient(hospital);
            hospital.hospitalId = h.hospitalId;
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvRappointment.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            appointment.id = this.dgvRappointment.CurrentRow.Cells["id"].Value.ToString();

            //string rejectMessage = "Your Appointment request has not accepted";
           // appointment.message = rejectMessage;


           // appointment.hospitalId = this.dgvAppointment.CurrentRow.Cells["hospitalId"].Value.ToString();
           // appointment.patientId = this.dgvAppointment.CurrentRow.Cells["patientId"].Value.ToString();

            bool decision = appointmentRepo.RejectAppointment(appointment);
            //bool m = appointmentRepo.SendMessageByCoordinator(appointment);

            if (decision )
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulatedGridView();
            this.PopulatedGridViewConfirm();
        }

        private void GetMessage()
        {
            appointment.patientId = Login.username;
            Appointment a = appointmentRepo.GetMessage(appointment);
            lblmsg.Text = a.message;
        }


        /*
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.dgvCappointment.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            appointment.id = this.dgvCappointment.CurrentRow.Cells["idd"].Value.ToString();

            string rejectMessage = "Appointment request has been cancelled by patient";
            appointment.message = rejectMessage;

            appointment.hospitalId = this.dgvCappointment.CurrentRow.Cells["hospitalId"].Value.ToString();
            appointment.patientId = Login.username;
           
           

            bool decision = appointmentRepo.RejectAppointment(appointment);
            bool m = appointmentRepo.SendMessageByPatient(appointment);

            if (decision && m==true)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }
        */
    }
}
