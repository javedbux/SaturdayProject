using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class ReceivedRequirement
    {
        public int FlowID { get; set; }
        public int RequirementID { get; set; }
        public string Platforms { get; set; }
        public string Technology { get; set; }
        public string Experiance { get; set; }
        public string DivisionName { get; set; }
        public string PerferedSkill { get; set; }
        public string JobType { get; set; }
        public string Priority { get; set; }
        public int PushBy { get; set; }
        public int PushTo { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public System.DateTime PushDate { get; set; }
    }
}
