using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime LastLogin { get; set; }
    }
}
