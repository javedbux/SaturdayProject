using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Company
    {
        public int CompanyID { get; set; }
        public string companyname { get; set; }
        public int NumberofEmployees { get; set; }
        public string TaxID { get; set; }
        public string NAICS { get; set; }
        public string Phone { get; set; }
        public string FAX { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string comment { get; set; }
    }
}
