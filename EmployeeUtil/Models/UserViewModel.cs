using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeUtil.Models
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public int UserGroup { get; set; }
        public int EmployeeId { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public UserViewModel(string password,int EmployeeId,int UserId)
        {
            this.EmployeeId = EmployeeId;
            this.Password = password;
            this.UserId = UserId;
        }
    }
}
