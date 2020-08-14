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
    public partial class UcDiagnosisViewPatient : UserControl
    {
        Diagnosis diagnosis = new Diagnosis();
        DiagnosisRepo diagnosisRepo = new DiagnosisRepo();

        public UcDiagnosisViewPatient()
        {
            InitializeComponent();
        }


       string hospitalId = UcHospitalListView.id;

        private void GetData()
        {
            // string hospitalId = UcHospitalListView.id;
           // diagnosis.hospitalId = UcHospitalListView.id;
            diagnosisRepo.GetAll(hospitalId);
        }

        private void PopulatedGridView()
        {
            this.dgvDiagnosis.AutoGenerateColumns = false;
            this.dgvDiagnosis.DataSource = diagnosisRepo.GetAll(hospitalId);
            this.dgvDiagnosis.ClearSelection();
            this.dgvDiagnosis.Refresh();
        }


        private void UcDiagnosisViewPatient_Load(object sender, EventArgs e)
        {
            this.GetData();
            this.PopulatedGridView();

        }
    }
}
