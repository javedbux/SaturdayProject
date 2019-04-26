using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfJoining { get; set; }
        public int ManagerID { get; set; }
        public string Designation { get; set; }
        public int DepartmentID { get; set; }
        public string CorporateEmailID { get; set; }
        public string PersonalEmailID { get; set; }
        public string ContactNo { get; set; }
        public string EmergencyContactName { get; set; }
        public Nullable<decimal> EmergencyContactNumber { get; set; }
        public string SSN { get; set; }
        public string ImmigrationStatus { get; set; }
        public string MaritalStatus { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public byte[] Photo { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Department Department { get; set; }
    }
}
