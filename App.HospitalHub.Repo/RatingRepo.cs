using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using App.HospitalHub.Entity;
using App.HospitalHub.Data;


namespace App.HospitalHub.Repo
{
    public class RatingRepo
    {
        Hospital hospital = new Hospital();





        public bool SetRating(Rating rating)
        {
            try
            {
                string query = "select * from rating where patientId ='" + rating.patientId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = " insert into rating(hospitalId, rating, patientId) values('" + rating.hospitalId + "', '" + rating.rating + "', '" + rating.patientId + "')";
                }
                else
                {
                    query = " Update rating set   rating = '" + rating.rating + "' , hospitalId = '" + rating.hospitalId + "'  where patientId ='" + rating.patientId + "' ";
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



        public Rating GetRatingValue(Rating r)
        {
            try
            {
                string query = "SELECT AVG(rating) FROM rating WHERE hospitalId = '"+r.hospitalId+"' ";
                var dt = DataAccess.GetDataSet(query);

                r.rating =Convert.ToInt32(dt.Tables[0].Rows[0][0].ToString());

                return r;
            }
            catch (Exception exc)
            {
               
                return r;
            }
        }





    }



}
