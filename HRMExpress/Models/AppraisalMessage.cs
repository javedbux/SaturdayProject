using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class AppraisalMessage
    {
        public int MessagesID { get; set; }
        public string MessagesText { get; set; }
        public int SentBY { get; set; }
        public int SentFor { get; set; }
        public System.DateTime SentDate { get; set; }
        public Nullable<System.DateTime> ReadDate { get; set; }
        public string MsgStatus { get; set; }
    }
}
