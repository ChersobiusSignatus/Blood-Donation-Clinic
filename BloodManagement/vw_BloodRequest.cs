//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_BloodRequest
    {
        public int RequestID { get; set; }
        public string HospitalName { get; set; }
        public string BloodType { get; set; }
        public string RhFactor { get; set; }
        public string RequestUrgency { get; set; }
        public System.DateTime RequestDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public string Status { get; set; }
        public int NumberOfUnits { get; set; }
    }
}
