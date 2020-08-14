using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.HospitalHub.Entity
{
    public class Rating
    {
       public string hospitalId { get; set; }
        public string id { get; set; }
        public int rating { get; set; }

        public string patientId { get; set; }
    }
}
