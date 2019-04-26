using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRMExpress.Core.Data
{
    public partial class Employee : BaseEntity
    {
        public Employee()
        {
            //this.Addresses = new List<Address>();
            //this.Appraisals = new List<Appraisal>();
            //this.Appraisals1 = new List<Appraisal>();
            //this.AppraisalTemplates = new List<AppraisalTemplate>();
            //this.CoreValues = new List<CoreValue>();
            //this.Objectives = new List<Objective>();
        }

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> DateOfJoining { get; set; }
        public int ManagerID { get; set; }
        public string Designation { get; set; }
        public int DepartmentID { get; set; }
        public string CorporateEmailID { get; set; }
        public string PersonalEmailID { get; set; }
        public string ContactNo { get; set; }
        public string EmergencyContactName { get; set; }
        public Nullable<decimal> EmergencyContactNumber { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public byte[] Photo { get; set; }
        public bool IsDeleted { get; set; }
        //public virtual ICollection<Address> Addresses { get; set; }
        //public virtual ICollection<Appraisal> Appraisals { get; set; }
        //public virtual ICollection<Appraisal> Appraisals1 { get; set; }
        //public virtual ICollection<AppraisalTemplate> AppraisalTemplates { get; set; }
        //public virtual ICollection<CoreValue> CoreValues { get; set; }
        //public virtual ICollection<Department> Department { get; set; }
        public virtual Department Department { get; set; }
        //public virtual ICollection<Objective> Objectives { get; set; }
    }
}
