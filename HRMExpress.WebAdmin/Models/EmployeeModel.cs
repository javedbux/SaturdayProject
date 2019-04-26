using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HRMExpress.WebAdmin.Models
{
    public class EmployeeModel
    {
       
        public Int64 EmployeeID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Designation { get; set; }
        [Display(Name = "Emergency Contact Name")]
        public string EmergencyContactName { get; set; }

        [Display(Name = "DepartmentName")]
        public string DepartmentName { get; set; }
        
        
        
    }
}