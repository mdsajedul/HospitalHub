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

namespace App.HospitalHub.GUI
{
    public partial class UcDiagnosisAdd : UserControl
    {
        Hospital hospital = new Hospital();
        Diagnosis diagnosis = new Diagnosis();
        Coordinator coordinator = new Coordinator();

        DiagnosisRepo diagnosisRepo = new DiagnosisRepo();
        public UcDiagnosisAdd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = diagnosisRepo.GetHospitalId(coordinator);
            hospital.hospitalId = h.hospitalId;
        }



        private void UcDiagnosisAdd_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
        }


        private void Clear()
        {
            this.tbName.Clear();
            this.tbCost.Clear();
        }

        private void FillEntity()
        {
            if (!IsValidDiagnosis())
            {
                return;
            }
            diagnosis.name = tbName.Text;
            diagnosis.cost = tbCost.Text;
        }

        private bool IsValidDiagnosis()
        {
            if (Validation.IsStringValid(this.tbName.Text) && Validation.IsFloatValid(tbCost.Text))
            {
                return true;
            }
            else
                return false;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.GetHospitaLId();
            this.FillEntity();
            bool d = diagnosisRepo.AddDiagnosis(hospital, diagnosis);

            if (this.tbName.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if (this.tbCost.Text == "")
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
            {
                MessageBox.Show("Insert Not Done");
                MessageBox.Show(diagnosisRepo.textE);
            }
        }


        private void PopulatedGridView()
        {
            this.GetHospitaLId();
            this.dgvDiagnosis.AutoGenerateColumns = false;
            this.dgvDiagnosis.DataSource = diagnosisRepo.GetDiagnosis(hospital).ToList();
            this.dgvDiagnosis.Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvDiagnosis.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string name = this.dgvDiagnosis.CurrentRow.Cells["name"].Value.ToString();
            bool decision = diagnosisRepo.DeleteDiagnosis(name);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        private void dgvDiagnosis_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = this.dgvDiagnosis.CurrentRow.Cells["name"].Value.ToString();
            tbCost.Text = this.dgvDiagnosis.CurrentRow.Cells["cost"].Value.ToString();
        }
    }
}
