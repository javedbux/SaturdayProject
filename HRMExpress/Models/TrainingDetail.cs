using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class TrainingDetail
    {
        public int TrainingID { get; set; }
        public int CandidateID { get; set; }
        public int TrainerID { get; set; }
        public int SupervisorID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Objectives { get; set; }
        public string EmployeeFeedback { get; set; }
        public string SupervisorFeedback { get; set; }
        public string TrainerFeedback { get; set; }
        public bool IsDeleted { get; set; }
    }
}
