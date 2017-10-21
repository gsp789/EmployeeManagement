using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class AdmDepartment
    {
        public AdmDepartment()
        {
            AdmEmployee = new HashSet<AdmEmployee>();
        }

        public byte BranchId { get; set; }
        public short DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Remarks { get; set; }
        public short SeqNo { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsSync { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }

        public ICollection<AdmEmployee> AdmEmployee { get; set; }
    }
}
