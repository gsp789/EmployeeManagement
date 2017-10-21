using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class BtsclaimStatus
    {
        public BtsclaimStatus()
        {
            Btsexpenses = new HashSet<Btsexpenses>();
            TravelClaims = new HashSet<TravelClaims>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedBy { get; set; }

        public ICollection<Btsexpenses> Btsexpenses { get; set; }
        public ICollection<TravelClaims> TravelClaims { get; set; }
    }
}
