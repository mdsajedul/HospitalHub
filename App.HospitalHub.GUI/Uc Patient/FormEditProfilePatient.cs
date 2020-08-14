using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using App.HospitalHub.Data;
using App.HospitalHub.Entity;
using App.HospitalHub.Repo;
using App.HospitalHub.Framework;

namespace App.HospitalHub.GUI
{
	public partial class FormEditProfilePatient : Form
	{
		Patient patient = new Patient();
		PatientRepo patientRepo = new PatientRepo();

		List<Division> divisions = new List<Division>();
		List<District> districts = new List<District>();


		public FormEditProfilePatient()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}


		private void FillEntity()
		{
			patient.password = tbPassword.Text;
			patient.firstName = tbFirstName.Text;
			patient.lastName = tbLastname.Text;
			patient.phone = tbPhone.Text;
			patient.email = tbMail.Text;
			patient.dob = dtpdob.Text;
			patient.district = cbDistrict.SelectedItem.ToString();
			patient.division = cbDivision.SelectedItem.ToString();
			patient.area = tbArea.Text;
			patient.houseNo = tbHouse.Text;
			patient.roadNo = tbRoad.Text;
			patient.sex = tbSex.Text;
		}

		public void ViewInfo()
		{
			patient.username = Login.username;
			Patient p = patientRepo.PatientView(patient);
			tbUserid.Text = p.username;
			tbPassword.Text = p.password;
			tbFirstName.Text = p.firstName;
			tbLastname.Text = p.lastName;
			dtpdob.Text = p.dob;
			tbPhone.Text = p.phone;
			tbMail.Text = p.email;
			cbDistrict.Text = p.district;
			cbDivision.Text = p.division;
			tbArea.Text = p.area;
			tbHouse.Text = p.houseNo;
			tbRoad.Text = p.roadNo;
			tbSex.Text = p.sex;
			tbPassword.Text = p.password;

		}

		private void FormEditProfilePatient_Load(object sender, EventArgs e)
		{
			ViewInfo();
			ComboBoxView();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			FillEntity();

			bool b = patientRepo.PatientUpdate(patient);
			if (b == true)
			{
				MessageBox.Show("Update done");
				UcPatientProfile ucPatientProfile = new UcPatientProfile();
				ucPatientProfile.Refresh();
			}
			else
			{
				MessageBox.Show("Update failed");
			}
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
	}


	}
