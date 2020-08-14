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
    public class LoginRepo
    {
        
       
        public Boolean  LoginAdmin(AdminLogin adminLogin)
        {

            try
            {

                string query = "select * from admin where username = '" + adminLogin.username + "' and password = '" + adminLogin.password + "';";
                var dt = DataAccess.GetDataTable(query);

               if (dt.DataSet.Tables[0].Rows.Count == 1)
                {
                    return true;
                }
                else
                    return false;

            }
            catch(Exception exception)
            {
                return false;
            }

        }
    }
}
