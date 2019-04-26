using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class RequirementAssignment
    {
        public int AssID { get; set; }
        public int RequirementID { get; set; }
        public int AssignedTo { get; set; }
        public int AssignedBy { get; set; }
        public string Comment { get; set; }
    }
}
