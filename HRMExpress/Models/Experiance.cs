using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Experiance
    {
        public int ExperianceID { get; set; }
        public string ExperianceDesc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
