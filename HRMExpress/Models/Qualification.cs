using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Qualification
    {
        public int QualificationID { get; set; }
        public string QualificationDesc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
