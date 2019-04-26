using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class RequirementFlow
    {
        public int FlowID { get; set; }
        public int RequirementID { get; set; }
        public int PushBy { get; set; }
        public int PushTo { get; set; }
        public string Status { get; set; }
        public System.DateTime PushDate { get; set; }
        public string comment { get; set; }
    }
}
