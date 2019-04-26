using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Appraisal
    {
        public int AppraisalID { get; set; }
        public int AppraisalTemplateID { get; set; }
        public int EmployeeID { get; set; }
        public int AssignedBy { get; set; }
        public System.DateTime AssignedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> DateofCompleted { get; set; }
        public string Status { get; set; }
        public virtual AppraisalTemplate AppraisalTemplate { get; set; }
    }
}
