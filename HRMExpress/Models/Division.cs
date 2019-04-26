using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Division
    {
        public int DivisionID { get; set; }
        public string DivisionName { get; set; }
        public int CountryID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
