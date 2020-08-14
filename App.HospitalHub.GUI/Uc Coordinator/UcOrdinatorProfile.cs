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

namespace App.HospitalHub.GUI
{
    public partial class UcOrdinatorProfile : UserControl
    {
        Coordinator coordinator = new Coordinator();
        CoordinatorRepo coordinatorRepo = new CoordinatorRepo();
        HospitalRepo hospitalRepo = new HospitalRepo();
        Hospital hospital = new Hospital();
        public UcOrdinatorProfile()
        {
            InitializeComponent();
        }

        private void ViewInfo()
        {
            coordinator.username = Login.username;
            Coordinator c = coordinatorRepo.GetInfo(coordinator);
            lblUsername.Text = c.username;
            lblFirstname.Text = c.firstName;
            lblLastname.Text = c.lastName;
            lblPhone.Text = c.phone;
            lblEmail.Text = c.email;
            
            
        }

        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = hospitalRepo.GetHospitalId(coordinator);
            hospital.hospitalId = h.hospitalId;
        }

        private void ViewHospitalInfo()
        {
            GetHospitaLId();
            Hospital h = hospitalRepo.ViewInfo(hospital);
            lblHospitalId.Text = hospital.hospitalId;
            lblHospitalName.Text = h.name;
        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormOrdinatorProfileEdit formOrdinatorProfileEdit = new FormOrdinatorProfileEdit();
            formOrdinatorProfileEdit.Show();
        }

        private void UcOrdinatorProfile_Load(object sender, EventArgs e)
        {
           // ViewInfo();
           // ViewHospitalInfo();
            GetNameOnBar();
        }

        private void GetNameOnBar()
        {
            string name = Login.username;
            lblname.Text = name.ToUpper();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            coordinator.username = Login.username;
            bool b = coordinatorRepo.DeleteProfile(coordinator);

            if (b==true)
            {
                MessageBox.Show("Delete Confirmed");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Id");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UcOrdinatorProfile ucOrdinatorProfile = new UcOrdinatorProfile();
            ucOrdinatorProfile.Refresh();
            this.panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.ViewInfo();
            this.ViewHospitalInfo();
        }
    }
}
