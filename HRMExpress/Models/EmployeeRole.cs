using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class EmployeeRole
    {
        public int EmpRoleID { get; set; }
        public int EmployeeID { get; set; }
        public int RoleID { get; set; }
        public System.DateTime CrDateTime { get; set; }
    }
}
