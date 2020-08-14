using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.HospitalHub.Entity
{
    public class Patient
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dob { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string division { get; set; }
        public string district { get; set; }
        public string sex { get; set; }
        public string area { get; set; }
        public string roadNo { get; set; }
        public string houseNo { get; set; }
    }
}
