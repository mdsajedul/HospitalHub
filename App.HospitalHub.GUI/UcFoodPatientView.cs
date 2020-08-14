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
    public partial class UcFoodPatientView : UserControl
    {
        Food food = new Food();
        FoodRepo foodRepo = new FoodRepo();
        public UcFoodPatientView()
        {
            InitializeComponent();
        }



        private void PopulatedGridView()
        {
             food.hospitalId = UcHospitalListView.id;
            this.dgvFood.AutoGenerateColumns = false;
            this.dgvFood.DataSource = foodRepo.GetAll(food);
            this.dgvFood.Refresh();
        }

        private void UcFoodPatientView_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
        }
    }
}
