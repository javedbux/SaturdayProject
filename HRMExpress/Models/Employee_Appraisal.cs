using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Employee_Appraisal
    {
        public int AppraisalID { get; set; }
        public int AppraisalTemplateID { get; set; }
        public string TemplateName { get; set; }
        public int EmployeeID { get; set; }
        public string EName { get; set; }
        public string Designation { get; set; }
        public int ManagerID { get; set; }
        public int AssignedBy { get; set; }
        public System.DateTime AssignedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> DateofCompleted { get; set; }
        public string Status { get; set; }
    }
}
