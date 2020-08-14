using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.HospitalHub.Entity
{
    public class Hospital
    {
        public int id { get; set; }
        public string hospitalId { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string division { get; set; }
        public string district { get; set; }
        public string area { get; set; }
        public string road { get; set; }
        public string house { get; set; }
        public string department { get; set; }
        public string doctor { get; set; }
    }
}
