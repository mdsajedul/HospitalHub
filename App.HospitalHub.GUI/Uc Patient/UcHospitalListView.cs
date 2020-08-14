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
using App.HospitalHub.Repo;
using App.HospitalHub.Data;


namespace App.HospitalHub.GUI
{
    public partial class UcHospitalListView : UserControl
    {
        Hospital hospital = new Hospital();
        public static string id;
        private HospitalRepo hospitalRepo { get; set; }
        public UcHospitalListView()
        {
            InitializeComponent();
            this.hospitalRepo = new HospitalRepo();
        }

        private void PopulatedGridView()
        {
            this.dgvHospitalList.AutoGenerateColumns = false;
            this.dgvHospitalList.DataSource = hospitalRepo.GetAll().ToList();
            this.dgvHospitalList.ClearSelection();
            this.dgvHospitalList.Refresh();
        }

        private void UcHospitalListView_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
        }

        private void dgvHospitalList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            //id = this.dgvHospitalList.CurrentRow.Cells["hospitalId"].Value.ToString();
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvHospitalList.Rows[index];
            id = selectedRow.Cells[0].Value.ToString();

            HospitalInfoViewPatient hospitalInfoView = new HospitalInfoViewPatient();
            hospitalInfoView.Show();

        }

        private void dgvHospitalList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hospital.name = tbSearch.Text;
            hospital.district = tbSearch.Text;
            hospital.division = tbSearch.Text;
             hospitalRepo.SearchHospital(hospital);
            dgvHospitalList.DataSource = hospitalRepo.SearchHospital(hospital);
        }
    }
}
