using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BloodManagement
{
    public class CombinedClass
    {
        public int? RequestID { get; set; }
        public string HospitalName { get; set; }
        public string BloodType { get; set; }
        public string RhFactor { get; set; }
        public string RequestUrgency { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? DeliveryDate { get; set;}
        public string Status { get; set; }
        public int? NumberOfUnits { get; set; }
    }
}
