using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class RegisteredUser
    {
        public int EmpRoleID { get; set; }
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Employee { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
    }
}
