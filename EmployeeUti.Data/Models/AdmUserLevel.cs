using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class AdmUserLevel
    {
        public byte BranchId { get; set; }
        public short UserLevelId { get; set; }
        public short UserGroupId { get; set; }
        public decimal ApprovalLimitAmt { get; set; }
        public string Remarks { get; set; }
        public bool? IsBegin { get; set; }
        public bool? IsEnd { get; set; }
        public bool? IsIntermediate { get; set; }
        public bool? IsCanForwardToAnyLevel { get; set; }
        public byte DaysToRetain { get; set; }
        public short ForwardUserGroupId { get; set; }
        public short DownwardUserGroupId { get; set; }

        public AdmUserGroup DownwardUserGroup { get; set; }
        public AdmUserGroup ForwardUserGroup { get; set; }
        public AdmUserGroup UserGroup { get; set; }
        public AdmUserLevelHd UserLevel { get; set; }
    }
}
