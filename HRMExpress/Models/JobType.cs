using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class JobType
    {
        public int JobTypeID { get; set; }
        public string JobType1 { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
