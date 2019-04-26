using System;
using System.Collections.Generic;

namespace HRMExpress.Models
{
    public partial class RequirementDetail
    {
        public int RequirementID { get; set; }
        public string JobDescription { get; set; }
        public string Platforms { get; set; }
        public string Technology { get; set; }
        public string Experiance { get; set; }
        public string Qualifications { get; set; }
        public int DivisionID { get; set; }
        public string DivisionName { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int StateID { get; set; }
        public string SateName { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string PerferedSkill { get; set; }
        public string JobType { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Priority { get; set; }
        public string Cirtification { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public string Status { get; set; }
        public string comment { get; set; }
        public bool IsDeleted { get; set; }
    }
}
