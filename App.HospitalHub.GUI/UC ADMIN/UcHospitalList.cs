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
    public partial class UcHospitalList : UserControl
    {
        Hospital hospital = new Hospital();
        private HospitalRepo hospitalRepo { get; set; }
        public UcHospitalList()
        {
            InitializeComponent();
            this.hospitalRepo = new HospitalRepo();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void PopulatedGridView()
        {
            this.dgvHospitalList.AutoGenerateColumns = false;
            this.dgvHospitalList.DataSource = hospitalRepo.GetAll().ToList();
            this.dgvHospitalList.ClearSelection();
            this.dgvHospitalList.Refresh();
        }

        private void UcHospitalList_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
            string v = Login.username.ToUpper();
            lblname.Text = v;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvHospitalList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure? ", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string  id= this.dgvHospitalList.CurrentRow.Cells["hospitalId"].Value.ToString();
            bool decision = hospitalRepo.Delete(id);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed.");
                this.PopulatedGridView();
            }
            else
                MessageBox.Show("Invalid Id");
        }

       

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            hospital.name = tbSearch.Text;
            hospital.district = tbSearch.Text;
            hospital.division = tbSearch.Text;
            hospitalRepo.SearchHospital(hospital);
            dgvHospitalList.DataSource = hospitalRepo.SearchHospital(hospital);
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
