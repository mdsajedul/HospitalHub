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
    public partial class ucPatientLists : UserControl
    {
        private PatientRepo patientRepo { get; set; }
        Patient patient = new Patient();


        public ucPatientLists()
        {
            InitializeComponent();
            this.patientRepo = new PatientRepo();
        }

        private void PopulatedGridView()
        {
            this.dgvPatientList.AutoGenerateColumns = false;
           this.dgvPatientList.DataSource = patientRepo.GetAll().ToList();
            this.dgvPatientList.ClearSelection();
            this.dgvPatientList.Refresh();
        }



        private void PopulatedGridViewSearch()
        {
            this.dgvPatientList.AutoGenerateColumns = false;
            this.dgvPatientList.DataSource = patientRepo.Serach().ToList();
            this.dgvPatientList.ClearSelection();
            this.dgvPatientList.Refresh();
        }



        private void PatientLists_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
            string v = Login.username.ToUpper();
            lblname.Text = v;
          
           // this.PopulatedGridViewSearch();
        }

        

       

       

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvPatientList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure? ", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string username = this.dgvPatientList.CurrentRow.Cells["username"].Value.ToString();
            bool decision = patientRepo.Delete(username);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed.");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            patient.division = textBox1.Text;
            patient.district = textBox1.Text;
            patientRepo.SearchPatient(patient);
            dgvPatientList.DataSource = patientRepo.SearchPatient(patient);

        }
    }
}
