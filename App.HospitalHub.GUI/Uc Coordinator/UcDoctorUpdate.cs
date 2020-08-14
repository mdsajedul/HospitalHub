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
    public partial class UcDoctorUpdate : UserControl
    {
        Coordinator coordinator = new Coordinator();
        HospitalRepo hospitalRepo = new HospitalRepo();
        Hospital hospital = new Hospital();
        Doctor doctor = new Doctor();
        DoctorRepo doctorRepo = new DoctorRepo();
        public UcDoctorUpdate()
        {
            InitializeComponent();
        }


        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = hospitalRepo.GetHospitalId(coordinator);
            hospital.hospitalId = h.hospitalId;
        }

        private void Combobox()
        {
            this.GetHospitaLId();

            SqlConnection conn = new SqlConnection(@"Data Source = Sajedul; Initial Catalog = HospitalHub; User ID = sa; Password =307225");
            conn.Open();

            SqlCommand sql = new SqlCommand("select * from department where hospitalId = '" + hospital.hospitalId + "'", conn);
            SqlDataReader dr = sql.ExecuteReader();

            while (dr.Read())
            {
                cbDepartment.Items.Add(dr["name"].ToString());
            }

            conn.Close();
        }




        private void UcDoctorUpdate_Load(object sender, EventArgs e)
        {
            this.Combobox();
            this.PopulatedGridView();
        }


        private void PopulatedGridView()
        {
            doctor.department = cbDepartment.Text;
            this.dgvDoctor.AutoGenerateColumns = false;
            this.dgvDoctor.DataSource = doctorRepo.GetAll(doctor).ToList();
            this.dgvDoctor.ClearSelection();
            this.dgvDoctor.Refresh();
        }


        private void FillEntity()
        {
            if (!IsValidToSave())
            {
                return;
            }
            doctor.id = tbId.Text;
            doctor.name = tbDoctor.Text;
            doctor.phone = tbPhone.Text;
            doctor.email = tbEmail.Text;
            doctor.department = cbDepartment.Text;
            doctor.fee = tbFee.Text;
           
        }

        private bool IsValidToSave()
        {
            if(Validation.IsStringValid(this.tbDoctor.Text) && Validation.IsStringValid(this.cbDepartment.SelectedItem.ToString())&&
                Validation.IsStringValid(this.tbPhone.Text) && Validation.IsFloatValid(this.tbFee.Text) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.FillEntity();
            

            bool d = doctorRepo.DoctorAdd(doctor);
            if (this.tbDoctor.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if (this.tbPhone.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if (this.tbEmail.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if (this.tbFee.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }

            else if(d == true)
            {
                MessageBox.Show("Insert Done");
                this.Clear();
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Insert Not Done");
        }


        private void Clear()
        {
            this.tbDoctor.Clear();
            this.tbPhone.Clear();
            this.tbEmail.Clear();
            this.tbFee.Clear();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvDoctor.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string name = this.dgvDoctor.CurrentRow.Cells["name"].Value.ToString();
            bool decision = doctorRepo.DeleteDoctor(name);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDoctor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text=this.dgvDoctor.CurrentRow.Cells["id"].Value.ToString();
            tbDoctor.Text = this.dgvDoctor.CurrentRow.Cells["name"].Value.ToString();
            tbPhone.Text = this.dgvDoctor.CurrentRow.Cells["phone"].Value.ToString();
            tbEmail.Text = this.dgvDoctor.CurrentRow.Cells["email"].Value.ToString();
            cbDepartment.Text = this.dgvDoctor.CurrentRow.Cells["department"].Value.ToString();
            tbFee.Text = this.dgvDoctor.CurrentRow.Cells["fee"].Value.ToString();
        }

        private void cbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            this.PopulatedGridView();
        }
    }
}
