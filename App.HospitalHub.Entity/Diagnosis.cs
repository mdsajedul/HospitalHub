using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.HospitalHub.Entity
{
   public class Diagnosis
    {
        public int id { get; set; }
        public string name { get; set; }
        public string cost { get; set; }
        public string hospitalId { get; set; }
    }
}
