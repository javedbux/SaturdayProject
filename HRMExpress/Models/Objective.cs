using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Objective
    {
        public int ObjectiveID { get; set; }
        public string ObjectiveDescription { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int AppraisalTemplateID { get; set; }
        public System.DateTime DateOfCompletion { get; set; }
        public string ObjectiveType { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual AppraisalTemplate AppraisalTemplate { get; set; }
    }
}
