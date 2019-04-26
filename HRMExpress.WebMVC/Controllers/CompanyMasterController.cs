using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMExpress.WebMVC.Models;
using HRMExpress.Core.Data;
using HRMExpress.Service;
using System.IO;

namespace HRMExpress.WebMVC.Controllers
{
    public class CompanyMasterController : Controller
    {
        //
        // GET: /CompanyMaster/
        private ICompanyMasterService companyMasterService;

         public CompanyMasterController(ICompanyMasterService companyMasterService)
        {
            this.companyMasterService = companyMasterService;
        }
        public ActionResult Index()
        {
            IEnumerable<CompanyMasterModel> companyMasters = companyMasterService.GetCompanyMasters().Select(e => new CompanyMasterModel
                {
                    
                    CompanyID           =   e.CompanyID
                    ,Code               =   e.Code
                    ,Name               =   e.Name
                    ,Email              =   e.Email
                    ,Website            =   e.Website
                    ,ContactPerson      =   e.ContactPerson
                    ,ContactNo          =   e.ContactNo
                    ,AlternateNo        =   e.AlternateNo
                    ,Address            =   e.Address
                    ,City               =   e.City
                    ,State              =   e.State
                    ,Country            =   e.Country
                    ,PageTitle          =   e.PageTitle
                    ,PageLogo           =   e.PageLogo
                    ,CreateDate         =   e.CreateDate
                    ,StartDate          =   e.StartDate
                    ,EndDate            =   e.EndDate
                    ,HRMPlan            =   e.HRMPlan
                    ,PaymentType        =   e.PaymentType
                    ,PaymentStatus      =   e.PaymentStatus
                    ,UserName           =   e.UserName
                    ,Password           =   e.Password
                 // ,PasswordSalt       =   e.PasswordSalt
                    ,LastLoginDate      =   e.LastLoginDate
                    ,CanEdit            =   e.CanEdit
                    ,Active             =   e.Active
                 // ,Deleted            =   e.Deleted



                });
            return View(companyMasters);
        }

       

    }
}
