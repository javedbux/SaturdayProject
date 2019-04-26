using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class AppraisalTemplate
    {
        public AppraisalTemplate()
        {
            this.Appraisals = new List<Appraisal>();
            this.CoreValues = new List<CoreValue>();
            this.Objectives = new List<Objective>();
        }

        public int AppraisalTemplateId { get; set; }
        public string TemplateName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual ICollection<Appraisal> Appraisals { get; set; }
        public virtual ICollection<CoreValue> CoreValues { get; set; }
        public virtual ICollection<Objective> Objectives { get; set; }
    }
}
