using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class MyEMployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public Nullable<System.DateTime> DateOfJoining { get; set; }
        public int ManagerID { get; set; }
        public string Manager { get; set; }
        public Nullable<int> AgeYears { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string CorporateEmailID { get; set; }
        public string ContactNo { get; set; }
        public string DepartmentName { get; set; }
        public string EmergencyContactName { get; set; }
        public Nullable<decimal> EmergencyContactNumber { get; set; }
        public string PersonalEmailID { get; set; }
        public string SSN { get; set; }
        public string ImmigrationStatus { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public bool IsDeleted { get; set; }
    }
}
