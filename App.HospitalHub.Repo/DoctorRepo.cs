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
    public class DoctorRepo
    {

        public List<Doctor> GetAll(Doctor doctor)
        {
            var doctorList = new List<Doctor>();
            var sql = "select * from doctor where department ='"+doctor.department+"' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Doctor d = ConvertToEntity(dt.Rows[index]);
                doctorList.Add(d);
            }
            return doctorList;
        }


        public List<Doctor> SearchDoctorList(Hospital hospital)
        {
            var doctorList = new List<Doctor>();
            var sql = "select * from doctor where department = '"+hospital.department+"' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Doctor d = ConvertToEntity(dt.Rows[index]);
                doctorList.Add(d);
            }
            return doctorList;
        }


        public bool DoctorAdd(Doctor doctor)
        {
            try
            {
                string query = "select * from doctor where name ='" + doctor.name + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query =" insert into doctor(name, fee, phone, department, email) values('"+doctor.name+"', '"+doctor.fee+"', '"+doctor.phone+"', '"+doctor.department+"', '"+doctor.email+"')";
                }
                else
                {
                    query = " Update doctor set   fee = '" + doctor.fee + "' , phone = '" + doctor.phone + "' ,department = '" + doctor.department + "' , email = '" + doctor.email + "' where name ='"+doctor.name+"' ";
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
            catch (Exception exception)
            {
                //MessageBox.Show(Console.WriteLine(exception));
                return false;
            }
        }


        public bool DeleteDoctor(string name)
        {
            string query = " select * from doctor where name ='" + name + "' ";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }


            query = "delete from doctor where name ='" + name + "' ";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }



        private Doctor ConvertToEntity(DataRow row)
        {
            if(row == null)
            {
                return null;
            }
            var d = new Doctor();
            //d.id = Convert.ToInt32(row["id"].ToString());
            d.id = Convert.ToInt32(row["id"]).ToString();
            d.name = row["name"].ToString();
            d.phone = row["phone"].ToString();
            d.email = row["email"].ToString();
            d.fee = row["fee"].ToString();
            d.department = row["department"].ToString();
            return d;

        }
        

        
    }
}
