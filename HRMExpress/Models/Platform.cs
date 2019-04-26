using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Platform
    {
        public int PlatformID { get; set; }
        public string PlatformDesc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
