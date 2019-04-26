using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Interview
    {
        public int InterviewID { get; set; }
        public int CandidateID { get; set; }
        public int InterviewerID { get; set; }
        public int RequirementID { get; set; }
        public System.DateTime InterviewDateTime { get; set; }
        public string Outcome { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
