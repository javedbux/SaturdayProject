using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
