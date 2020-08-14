using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.HospitalHub.Framework;
using App.HospitalHub.Repo;
using App.HospitalHub.Entity;

namespace App.HospitalHub.GUI
{
    public partial class FormFoodCoordinatorUpdate : Form
    {
        Food food = new Food();
        FoodRepo foodRepo = new FoodRepo();
        Hospital hospital = new Hospital();
        Coordinator coordinator = new Coordinator();
        public FormFoodCoordinatorUpdate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = foodRepo.GetHospitalId(coordinator);
            food.hospitalId = h.hospitalId;
        }

        private void FillEntity()
        {
            food.breakfast = txtBreakfast.Text;
            food.lunch = txtLunch.Text;
            food.snacks = txtSnacks.Text;
            food.dinner = txtDinner.Text;
            food.id = Convert.ToInt32(FormFoodCoordinatorView.foodId);
            GetHospitaLId();
        }

        private void Clear()
        {
            txtBreakfast.Clear();
            txtDinner.Clear();
            txtLunch.Clear();
            txtSnacks.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FillEntity();
            bool b = foodRepo.AddFood(food);
            if (b == true)
            {
                MessageBox.Show("Foods Added");
                this.Clear();
            }
            else
            {
                MessageBox.Show("An Error Occurred!");
            }
        }
    }
}
