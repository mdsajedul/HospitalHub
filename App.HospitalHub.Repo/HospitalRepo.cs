using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using App.HospitalHub.Data;
using App.HospitalHub.Entity;


namespace App.HospitalHub.Repo
{
  public  class HospitalRepo
    {
        Hospital hospital = new Hospital();
        private string hospitalId;
       
        public string HospitalId
        {
            get { return hospitalId; }
            set { this.hospitalId = "h-" + value; }
        }

        public List<Hospital> GetAll()
        {
            var hospitalList = new List<Hospital>();
            var sql = "select * from hospitalDetails";
            var dt = DataAccess.GetDataTable(sql);
            for(int index = 0; index < dt.Rows.Count; index++)
            {
                Hospital h = ConvertToEntity(dt.Rows[index]);
                hospitalList.Add(h);
            }
            return hospitalList;
        }

        public List<Hospital> SearchHospital(Hospital hospital)
        {
            var hospitalList = new List<Hospital>();
            var sql = "select * from hospitalDetails where name like '%"+hospital.name+"%'";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Hospital h = ConvertToEntity(dt.Rows[index]);
                hospitalList.Add(h);
            }
            return hospitalList;
        }


        public bool HospitalNameAdd(Hospital hospital)
        {
            try
            {
                string query = "select * from hospitalDetails where hospitalId ='" + hospital.hospitalId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                     query = "Insert into hospitalDetails (hospitalId,name) values  ('" + hospital.hospitalId + "','" + hospital.name + " ') ";
                }
                else
                {
                    query = " update hospitalDetails set name = '" + hospital.name + "' where hospitalId = '" + hospital.hospitalId + "' ";
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

        public bool CoordinatorHospitalTable(Coordinator coordinator,Hospital hospital)
        {
            try
            {
                string query = "select * from coorHospital where hospitalId ='" + hospital.hospitalId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into coorHospital (hospitalId,username) values  ('" + hospital.hospitalId + "','" + coordinator.username + " ') ";
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

        public string exec;
        Coordinator coordinator = new Coordinator();


        public string username;
        public string lastname;
        
        public bool HospitalDetailsAdd(Hospital hospital,CurrentUserValue currentUser)
        {
            try
            {
                string query = "update hospitalDetails set phone = '" + hospital.phone + "',division = '" + hospital.division + "',district = '" + hospital.district + "'" +
                ",area = '" + hospital.area + "',road = '" + hospital.road + "', house = '" + hospital.house + "'" +
                " where hospitalId = (select hospitalId from coorHospital where username = '"+currentUser.currentUser+"') ";

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
                return false;
            }
        }


        public Hospital ViewInfo(Hospital h)
        {
            try
            {
                string query = "select* from hospitalDetails  where hospitalId = '" + h.hospitalId + "' ";
                var dt = DataAccess.GetDataSet(query);

                hospital.name = dt.Tables[0].Rows[0][2].ToString();
                hospital.phone = dt.Tables[0].Rows[0][3].ToString();
                hospital.division = dt.Tables[0].Rows[0][4].ToString();
                hospital.district = dt.Tables[0].Rows[0][5].ToString();
                hospital.area = dt.Tables[0].Rows[0][6].ToString(); 
                hospital.road = dt.Tables[0].Rows[0][7].ToString();
                hospital.house = dt.Tables[0].Rows[0][8].ToString();
                return hospital;
            }

            catch(Exception exc)
            {
                return hospital;
            }
        }




      




        public bool Delete(string id)
        {
            string query = "select * from hospitalDetails where hospitalId = '" + id + "'";
            var dt = DataAccess.GetDataTable(query);

            if(dt == null || dt.Rows.Count == 0){
                return false;
            }

            query= "delete from hospitalDetails where hospitalId = '" + id + "'";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
            {
                return true;
            }
            else
                return false;
        }



        //Deapartment..............
        public string exception;
        public Hospital GetHospitalId(Coordinator c)
        {
            try
            {
                string query = "select hospitalId from coorHospital where username = '"+c.username+"'";
                var dt = DataAccess.GetDataSet(query);
                hospital.hospitalId = dt.Tables[0].Rows[0][0].ToString();
                return hospital;
            }
            catch(Exception exc)
            {
                exception = exc.ToString();
                return hospital;
            }
        }

        public Hospital GetHospitalIdbyPatient(Hospital hospital)
        {
            try
            {
                string query = "select hospitalId from hospitalDetails where name = '" + hospital.name + "'";
                var dt = DataAccess.GetDataSet(query);
                hospital.hospitalId = dt.Tables[0].Rows[0][0].ToString();
                return hospital;
            }
            catch (Exception exc)
            {
                exception = exc.ToString();
                return hospital;
            }
        }



        public bool AddDepartment(Hospital hospital)
        {
            try
            {
                string query = "select * from department where name ='" + hospital.department + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "insert into department(name, hospitalId) values('"+hospital.department+"', '"+hospital.hospitalId+"')";
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

        public List<Hospital> GetDepartment(Hospital s)
        {
            var departmentList = new List<Hospital>();
            var sql = "select * from department where hospitalId = '"+s.hospitalId+"' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Hospital h = ConvertDepartment(dt.Rows[index]);
                departmentList.Add(h);
            }
            return departmentList;
        }



        public bool DeleteDepartment(string name)
        {
            string query = " select * from department where name ='" + name + "' ";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }


            query = "delete from department where name ='" + name + "' ";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }




        /*
        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from hospitalDetails;");
            string value = dt.Rows[dt.Rows.Count - 1]["hospitalId"].ToString();

            string[] id = value.Split('-');
            int number = Convert.ToInt32(id[1]);
            return number;
        }

    */
        public Hospital ConvertDepartment(DataRow row)
        {
            if(row == null)
            {
                return null;
            }
            var h = new Hospital();
            h.department = row["name"].ToString();
            return h;
        }
        public Hospital ConvertToEntity(DataRow row)
        {
            if(row == null)
            {
                return null;
            }
            var h = new Hospital();
            h.id = Convert.ToInt32(row["id"].ToString());
            h.hospitalId = row["hospitalId"].ToString();
            h.name = row["name"].ToString();
            h.phone = row["phone"].ToString();
            h.division = row["division"].ToString();
            h.district = row["district"].ToString();
            h.area = row["area"].ToString();
            h.road = row["road"].ToString();
            h.house = row["house"].ToString();
            return h;
        }

    }
}
