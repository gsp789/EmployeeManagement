using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class AdmUserLevelHd
    {
        public AdmUserLevelHd()
        {
            AdmUserLevel = new HashSet<AdmUserLevel>();
        }

        public byte BranchId { get; set; }
        public short UserLevelId { get; set; }
        public string UserLevelCode { get; set; }
        public string UserLevelName { get; set; }
        public short ModuleId { get; set; }
        public short TransactionId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsSync { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }

        public ICollection<AdmUserLevel> AdmUserLevel { get; set; }
    }
}
