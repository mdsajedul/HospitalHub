using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using App.HospitalHub.Data;
using App.HospitalHub.Entity;


namespace App.HospitalHub.Repo
{
     public class PatientRepo
      {
        Patient patientNew = new Patient();

        private string id;
        public string Id
        {
            get { return id; }
            set { this.id = "p-" + value;  }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { this.username = "p-" + value; } //p-1001
        }



        public List<Patient> GetAll()
        {
            var patientList = new List<Patient>();
            var sql = "select * from patient";
            var dt = DataAccess.GetDataTable(sql);

            for(int index =0;index< dt.Rows.Count; index++)
            {
                Patient p = ConvertToEntity(dt.Rows[index]);
                patientList.Add(p);
            }
            return patientList;
            
        }


        public List<Patient> SearchPatient(Patient patient)
        {
            var patientList = new List<Patient>();
            var sql = "select * from patient where division like '%" + patient.division + "%' or district like '%"+patient.district+"%' ";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Patient p = ConvertToEntity(dt.Rows[index]);
                patientList.Add(p);
            }
            return patientList;

        }


        public string name;
        public void View(string id)
        {
            string query = "select * from patient where username = '" + id + "'";
            DataTable dt = DataAccess.GetDataTable(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                name = row["firstName"].ToString();

            }
          
        }


        public List<Patient> Serach()
        {
            var patientList = new List<Patient>();
            var sql = "select * from patient where division like '" + patient.division + "'";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Patient p = ConvertToEntity(dt.Rows[index]);
                patientList.Add(p);
            }
            return patientList;

        }

      

        public bool PatientRegistration(Patient patient)
        {
            try
            {
                string query = "select * from patient where username ='" + patient.username + "'";
                var dt = DataAccess.GetDataTable(query);

                if(dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into patient values ('" + patient.username + "','" + patient.password + "', '" + patient.firstName + "','" + patient.lastName + "', '" + patient.dob + "','" + patient.phone + "','" + patient.email + "','" + patient.division + "','" + patient.district + "','" + patient.sex + "','" + patient.area + "','" + patient.roadNo + "','" + patient.houseNo + "') ";
                }
                          

                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception exception)
            {
                //MessageBox.Show(Console.WriteLine(exception));
                return false;
            }
        }

       
        public bool PatientUpdate(Patient patient)
        {
            try
            {
                string query =" update patient set password = '"+patient.password+"', firstName = '"+patient.firstName+"', lastName = '"+patient.lastName+"', dob = '"+patient.dob+"',phone = '"+patient.phone+"', email = '"+patient.email+"', division = '"+patient.division+"', district = '"+patient.district+"', sex = '"+patient.sex+"', area = '"+patient.area+"', road = '"+patient.roadNo+"', house = '"+patient.houseNo+"' where username = '"+patient.username+"'";


                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch(Exception exc)
            {
                return false;
            }
        }



        public bool PatientLogin(Patient p)
        {
            try
            {
                string query = "select * from patient where username = '" + p.username + "' and password = '" + p.password + "';";
                var dt = DataAccess.GetDataTable(query);

                if (dt.DataSet.Tables[0].Rows.Count == 1)
                {
                    return true;
                }
                else
                    return false;

            }
            catch(Exception ex)
            {
                //MessageBox.Show(Console.WriteLine(ex));
                return false;
            }
            
        }
        





        public bool Delete(string id)
        {
            string query = "select * from patient where username = '" + id + "'";
            var dt = DataAccess.GetDataTable(query);

            if(dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            query = "delete from patient where username = '" + id + "'";
            int count = DataAccess.ExecuteUpdateQuery(query);

            if (count == 1)
            {
                return true;
            }
            else
                return false;

        }







       Patient patient = new Patient();
        public string exception;
        public Patient  PatientView(Patient p)
        {
            try
            {

                string query = "select* from patient where username = '"+p.username+"' ";
                var dt = DataAccess.GetDataSet(query);

                patient.username= dt.Tables[0].Rows[0][1].ToString();
                patient.firstName = dt.Tables[0].Rows[0][3].ToString();
                patient.lastName= dt.Tables[0].Rows[0][4].ToString();
                patient.dob= dt.Tables[0].Rows[0][5].ToString();
                patient.phone= dt.Tables[0].Rows[0][6].ToString();
                patient.email= dt.Tables[0].Rows[0][7].ToString();
                patient.division= dt.Tables[0].Rows[0][8].ToString();
                patient.district= dt.Tables[0].Rows[0][9].ToString();
                patient.sex= dt.Tables[0].Rows[0][10].ToString();
                patient.area= dt.Tables[0].Rows[0][11].ToString();
                patient.roadNo= dt.Tables[0].Rows[0][12].ToString();
                patient.houseNo= dt.Tables[0].Rows[0][13].ToString();



                return patient;
            }
            catch(Exception exc)
            {
                exception = exc.ToString();
                return p;
            }
        }


        public bool ProfileDelete(Patient patient)
        {
            try
            {
                string query = "delete from patient where username = '" + patient.username + "' ";
           
                int count = DataAccess.ExecuteUpdateQuery(query);
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception exc)
            {
                return false;
            }
        }
     



       public int AutoUsernameValue()
        {
            var dt = DataAccess.GetDataTable("select * from patient");
            string value = dt.Rows[dt.Rows.Count -1]["username"].ToString();
            string[] id = value.Split('-');
            int number = Convert.ToInt32(id[1]);
            return number;
        }
        




        public Patient ConvertToEntity(DataRow row)
        {
            if(row == null)
            {
                return null;
            }
            var p = new Patient();
            p.id = Convert.ToInt32(row["id"].ToString());
            p.username = row["username"].ToString();
            p.password = row["password"].ToString();
            p.firstName = row["firstName"].ToString();
            p.lastName = row["lastName"].ToString();
            p.dob = row["dob"].ToString();
            p.phone = row["phone"].ToString();
            p.email = row["email"].ToString();
            p.division = row["division"].ToString();
            p.district = row["district"].ToString();
            p.sex = row["sex"].ToString();
            p.area = row["area"].ToString();
            p.roadNo = row["road"].ToString();
            p.houseNo = row["house"].ToString();
            return p;

        }
      

    
    }
}
