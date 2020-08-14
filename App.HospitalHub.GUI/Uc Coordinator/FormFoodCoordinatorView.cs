using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.HospitalHub.Entity;
using App.HospitalHub.Repo;
using App.HospitalHub.Framework;

namespace App.HospitalHub.GUI
{
    public partial class FormFoodCoordinatorView : Form
    {
        Food food = new Food();
        FoodRepo foodRepo = new FoodRepo();
        Coordinator coordinator = new Coordinator();

        public FormFoodCoordinatorView()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormFoodCoordinatorUpdate fcu = new FormFoodCoordinatorUpdate();
            fcu.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulatedGridView()
        {
            GetHospitaLId();
            this.dgvFood.AutoGenerateColumns = false;
            this.dgvFood.DataSource = foodRepo.GetAll(food);
            this.dgvFood.Refresh();
        }

        public static string foodId;
        private void GetId()
        {
             foodId = this.dgvFood.CurrentRow.Cells["id"].Value.ToString();
        }

        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = foodRepo.GetHospitalId(coordinator);
            food.hospitalId = h.hospitalId;
        }


        private void FormFoodCoordinatorView_Load(object sender, EventArgs e)
        {
            PopulatedGridView();
            GetId();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvFood.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = Convert.ToInt32(dgvFood.CurrentRow.Cells["id"].Value.ToString());
            bool decision = foodRepo.DeleteFood(id);

            if (decision)
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
        }
    }
}
