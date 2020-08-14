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
    public partial class UcRatingPatient : UserControl
    {
        Rating rating = new Rating();
        RatingRepo ratingRepo=new RatingRepo();
        public UcRatingPatient()
        {
            InitializeComponent();
        }

        string hospitalId = UcHospitalListView.id;

        int rateing = 0;

        private void rate1_Click(object sender, EventArgs e)
        {
            rateing = 1;
            rate1.BackColor = Color.Gold;
            rate2.BackColor = Color.DimGray;
            rate3.BackColor = Color.DimGray;
            rate4.BackColor = Color.DimGray;
            rate5.BackColor = Color.DimGray;

            rating.hospitalId = hospitalId;
            rating.rating = rateing;
            rating.patientId = Login.username;

            bool b = ratingRepo.SetRating(rating);
            if(b==true)
            {
                MessageBox.Show("Submited");
                this.GetRating();
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void GetRating()
        {
            rating.hospitalId = hospitalId;
            Rating r = ratingRepo.GetRatingValue(rating);
            lblRating.Text = r.rating.ToString();
        }

        private void UcRatingPatient_Load(object sender, EventArgs e)
        {
            this.GetRating();
        }

        private void rate2_Click_1(object sender, EventArgs e)
        {
            rateing = 2;
            rate1.BackColor = Color.Gold;
            rate2.BackColor = Color.Gold;
            rate3.BackColor = Color.DimGray;
            rate4.BackColor = Color.DimGray;
            rate5.BackColor = Color.DimGray;

            rating.hospitalId = hospitalId;
            rating.rating = rateing;
            rating.patientId = Login.username;


            bool b = ratingRepo.SetRating(rating);
            if (b == true)
            {
                MessageBox.Show("Submited");
                this.GetRating();
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void rate3_Click_1(object sender, EventArgs e)
        {
            rateing = 3;
            rate1.BackColor = Color.Gold;
            rate2.BackColor = Color.Gold;
            rate3.BackColor = Color.Gold;
            rate4.BackColor = Color.DimGray;
            rate5.BackColor = Color.DimGray;

            rating.hospitalId = hospitalId;
            rating.rating = rateing;
            rating.patientId = Login.username;


            bool b = ratingRepo.SetRating(rating);
            if (b == true)
            {
                MessageBox.Show("Submited");
                this.GetRating();
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void rate4_Click_1(object sender, EventArgs e)
        {
            rateing = 4;
            rate1.BackColor = Color.Gold;
            rate2.BackColor = Color.Gold;
            rate3.BackColor = Color.Gold;
            rate4.BackColor = Color.Gold;
            rate5.BackColor = Color.DimGray;

            rating.hospitalId = hospitalId;
            rating.rating = rateing;
            rating.patientId = Login.username;


            bool b = ratingRepo.SetRating(rating);
            if (b == true)
            {
                MessageBox.Show("Submited");
                this.GetRating();
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void rate5_Click_1(object sender, EventArgs e)
        {
            rateing = 5;
            rate1.BackColor = Color.Gold;
            rate2.BackColor = Color.Gold;
            rate3.BackColor = Color.Gold;
            rate4.BackColor = Color.Gold;
            rate5.BackColor = Color.Gold;

            rating.hospitalId = hospitalId;
            rating.rating = rateing;
            rating.patientId = Login.username;


            bool b = ratingRepo.SetRating(rating);
            if (b == true)
            {
                MessageBox.Show("Submited");
                this.GetRating();
            }
            else
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void FIllEntity()
        {
            rating.hospitalId = hospitalId;
            rating.rating = rateing;
            rating.patientId = Login.username;
        }


    }
}
