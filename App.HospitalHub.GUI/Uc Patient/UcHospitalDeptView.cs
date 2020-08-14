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
using System.Data.SqlClient;

namespace App.HospitalHub.GUI
{
    public partial class UcHospitalDeptView : UserControl
    {
        Hospital hospital = new Hospital();
        HospitalRepo hospitalRepo = new HospitalRepo();
        Doctor doctor = new Doctor();
        DoctorRepo doctorRepo = new DoctorRepo();
        Appointment appointment = new Appointment();
        AppointmentRepo appointmentRepo = new AppointmentRepo();
        Patient patient = new Patient();
        PatientRepo patientRepo = new PatientRepo();

        public UcHospitalDeptView()
        {
            InitializeComponent();
            
        }

        private void btnHospitalList_Click(object sender, EventArgs e)
        {
            UcHospitalListView ucHospitalListView = new UcHospitalListView();
            ucHospitalListView.Show();
            ucHospitalListView.BringToFront();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void GetHospitaLId()
        {
            hospital.hospitalId = UcHospitalListView.id;
        }

        private void ViewAll()
        {
            hospital.hospitalId = UcHospitalListView.id;
           
        }
        string hospitalId = UcHospitalListView.id;

        private void Combobox()
        {
            this.GetHospitaLId();
           

            SqlConnection conn = new SqlConnection(@"Data Source = Sajedul; Initial Catalog = HospitalHub; User ID = sa; Password =307225");
            conn.Open();

            SqlCommand sql = new SqlCommand("select * from department where hospitalId = '" + hospitalId + "'", conn);
            SqlDataReader dr = sql.ExecuteReader();

            while (dr.Read())
            {
                cbDepartment.Items.Add(dr["name"].ToString());
            }

            conn.Close();
        }

        private void UcHospitalDeptView_Load(object sender, EventArgs e)
        {
            Combobox();
          
            PopulatedGridView();
        }

        /*
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            hospital.department = cbDepartment.Text;
            doctorRepo.SearchDoctorList(hospital);
            this.PopulatedGridView();
        }

    */

        private void PopulatedGridView()
        {
            this.dgvDoctor.AutoGenerateColumns = false;
            this.dgvDoctor.DataSource = doctorRepo.SearchDoctorList(hospital);
            this.dgvDoctor.ClearSelection();
            this.dgvDoctor.Refresh();
        }

        private void cbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            hospital.department = cbDepartment.Text;
            doctorRepo.SearchDoctorList(hospital);
            this.PopulatedGridView();
        }

        private void dgvDoctor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbDoctorname.Text = this.dgvDoctor.CurrentRow.Cells["name"].Value.ToString();
            this.tbDepartment.Text = this.dgvDoctor.CurrentRow.Cells["department"].Value.ToString();
        }

        private void FillEntity()
        {
            GetHospitaLId();
            appointment.doctorName = tbDoctorname.Text;
            appointment.department = tbDepartment.Text;
            appointment.patientId = Login.username;
            appointment.hospitalId = hospital.hospitalId;
            hospital.hospitalId= hospital.hospitalId;
            Hospital h = hospitalRepo.ViewInfo(hospital);
            appointment.hospitalName = h.name;

            patient.username = Login.username;

            Patient p = patientRepo.PatientView(patient);

            appointment.patientName = p.firstName;
            appointment.patientPhone = p.phone;
            appointment.district = p.district;
            appointment.division = p.division;
            appointment.patientEmail = p.email;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FillEntity();
            bool b = appointmentRepo.MakeAppointment(appointment);
            if (tbDoctorname.Text == "")
            {
                MessageBox.Show("Doctor name missing!");
            }
            else if (tbDepartment.Text == "")
            {
                MessageBox.Show("Department name missing!");
            }
            else if (b == true)
            {
                MessageBox.Show("Appointment Confirmed");
            }
            else
            {
                MessageBox.Show("Appointment Failed");
            }
        }
    }
}
