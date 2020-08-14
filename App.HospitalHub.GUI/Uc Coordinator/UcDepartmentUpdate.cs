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
    public partial class UcDepartmentUpdate : UserControl
    {
        Hospital hospital = new Hospital();

        HospitalRepo hospitalRepo = new HospitalRepo();
        Coordinator coordinator = new Coordinator();
        public UcDepartmentUpdate()
        {
            InitializeComponent();
        }



        private void FillEntity()
        {
            if (!IsValidDepartments())
                return;
            hospital.department = this.tbDepartment.Text;

        }

        private bool IsValidDepartments()
        {
            if (Validation.IsStringValid(this.tbDepartment.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void Clear()
        {
            this.tbDepartment.Clear();
        }

        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
           Hospital h= hospitalRepo.GetHospitalId(coordinator);
            hospital.hospitalId = h.hospitalId;
        }

       
        




        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.GetHospitaLId();
            //coordinator.username = Login.username;
            this.FillEntity();
            bool b = hospitalRepo.AddDepartment(hospital);
          
            if (this.tbDepartment.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if(b== true )
            {
                MessageBox.Show("Insert Done");
                this.Clear();
                this.PopulatedGridView();
            }
            else
            {
                MessageBox.Show("Insert Not Done");
            }
        }

        private void PopulatedGridView()
        {
            this.GetHospitaLId();
            this.dgvDepartment.AutoGenerateColumns = false;
            this.dgvDepartment.DataSource = hospitalRepo.GetDepartment(hospital).ToList();
            this.dgvDepartment.ClearSelection();
            this.dgvDepartment.Refresh();
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UcDepartmentUpdate_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvDepartment.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string name = this.dgvDepartment.CurrentRow.Cells["department"].Value.ToString();
            bool decision = hospitalRepo.DeleteDepartment(name);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }
    }
}
