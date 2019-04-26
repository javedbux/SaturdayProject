using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Technology
    {
        public int TechnologyID { get; set; }
        public string TechnologyDesc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<bool> IdDeleted { get; set; }
    }
}
