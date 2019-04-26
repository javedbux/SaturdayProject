using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Attendance
    {
        public long aid { get; set; }
        public Nullable<long> emp_id { get; set; }
        public Nullable<System.DateTime> login { get; set; }
        public Nullable<System.DateTime> logout { get; set; }
        public string remark { get; set; }
        public Nullable<System.DateTime> adate { get; set; }
    }
}
