using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class AppraisalDetail
    {
        public int AppraisalID { get; set; }
        public string NAME { get; set; }
        public int EmployeeID { get; set; }
        public string Designation { get; set; }
        public string TemplateName { get; set; }
        public System.DateTime AssignedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> DateofCompleted { get; set; }
        public string Status { get; set; }
    }
}
