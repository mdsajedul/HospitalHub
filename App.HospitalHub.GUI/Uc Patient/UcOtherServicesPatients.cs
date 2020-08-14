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
    public partial class UcOtherServicesPatients : UserControl
    {
        Services services = new Services();
        ServicesRepo servicesRepo = new ServicesRepo();

        public UcOtherServicesPatients()
        {
            InitializeComponent();
        }


        string hospitalId = UcHospitalListView.id;

        private void PopulatedGridViewSeat()
        {
           
            this.dgvSeat.AutoGenerateColumns = false;
            this.dgvSeat.DataSource = servicesRepo.GetSeat(hospitalId).ToList();
            this.dgvSeat.Refresh();
        }

        private void PopulatedGridViewTransport()
        {
            
            this.dgvTransport.AutoGenerateColumns = false;
            this.dgvTransport.DataSource = servicesRepo.GetTransport(hospitalId).ToList();
            this.dgvTransport.Refresh();
        }

        private void GetAll()
        {
            servicesRepo.GetSeat(hospitalId);
            servicesRepo.GetTransport(hospitalId);
        }

        private void UcOtherServicesPatients_Load(object sender, EventArgs e)
        {
            this.GetAll();
            this.PopulatedGridViewSeat();
            this.PopulatedGridViewTransport();
        }
    }
}
