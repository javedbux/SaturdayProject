using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Department
    {
        public Department()
        {
            this.Candidates = new List<Candidate>();
            this.Employees = new List<Employee>();
        }

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
