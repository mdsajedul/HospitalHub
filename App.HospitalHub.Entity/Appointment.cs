using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace App.HospitalHub.Entity
{
   public class Appointment
    {
        public string id { get; set; }
        public string hospitalId { get; set; }
        public string patientId { get; set; }
        public string doctorName { get; set; }
        public string department { get; set; }
        public string patientName { get; set; }
        public string patientPhone { get; set; }
        public string patientEmail { get; set; }
        public string district { get; set; }
        public string division { get; set; }
        public DateTime time { get; set; }
        public DateTime date { get; set; }
        public string message { get; set; }
        public string hospitalName { get; set; }
       
    }
}
