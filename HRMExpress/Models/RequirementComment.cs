using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class RequirementComment
    {
        public int CommentID { get; set; }
        public int RequirementID { get; set; }
        public string Comment { get; set; }
        public int CommentBy { get; set; }
        public int CommentTo { get; set; }
        public System.DateTime CommentDate { get; set; }
    }
}
