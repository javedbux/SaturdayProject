using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRMExpress.Core.Data
{
     public partial class Department : BaseEntity
    {
        public Department()
        {
            //this.Employees = new List<Employee>();
        }

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual Employee Employees { get; set; }
    }
}

