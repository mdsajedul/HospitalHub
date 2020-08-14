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
    public class ServicesRepo
    {

        //Hospital Seat.......

        public List<Services> GetServicesSeat(Hospital s)
        {
            var servicesList = new List<Services>();
            var sql = "select * from bed where hospitalId = '" + s.hospitalId + "' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Services services = ConvertIntoSeat(dt.Rows[index]);
                servicesList.Add(services);
            }
            return servicesList;

        }


        public List<Services> GetSeat(string hospitalId)
        {
            var servicesList = new List<Services>();
            var sql = "select * from bed where hospitalId = '" + hospitalId + "' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Services services = ConvertIntoSeat(dt.Rows[index]);
                servicesList.Add(services);
            }
            return servicesList;

        }

        private Services ConvertIntoSeat(DataRow row)
        {
            if(row == null)
            {
                return null;
            }
            var s = new Services();
            s.seat = row["count"].ToString();
            s.cost = row["cost"].ToString();
            return s;
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

        public string textE;
        public bool AddSeat(Hospital hospital, Services services)
        {
            try
            {

                string query = "select * from bed where count ='" + services.seat + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "insert into bed (count,cost,hospitalId) values ('" + services.seat + "','" + services.cost + "','" + hospital.hospitalId + "')";
                }
                else
                {
                    query = " Update bed set   cost = '" + services.cost + "' where count = '"+services.seat+"' ";
                }



               // string query = "insert into bed (count,cost,hospitalId) values ('"+services.seat+"','"+services.cost+"','"+hospital.hospitalId+"')";
          
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

        public bool DeleteSeat(string id)
        {
            string query = " select * from bed where count ='" + id + "' ";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }


            query = "delete from bed where count = '" + id + "'";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }
       
        public bool DeleteTransport(string name)
        {
            string query = " select * from transportation where name ='" + name + "' ";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }


            query = "delete from transportation where name ='" + name + "' ";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }


        //Transportation....



        public List<Services> GetServicesTransport(Hospital s)
        {
            var  transList = new List<Services>();
            var sql = "select * from transportation where hospitalId = '" + s.hospitalId + "' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Services services = ConvertIntoTrans(dt.Rows[index]);
                transList.Add(services);
            }
            return transList;

        }

        public List<Services> GetTransport(string hospitalId)
        {
            var transList = new List<Services>();
            var sql = "select * from transportation where hospitalId = '" + hospitalId + "' ";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Services services = ConvertIntoTrans(dt.Rows[index]);
                transList.Add(services);
            }
            return transList;

        }




        public bool AddTransport(Hospital hospital, Services services)
        {
            try
            {

                string query = "select * from transportation where name ='" + services.tName + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "insert into transportation(name, cost, hospitalId) values('"+services.tName+"', '"+services.transCost+"', '"+hospital.hospitalId+"')";
                }
                else
                {
                    query = "Update transportation set cost = '" + services.transCost + "' where name ='" + services.tName + "'  ";
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





        private Services ConvertIntoTrans(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var s = new Services();
            s.tName = row["name"].ToString();
            s.transCost = row["cost"].ToString();
            return s;
        }

    }
}
