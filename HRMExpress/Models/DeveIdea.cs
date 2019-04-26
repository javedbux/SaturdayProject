using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class DeveIdea
    {
        public int DeveIdeaID { get; set; }
        public int AppraisalID { get; set; }
        public string ApprParameter { get; set; }
        public string comment { get; set; }
        public int commentBy { get; set; }
        public System.DateTime commentDate { get; set; }
    }
}
