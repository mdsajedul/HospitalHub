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
    public  class CoordinatorRepo
    {
        public bool CoordinatorRegistration(Coordinator coordinator)
        {
            try
            {
                
                string query = "select * from coordinator where username ='" + coordinator.username + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into coordinator values ('" + coordinator.username + "','" + coordinator.password + "', '" + coordinator.firstName + "','" + coordinator.lastName + "','" + coordinator.phone + "','" + coordinator.email + "' ) ";
                }
                else
                {
                    query = " Update coordinator set firstName = '" + coordinator.firstName + "', lastName = '"+coordinator.lastName+"' ,password = '"+coordinator.password+"' , phone = '"+coordinator.phone+"', email = '"+coordinator.email+"' where username = '"+coordinator.username+"'  ";
                }
                
                //string query = "Insert into coordinator values ('" + coordinator.username + "','" + coordinator.password + "', '" + coordinator.firstName + "','" + coordinator.lastName + "','" + coordinator.phone + "','" + coordinator.email + "' ) ";
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





        public bool CoordinatorLogin(Coordinator c)
        {
            try
            {
                string query = "select * from coordinator where username = '" + c.username + "' and password = '" + c.password + "';";
                var dt = DataAccess.GetDataTable(query);

                if (dt.DataSet.Tables[0].Rows.Count == 1)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(Console.WriteLine(ex));
                return false;
            }

        }
        Coordinator coordinator = new Coordinator();
        public Coordinator GetInfo(Coordinator c)
        {
            try
            {
                string query = "select* from coordinator where username = '" + c.username + "' ";
                var dt = DataAccess.GetDataSet(query);

                coordinator.username= dt.Tables[0].Rows[0][1].ToString();
                coordinator.firstName = dt.Tables[0].Rows[0][3].ToString();
                coordinator.lastName= dt.Tables[0].Rows[0][4].ToString();
                coordinator.phone= dt.Tables[0].Rows[0][5].ToString();
                coordinator.email= dt.Tables[0].Rows[0][6].ToString();
                return coordinator;
            }

            catch(Exception exc)
            {
                return coordinator;
            }
        }


        public bool DeleteProfile(Coordinator coordinator)
        {
            
                string query = "delete from coordinator where username = '" + coordinator.username + "' ";
                int count = DataAccess.ExecuteUpdateQuery(query);
                if (count == 1)
                    return true;
                else
                    return false;
            }
            
            
        }

    }

