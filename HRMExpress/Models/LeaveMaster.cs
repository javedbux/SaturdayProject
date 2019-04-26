using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class LeaveMaster
    {
        public long leavemaster_id { get; set; }
        public Nullable<long> emp_id { get; set; }
        public Nullable<long> leavetype_id { get; set; }
        public Nullable<decimal> allottedleaves { get; set; }
        public Nullable<short> foryear { get; set; }
        public Nullable<System.DateTime> crd { get; set; }
        public Nullable<bool> isdeleted { get; set; }
    }
}
