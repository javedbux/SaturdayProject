using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class Requirement
    {
        public int RequirementID { get; set; }
        public string JobDescription { get; set; }
        public string Platforms { get; set; }
        public string Technology { get; set; }
        public string Qualifications { get; set; }
        public string Experiance { get; set; }
        public int DivisionID { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public int CityID { get; set; }
        public string PerferedSkill { get; set; }
        public string JobType { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Priority { get; set; }
        public string Cirtification { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string Status { get; set; }
    }
}
