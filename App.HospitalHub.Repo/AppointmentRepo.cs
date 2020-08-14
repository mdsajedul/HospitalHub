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
    public class AppointmentRepo
    {
        Hospital hospital = new Hospital();
        public bool MakeAppointment(Appointment appointment)
        {
            try
            {

                string query = " insert into appointment (hospitalId,patientId,doctorName,department,patientName,patientPhone,patientEmail,district,division,hospitalName) values ('" + appointment.hospitalId + "','" + appointment.patientId + "', '" + appointment.doctorName + "','" + appointment.department + "','" + appointment.patientName + "','" + appointment.patientPhone + "','" + appointment.patientEmail + "','" + appointment.district + "','" + appointment.division + "','"+appointment.hospitalName+"'   ) ";
                // string query = " insert into appointment (hospitalId,patientId,doctorName,department) values ('mHos','anik', 'saidur','patholoy') ";
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
            catch (Exception exc)
            {
                return false;
            }
        }

        public string exeption;
        public bool ConfirmAppointment(Appointment appointment)
        {
            try
            {

                string query = " insert into confirmAppointment (hospitalId,patientId,doctorName,department,patientName,patientPhone,patientEmail,district,division,time,date,hospitalName) values ('" + appointment.hospitalId + "','" + appointment.patientId + "', '" + appointment.doctorName + "','" + appointment.department + "','" + appointment.patientName + "','" + appointment.patientPhone + "','" + appointment.patientEmail + "','" + appointment.district + "','" + appointment.division + "','"+appointment.time+"','"+appointment.date+"','"+appointment.hospitalName+"'  ) ";
                 //string query = " insert into confirmAppointment (hospitalId,patientId,doctorName,department,patientName,patientPhone,patientEmail,district,division,time,date) values ('aa','aa', 'aa','aa','aa','aa','aa','aa','aa','12:38:00','2020-12-12'   )  ";
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
            catch (Exception exc)
            {
                return false;
                exeption = exc.ToString();
            }
        }


        public bool SendMessageByCoordinator(Appointment appointment)
        {
            try
            {

                string query = " insert into message (hospitalId,patientId,messagePatient) values ('" + appointment.hospitalId + "','" + appointment.patientId + "','"+appointment.message+"'  ) ";
                
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
            catch (Exception exc)
            {
                return false;
                exeption = exc.ToString();
            }
        }



        public Appointment GetMessage(Appointment a)
        {
            try
            {

                string query = "select top 1 messagePatient from message where patientId = '" + a.patientId + "' order by messagePatient asc";
                var dt = DataAccess.GetDataSet(query);

                a.message = dt.Tables[0].Rows[0][0].ToString();
      
                return a;
            }
            catch (Exception exc)
            {
               
                return a;
            }
        }

        public bool SendMessageByPatient(Appointment appointment)
        {
            try
            {

                string query = " insert into message (hospitalId,patientId,messageOrdinator) values ('" + appointment.hospitalId + "','" + appointment.patientId + "','" + appointment.message + "'  ) ";

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
            catch (Exception exc)
            {
                return false;
                exeption = exc.ToString();
            }
        }



        public bool RejectAppointment(Appointment appointment)
        {


           string query = "delete from appointment where id ='" + appointment.id + "' ";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }

        public bool DeleteAppointment(Appointment appointment)
        {


            string query = "delete from confirmAppointment where id ='" + appointment.id + "' ";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }



        public DataTable GetAll(Appointment appointment)
        {
            var appointmentList = new List<Appointment>();
            var sql = " select * from appointment where hospitalId = '"+ appointment.hospitalId +"'";
            var dt = DataAccess.GetDataTable(sql);
            return dt;
        }


        public DataTable GetDataByPatient(Appointment appointment)
        {
            var appointmentList = new List<Appointment>();
            var sql = " select * from appointment where patientId = '" + appointment.patientId + "'";
            var dt = DataAccess.GetDataTable(sql);
            return dt;
        }


        public DataTable GetAllConfirmList(Appointment appointment)
        {
            var appointmentList = new List<Appointment>();
            var sql = " select * from confirmAppointment where hospitalId = '" + appointment.hospitalId + "'";
            var dt = DataAccess.GetDataTable(sql);
            return dt;
        }


        public DataTable GetAllConfirmListByPatient(Appointment appointment)
        {
            var appointmentList = new List<Appointment>();
            var sql = " select * from confirmAppointment where patientId = '" + appointment.patientId + "'";
            var dt = DataAccess.GetDataTable(sql);
            return dt;
        }


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


        public DataTable SearchPatient(Appointment appointment)
        {
            var appointmentList = new List<Appointment>();
            var sql = " select * from appointment where patientName like '%" + appointment.patientName + "%' or division like '%"+appointment.division+"%' or district like '%"+appointment.district+"%'  ";
            var dt = DataAccess.GetDataTable(sql);
            return dt;
        }


        public Appointment ConvertToEntity(DataRow row)
        {
            if(row == null)
            {
                return null;
            }

            var a = new Appointment();
            a.hospitalId = row["hospitalId"].ToString();
            a.patientId = row["patientId"].ToString();
            a.doctorName = row["doctorName"].ToString();
            a.department = row["department"].ToString();
            a.patientName = row["patientName"].ToString();
            a.patientPhone = row["patientPhone"].ToString();
            a.patientEmail = row["patientEmail"].ToString();
            a.district = row["district"].ToString();
            a.division = row["division"].ToString();
            return a;
        }

    }
}

