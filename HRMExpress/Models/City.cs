using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int StateID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
