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
     public class DiagnosisRepo
    {

        public List<Diagnosis> GetDiagnosis(Hospital s)
        {
            var diagnosisList = new List<Diagnosis>();
            var sql = "select * from diagnosis where hospitalId = '" + s.hospitalId + "' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Diagnosis d = ConvertIntoEntity(dt.Rows[index]);
                diagnosisList.Add(d);
            }
            return diagnosisList;
        }

        public List<Diagnosis> GetAll(string hospitalId)
        {
            var diagnosisList = new List<Diagnosis>();
            var sql = "select * from diagnosis where hospitalId = '" + hospitalId + "' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Diagnosis d = ConvertIntoEntity(dt.Rows[index]);
                diagnosisList.Add(d);
            }
            return diagnosisList;
        }



        Hospital hospital = new Hospital();
        public Hospital GetHospitalId(Coordinator c)
        {
            try
            {
                string query = "select hospitalId from coorHospital where username = '" + c.username + "'";
                var dt = DataAccess.GetDataSet(query);
                hospital.hospitalId = dt.Tables[0].Rows[0][0].ToString();
                return hospital;
            }
            catch (Exception exc)
            {
                return hospital;
            }

        }

        /*
        
    */
        public string textE;
        public bool AddDiagnosis(Hospital hospital,Diagnosis diagnosis)
        {
            try
            {
                
                string query = "select * from diagnosis where name ='" + diagnosis.name + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "insert into diagnosis(name, cost, hospitalId) values('" + diagnosis.name + "', '" + diagnosis.cost + "', '" + hospital.hospitalId + "') ";
                }
                else
                {
                    query = "Update diagnosis set cost = '" + diagnosis.cost + "' where name = '"+diagnosis.name+"' ";
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
                textE = exception.ToString();
                return false;
            }
        }



        public bool DeleteDiagnosis(string name)
        {
            string query = " select * from diagnosis where name ='" + name + "' ";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }


            query = "delete from diagnosis where name ='" + name + "' ";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }



        private Diagnosis ConvertIntoEntity(DataRow row)
            {
                if (row == null)
                {
                    return null;
                }
                var d = new Diagnosis();
                d.id = Convert.ToInt32(row["id"].ToString());
                d.name = row["name"].ToString();
                d.cost = row["cost"].ToString();
                d.hospitalId = row["hospitalId"].ToString();
                return d;

            }
     }
}
