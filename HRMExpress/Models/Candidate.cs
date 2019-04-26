using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Candidate
    {
        public int CandidateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfInterview { get; set; }
        public int InterViewerID { get; set; }
        public int RequirementID { get; set; }
        public int DepartmentID { get; set; }
        public string PersonalEmailID { get; set; }
        public string ContactNo { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Department Department { get; set; }
    }
}
