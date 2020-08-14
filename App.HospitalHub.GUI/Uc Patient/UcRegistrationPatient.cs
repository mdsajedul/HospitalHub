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
using App.HospitalHub.Framework;
using App.HospitalHub.Data;
using System.Data.SqlClient;


namespace App.HospitalHub.GUI
{
	public partial class ucRegistrationPatient : UserControl
	{
	   Patient patient = new Patient();
		private PatientRepo patientRepo { get; set; }
		List<Division> divisions = new List<Division>();
		List<District> districts = new List<District>();
	
		




		public ucRegistrationPatient()
		{
			InitializeComponent();
			this.patientRepo = new PatientRepo();
		   
		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{

		}

		private void ucRegistrationPatient_Load(object sender, EventArgs e)
		{
		

			ComboBoxView();

			ViewInfo();
		}

		
		private void ComboBoxView()
		{

			SqlConnection conn = new SqlConnection(@"Data Source = Sajedul; Initial Catalog = HospitalHub; User ID = sa; Password =307225");
			conn.Open();

			SqlCommand sql = new SqlCommand("select * from catDivision",conn );
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

			SqlCommand subCat = new SqlCommand("select * from catDistrict",conn);
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
		
			
		
		   private void LoadAutoUsername()
		  {
			  int serial = patientRepo.AutoUsernameValue();
			  patientRepo.Username = (++serial).ToString("d4");
			  this.tbPatientId.Text = patientRepo.Username;
		  }
		  
		private void LoadUsername()
		{
			tbPatientId.Text = Login.username;
		}

		private void FillEntity()
		{
			if (!IsValidToRegistration())
				return;
			
			patient.username = this.tbPatientId.Text;
			patient.password = this.tbPassword.Text;
			patient.firstName = this.tbFirstName.Text;
			patient.lastName = this.tbLastName.Text;
			patient.dob = this.dtpDob.Text;
			patient.phone = this.tbPhone.Text;
			patient.email = this.tbEmail.Text;
			patient.division = this.cbDivision.SelectedItem.ToString();
			patient.district = this.cbDistrict.SelectedItem.ToString();
			if (chbMale.Checked == true)
			{
				patient.sex = this.chbMale.Text;
				this.chbFemale.Checked = false;
				this.chbOther.Checked = false;
			}
			else if (chbFemale.Checked == true)
			{
				patient.sex = this.chbFemale.Text;
				this.chbMale.Checked = false;
				this.chbOther.Checked = false;
			}
			else patient.sex = this.chbOther.Text;
			patient.area = this.tbArea.Text;
			patient.roadNo = this.tbRoad.Text;
			patient.houseNo = this.tbHouse.Text;
		}

		private bool IsValidToRegistration()
		{
			if (Validation.IsStringValid(this.tbPatientId.Text) && Validation.IsStringValid(this.tbPassword.Text) &&
				Validation.IsStringValid(this.tbFirstName.Text) && Validation.IsStringValid(this.tbLastName.Text) &&
				Validation.IsDateTimeValid(this.dtpDob.Text) && Validation.IsStringValid(this.tbPhone.Text) &&
				Validation.IsStringValid(this.tbEmail.Text) && Validation.IsStringValid(this.cbDivision.SelectedItem.ToString()) &&
				Validation.IsStringValid(this.cbDistrict.SelectedItem.ToString())  && Validation.IsStringValid(this.chbMale.Text.ToString()) &&
				Validation.IsStringValid(this.chbFemale.Text.ToString()) && Validation.IsStringValid(this.chbOther.Text.ToString()) &&
				Validation.IsStringValid(this.tbArea.Text) && Validation.IsStringValid(this.tbRoad.Text) &&
				Validation.IsStringValid(this.tbHouse.Text))
			{
				return true;
			}
			else
				return false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.FillEntity();
			bool d = patientRepo.PatientRegistration(patient);
			if (d == true)
			{
				MessageBox.Show("Insert Done");
				this.ClearAll();
			}
			else
				MessageBox.Show("Inser Not done");

			
		}


		public void ClearAll()
		{
			this.tbPatientId.Clear();
			this.tbPassword.Clear();
			this.tbFirstName.Clear();
			this.tbLastName.Clear();
			this.tbPhone.Clear();
			this.tbEmail.Clear();
			this.tbArea.Clear();
			this.tbHouse.Clear();
			this.tbRoad.Clear();
			
			


		}


		public void ViewInfo()
		{
			patient.username = Login.username;
			Patient p = patientRepo.PatientView(patient);
			tbPatientId.Text = p.username;
			tbPassword.Text = p.password;
			tbFirstName.Text = p.firstName;
			tbLastName.Text = p.lastName;
			dtpDob.Text = p.dob;
			tbPhone.Text = p.phone;
			tbEmail.Text = p.email;
			cbDistrict.Text = p.district;
			cbDivision.Text = p.division;
			tbArea.Text = p.area;
			tbHouse.Text = p.houseNo;
			tbRoad.Text = p.roadNo;
			
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

		

		private void chbMale_Click(object sender, EventArgs e)
		{
			if (chbMale.Checked == true)
			{
				chbMale.Checked = true;
				chbFemale.Checked = false;
				chbOther.Checked = false;
			}
		}

		private void chbFemale_Click(object sender, EventArgs e)
		{
			if (chbFemale.Checked == true)
			{
				chbFemale.Checked = true;
				chbMale.Checked = false;
				chbOther.Checked = false;
			}
		}

		private void chbOther_Click(object sender, EventArgs e)
		{
			if (chbOther.Checked == true)
			{
				chbFemale.Checked = false;
				chbMale.Checked = false;
				chbOther.Checked = true;
			}
		}

		

		
	}
}
