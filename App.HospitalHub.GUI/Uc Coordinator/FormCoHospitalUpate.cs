using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.HospitalHub.Data;
using App.HospitalHub.Entity;
using App.HospitalHub.Framework;
using System.Data.SqlClient;
using App.HospitalHub.Repo;

namespace App.HospitalHub.GUI
{
    public partial class FormCoHospitalUpate : Form
    {

        Hospital hospital = new Hospital();
        CurrentUserValue currentUser = new CurrentUserValue();
        private HospitalRepo hospitalRepo { get; set; }
        List<Division> divisions = new List<Division>();
        List<District> districts = new List<District>();
        public FormCoHospitalUpate()
        {
            InitializeComponent();
            this.hospitalRepo = new HospitalRepo();
        }


		private void ComboBoxView()
		{

			SqlConnection conn = new SqlConnection(@"Data Source = Sajedul; Initial Catalog = HospitalHub; User ID = sa; Password =307225");
			conn.Open();

			SqlCommand sql = new SqlCommand("select * from catDivision", conn);
			SqlDataReader dr = sql.ExecuteReader();

			while (dr.Read())
			{
				cbDivision.Items.Add(dr["divName"]);
				divisions.Add(new Division()
				{
					divId = ((int)dr["divId"]),
					divName = dr["divName"] as string
				});
			}

			conn.Close();


			conn.Open();

			SqlCommand subCat = new SqlCommand("select * from catDistrict", conn);
			SqlDataReader dr1 = subCat.ExecuteReader();

			while (dr1.Read())
			{
				districts.Add(new District()
				{
					disId = ((int)dr1["disId"]),
					disName = dr1["disName"] as string,
					divId = ((int)dr1["divId"])
				});
			}
			conn.Close();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			currentUser.currentUser = Login.username;
			this.FillEntity();

			bool d = hospitalRepo.HospitalDetailsAdd(hospital, currentUser);

			if (this.tbPhone.Text == "")
			{
				MessageBox.Show("Insert Not Done");
			}
			else if (this.tbArea.Text == "")
			{
				MessageBox.Show("Insert Not Done");
			}
			else if (this.tbRoad.Text == "")
			{
				MessageBox.Show("Insert Not Done");
			}
			else if (this.tbHouse.Text == "")
			{
				MessageBox.Show("Insert Not Done");
			}
			else if (d == true)
			{
				MessageBox.Show("Insert Done");
				this.ClearAll();
			}
			else
				MessageBox.Show("Insert Not Done");

		}

		private void ClearAll()
		{

			this.tbPhone.Clear();
			this.tbArea.Clear();
			this.tbHouse.Clear();
			this.tbRoad.Clear();
		}


		private void FillEntity()
		{
			if (!IsValidToSave())
				return;

			hospital.phone = this.tbPhone.Text;
			hospital.division = this.cbDivision.SelectedItem.ToString();
			hospital.district = this.cbDistrict.SelectedItem.ToString();
			hospital.area = this.tbArea.Text;
			hospital.road = this.tbRoad.Text;
			hospital.house = this.tbHouse.Text;
		}

		private bool IsValidToSave()
		{
			if (Validation.IsStringValid(this.tbPhone.Text) && Validation.IsStringValid(this.cbDivision.SelectedItem.ToString()) &&
				Validation.IsStringValid(this.cbDistrict.SelectedItem.ToString()) && Validation.IsStringValid(this.tbArea.Text) &&
				Validation.IsStringValid(this.tbRoad.Text) &&
				Validation.IsStringValid(this.tbHouse.Text))
			{
				return true;
			}
			else
				return false;
		}

		private void FormCoHospitalUpate_Load(object sender, EventArgs e)
		{
			this.ComboBoxView();
		}


		private string[] GetDistrictById(int id)
		{
			return districts.Where(line => line.divId == id).Select(l => l.disName).ToArray();
		}

		private void cbDivision_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbDistrict.Items.Clear();
			int id = divisions[cbDivision.SelectedIndex].divId;
			foreach (string name in GetDistrictById(id))
			{
				this.cbDistrict.Items.Add(name);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			DashboardCoordinator dashboardCoordinator = new DashboardCoordinator();
			dashboardCoordinator.Show();
		}
	}
}
