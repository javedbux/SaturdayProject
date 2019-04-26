using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMExpress.WebMVCAn.Models
{
    public class UserModel
    {

        public int UserID { get; set; }
         [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Password { get; set; }

         [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
        public System.DateTime LastLogin { get; set; }
        public int CompanyID { get; set; }
        public int RoleID { get; set; }
    }
}