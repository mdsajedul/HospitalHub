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
    
    public class FoodRepo
    {
        public DataTable GetAll(Food food)
        {
                string query = "select * from food where hospitalId = '" + food.hospitalId + "'";
                var dt = DataAccess.GetDataTable(query);
                return dt;

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


        public bool AddFood(Food food)
        {
            try
            {
               

                
                
               string query = " insert into food(breakfast, lunch, snacks, hospitalId, dinner) values('" + food.breakfast + "', '" + food.lunch + "', '" + food.snacks + "', '" + food.hospitalId + "', '" + food.dinner + "')";
                
               
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



        public bool DeleteFood(int id)
        {
           
            string query = "delete from food where id ='" + id + "' ";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }



    }
}
