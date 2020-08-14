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
    public partial class UcViewHospitalBasicInfo : UserControl
    {
        Coordinator coordinator = new Coordinator();
        CoordinatorRepo coordinatorRepo = new CoordinatorRepo();
        Hospital hospital = new Hospital();
        HospitalRepo hospitalRepo = new HospitalRepo();

        public UcViewHospitalBasicInfo()
        {
            InitializeComponent();
        }

        public void GetHospitaLId()
        {
            coordinator.username = Login.username;
            Hospital h = hospitalRepo.GetHospitalId(coordinator);
            hospital.hospitalId = h.hospitalId;
        }


        private void GetAll()
        {
            GetHospitaLId();
            Hospital h = hospitalRepo.ViewInfo(hospital);
            lblName.Text = h.name;
            lblPhone.Text = h.phone;
            lblDivision.Text = h.division;
            lblDistrict.Text = h.district;
            lblArea.Text = h.area;
            lblRoad.Text = h.road;
            lblHouse.Text = h.house;
        }

        private void UcViewHospitalBasicInfo_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormCoHospitalUpate formCoHospitalUpate = new FormCoHospitalUpate();
            formCoHospitalUpate.Show();
            this.Hide();
        }
    }
}
