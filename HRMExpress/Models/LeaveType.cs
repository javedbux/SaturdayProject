using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class LeaveType
    {
        public long leave_type_id { get; set; }
        public string leave_name { get; set; }
        public string leave_description { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
