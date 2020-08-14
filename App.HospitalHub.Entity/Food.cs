using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.HospitalHub.Entity
{
    public class Food
    {
        public int id { get; set; }
        public string breakfast { get; set; }
        public string lunch { get; set; }
        public string snacks { get; set; }
        public string dinner { get; set; }
        public string hospitalId { get; set; }
    }
}
