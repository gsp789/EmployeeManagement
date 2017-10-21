using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class AdmUserGroup
    {
        public AdmUserGroup()
        {
            AdmUser = new HashSet<AdmUser>();
            AdmUserLevelDownwardUserGroup = new HashSet<AdmUserLevel>();
            AdmUserLevelForwardUserGroup = new HashSet<AdmUserLevel>();
            AdmUserLevelUserGroup = new HashSet<AdmUserLevel>();
        }

        public byte BranchId { get; set; }
        public short UserGroupId { get; set; }
        public string UserGroupCode { get; set; }
        public string UserGroupName { get; set; }
        public DateTime ValidFrom { get; set; }
        public string Remarks { get; set; }
        public bool? IsActive { get; set; }
        public short SeqNo { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsSync { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }

        public ICollection<AdmUser> AdmUser { get; set; }
        public ICollection<AdmUserLevel> AdmUserLevelDownwardUserGroup { get; set; }
        public ICollection<AdmUserLevel> AdmUserLevelForwardUserGroup { get; set; }
        public ICollection<AdmUserLevel> AdmUserLevelUserGroup { get; set; }
    }
}
