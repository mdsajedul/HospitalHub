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
    public partial class UcServicesAdd : UserControl
    {
        Hospital hospital = new Hospital();
        Coordinator coordinator = new Coordinator();
        Services services = new Services();
        Rating rating = new Rating();
        RatingRepo ratingRepo = new RatingRepo();

        ServicesRepo servicesRepo = new ServicesRepo();
        public UcServicesAdd()
        {
            InitializeComponent();
        }

        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = servicesRepo.GetHospitalId(coordinator);
            hospital.hospitalId = h.hospitalId;
        }

        private void PopulatedGridViewSeat()
        {
            this.GetHospitaLId();
            this.dgvSeat.AutoGenerateColumns = false;
            this.dgvSeat.DataSource = servicesRepo.GetServicesSeat(hospital).ToList();
            this.dgvSeat.Refresh();
        }

        private void PopulatedGridViewTransport()
        {
            this.GetHospitaLId();
            this.dgvTransport.AutoGenerateColumns = false;
            this.dgvTransport.DataSource = servicesRepo.GetServicesTransport(hospital).ToList();
            this.dgvTransport.Refresh();
        }

        private void UcServices_Load(object sender, EventArgs e)
        {
            this.PopulatedGridViewSeat();
            this.PopulatedGridViewTransport();
            this.GetRating();
        }

        private void CLearSeat()
        {
            this.tbSeat.Clear();
            this.tbCost.Clear();
        }
        private void ClearTransport()
        {
            this.tbName.Clear();
            this.tbTransCost.Clear();
        }


        private void FillSeat()
        {
            if (!IsValidSeat())
            {
                return;
            }
            services.seat = tbSeat.Text;
            services.cost = tbCost.Text;

        }

        private void FillTransport()
        {
            if (!IsValidTransport())
            {
                return;
            }
            services.tName = tbName.Text;
            services.transCost = tbTransCost.Text;
        }

        private bool IsValidTransport()
        {
            if (Validation.IsStringValid(this.tbName.Text) && Validation.IsFloatValid(this.tbTransCost.Text))
            {
                return true;
            }
            else
                return false;
        }

        private bool IsValidSeat()
        {
            if (Validation.IsStringValid(this.tbSeat.Text) && Validation.IsFloatValid(this.tbCost.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            this.GetHospitaLId();
            this.FillSeat();
            bool s = servicesRepo.AddSeat(hospital, services);
            if (this.tbSeat.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if(this.tbCost.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if (s == true)
            {
                MessageBox.Show("Insert Done");
                this.CLearSeat();
                this.PopulatedGridViewSeat();
            }
            else
            {
                MessageBox.Show("Insert Not Done");
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            this.GetHospitaLId();
            this.FillTransport();
            bool s = servicesRepo.AddTransport(hospital, services);

            if (this.tbName.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if(this.tbTransCost.Text == "")
            {
                MessageBox.Show("Insert Not Done");
            }
            else if(s == true)
            {
                MessageBox.Show("Insert Done");
                this.ClearTransport();
                this.PopulatedGridViewTransport();
            }
            else
            {
                MessageBox.Show("Insert Not Done");
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(this.dgvSeat.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string seat = this.dgvSeat.CurrentRow.Cells["seat"].Value.ToString();
            bool decision = servicesRepo.DeleteSeat(seat);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridViewSeat();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.dgvTransport.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string name = this.dgvTransport.CurrentRow.Cells["tname"].Value.ToString();
            bool decision = servicesRepo.DeleteTransport(name);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed");
                this.PopulatedGridViewTransport();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        private void dgvSeat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSeat.Text= this.dgvSeat.CurrentRow.Cells["seat"].Value.ToString();
            tbCost.Text= this.dgvSeat.CurrentRow.Cells["cost"].Value.ToString();
        }

        private void dgvTransport_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = this.dgvTransport.CurrentRow.Cells["tname"].Value.ToString();
            tbTransCost.Text = this.dgvTransport.CurrentRow.Cells["transCost"].Value.ToString();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            FormFoodCoordinatorView formFood = new FormFoodCoordinatorView();
            formFood.Show();
        }

        private void GetRating()
        {
            GetHospitaLId();

            rating.hospitalId = hospital.hospitalId;
            Rating r = ratingRepo.GetRatingValue(rating);
            lblRate.Text = r.rating.ToString();
        }

    }
}
