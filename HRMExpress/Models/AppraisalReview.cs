using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class AppraisalReview
    {
        public int AppraisalReviewID { get; set; }
        public int AppraisalID { get; set; }
        public string ApprParameter { get; set; }
        public int ParameterID { get; set; }
        public string score { get; set; }
        public string comment { get; set; }
        public int commentBy { get; set; }
        public System.DateTime commentDate { get; set; }
    }
}
