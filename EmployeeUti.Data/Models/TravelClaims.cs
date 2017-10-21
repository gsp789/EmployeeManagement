using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class TravelClaims
    {
        public TravelClaims()
        {
            Btsexpenses = new HashSet<Btsexpenses>();
        }

        public int ClaimId { get; set; }
        public short EmployeeId { get; set; }
        public int? StatusId { get; set; }
        public short? LastVerifiedEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string BusinessPurpose { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ModifieTime { get; set; }
        public string CreatedBy { get; set; }
        public string Destination { get; set; }

        public AdmEmployee Employee { get; set; }
        public BtsclaimStatus Status { get; set; }
        public ICollection<Btsexpenses> Btsexpenses { get; set; }
    }
}
