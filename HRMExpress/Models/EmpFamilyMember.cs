using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class EmpFamilyMember
    {
        public int MemberID { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Relation { get; set; }
    }
}
