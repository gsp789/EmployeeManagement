using System;
using System.Collections.Generic;

namespace EmployeeUti.Data.Models
{
    public partial class AdmUser
    {
        public byte BranchId { get; set; }
        public short UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? ViewAllCustomers { get; set; }
        public string LookAndFeel { get; set; }
        public short LookAndFeelId { get; set; }
        public bool? IsToAllowCustomisation { get; set; }
        public string Remarks { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsSync { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string EditBy { get; set; }
        public DateTime? EditDate { get; set; }
        public short EmployeeId { get; set; }
        public bool? IsEnableSsl { get; set; }
        public string EmployeeEmailId { get; set; }
        public string EmployeeEmailPwd { get; set; }
        public bool? IsAuthenticationReq { get; set; }
        public string Smtphost { get; set; }
        public short Smtpport { get; set; }
        public short UserGroupId { get; set; }
        public bool? ApplyToAllBranches { get; set; }
        public bool? ApplyToAll { get; set; }

        public AdmUserGroup UserGroup { get; set; }
    }
}
