using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class LeaveTransaction
    {
        public long leavetran_id { get; set; }
        public Nullable<long> emp_id { get; set; }
        public Nullable<long> leave_type_id { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<bool> ishalfday { get; set; }
        public string proofname { get; set; }
        public Nullable<System.DateTime> submit_date { get; set; }
        public string comment { get; set; }
        public Nullable<bool> isapproved { get; set; }
        public Nullable<bool> isrejected { get; set; }
        public Nullable<bool> iscancelled { get; set; }
        public Nullable<long> approvedby { get; set; }
        public Nullable<System.DateTime> approve_date { get; set; }
        public string remark { get; set; }
    }
}
