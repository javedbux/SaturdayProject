using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class CoreValue
    {
        public int CoreValueID { get; set; }
        public string CoreValueDescription { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int AppraisalTemplateID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual AppraisalTemplate AppraisalTemplate { get; set; }
    }
}
