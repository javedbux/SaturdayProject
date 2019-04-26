using System;
using System.Collections.Generic;

namespace HRMExpress.Core.Data
{
    public partial class User : BaseEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime LastLogin { get; set; }

        public int CompanyID { get; set; }
        public int RoleID { get; set; }
    }
}
