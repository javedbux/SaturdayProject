using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Menu
    {
        public int MenuID { get; set; }
        public Nullable<int> EmployeeRoleID { get; set; }
        public int EmployeeID { get; set; }
        public string UI_sref { get; set; }
        public string MenuName { get; set; }
        public bool IsDeleted { get; set; }
        public string MenuLevel { get; set; }
        public string MainMenu { get; set; }
    }
}
