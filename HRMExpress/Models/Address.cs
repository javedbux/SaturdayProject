using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Address
    {
        public int AddressID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }
        public int EmployeeID { get; set; }
    }
}
