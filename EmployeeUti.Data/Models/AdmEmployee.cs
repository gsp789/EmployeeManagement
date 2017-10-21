using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class AdmEmployee
    {
        public AdmEmployee()
        {
            TravelClaims = new HashSet<TravelClaims>();
        }

        public byte BranchId { get; set; }
        public short EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public short DepartmentId { get; set; }
        public string Remarks { get; set; }
        public short SeqNo { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsSync { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }

        public AdmDepartment Department { get; set; }
        public ICollection<TravelClaims> TravelClaims { get; set; }
    }
}
