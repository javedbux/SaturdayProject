using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class State
    {
        public int StateID { get; set; }
        public string SateName { get; set; }
        public int CountryID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
