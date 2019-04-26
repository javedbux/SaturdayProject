using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMExpress.WebAdmin.Models;
using HRMExpress.Core.Data;
using HRMExpress.Service;
using System.IO;

namespace HRMExpress.WebAdmin.Controllers
{
    //[SessionState(System.Web.SessionState.SessionStateBehavior.Disabled)]
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
            return View();
        }

       [HttpGet]
        public ActionResult Index(int CompanyID)
        {
            return View();
        }
        public ActionResult GetAllCompanies()
        {
            

            IEnumerable<CompanyMasterModel> companyMasters = companyMasterService.GetCompanyMasters().Select(e => new CompanyMasterModel
            {

                CompanyID = e.CompanyID
                ,
                Code = e.Code
                ,
                Name = e.Name
                ,
                Email = e.Email
                ,
                Website = e.Website
                ,
                ContactPerson = e.ContactPerson
                ,
                ContactNo = e.ContactNo
                ,
                AlternateNo = e.AlternateNo
                ,
                Address = e.Address
                ,
                City = e.City
                ,
                State = e.State
                ,
                Country = e.Country
                ,
                PageTitle = e.PageTitle
                ,
                PageLogo = e.PageLogo
                ,
                CreateDate = e.CreateDate
                ,
                StartDate = e.StartDate
                ,
                EndDate = e.EndDate
                ,
                HRMPlan = e.HRMPlan
                ,
                PaymentType = e.PaymentType
                ,
                PaymentStatus = e.PaymentStatus
                ,
                UserName = e.UserName
                ,
                Password = e.Password
                    // ,PasswordSalt       =   e.PasswordSalt
                ,
                LastLoginDate = e.LastLoginDate
                ,
                CanEdit = e.CanEdit
                ,
                Active = e.Active
                // ,Deleted            =   e.Deleted



            });

            //return View(companyMasters);            

            return Json(companyMasters, JsonRequestBehavior.AllowGet);
        }

       [HttpGet]
        public ActionResult CompanyDetails(int CompanyID)
        {
 
            TempData["companyID"] = Convert.ToString(CompanyID);
           
           return View();            

        }
       public ActionResult GetAllCompaniesAngu()
       {
           //int companyID = Convert.ToInt32(TempData["companyID"]);
           int companyID = 0;
           if(Convert.ToInt32(TempData["UserCompanyID"]) == 0)
           {
               companyID = Convert.ToInt32(TempData["companyID"]);
           }
           else
           {
               companyID = Convert.ToInt32(TempData["UserCompanyID"]);
           }

               

           

           IEnumerable<CompanyMasterModel> companyMasters = companyMasterService.GetCompanyMasters().Select(e => new CompanyMasterModel
           {

               CompanyID = e.CompanyID 
               ,
               Code = e.Code
               ,
               Name = e.Name
               ,
               Email = e.Email
               ,
               Website = e.Website
               ,
               ContactPerson = e.ContactPerson
               ,
               ContactNo = e.ContactNo
               ,
               AlternateNo = e.AlternateNo
               ,
               Address = e.Address
               ,
               City = e.City
               ,
               State = e.State
               ,
               Country = e.Country
               ,
               PageTitle = e.PageTitle
               ,
               PageLogo = e.PageLogo
               ,
               CreateDate = e.CreateDate
               ,
               StartDate = e.StartDate
               ,
               EndDate = e.EndDate
               ,
               HRMPlan = e.HRMPlan
               ,
               PaymentType = e.PaymentType
               ,
               PaymentStatus = e.PaymentStatus
               ,
               UserName = e.UserName
               ,
               Password = e.Password
                   // ,PasswordSalt       =   e.PasswordSalt
               ,
               LastLoginDate = e.LastLoginDate
               ,
               CanEdit = e.CanEdit
               ,
               Active = e.Active
               // ,Deleted            =   e.Deleted

               

           });

           IEnumerable<CompanyMasterModel> companyMasters1 = companyMasterService.GetCompanyMasters().Where(e => e.CompanyID.Equals(companyID)).Select(e => new CompanyMasterModel
           {

               CompanyID = e.CompanyID
               ,
               Code = e.Code
               ,
               Name = e.Name
               ,
               Email = e.Email
               ,
               Website = e.Website
               ,
               ContactPerson = e.ContactPerson
               ,
               ContactNo = e.ContactNo
               ,
               AlternateNo = e.AlternateNo
               ,
               Address = e.Address
               ,
               City = e.City
               ,
               State = e.State
               ,
               Country = e.Country
               ,
               PageTitle = e.PageTitle
               ,
               PageLogo = e.PageLogo
               ,
               CreateDate = e.CreateDate
               ,
               StartDate = e.StartDate
               ,
               EndDate = e.EndDate
               ,
               HRMPlan = e.HRMPlan
               ,
               PaymentType = e.PaymentType
               ,
               PaymentStatus = e.PaymentStatus
               ,
               UserName = e.UserName
               ,
               Password = e.Password
                   // ,PasswordSalt       =   e.PasswordSalt
               ,
               LastLoginDate = e.LastLoginDate
               ,
               CanEdit = e.CanEdit
               ,
               Active = e.Active
               // ,Deleted            =   e.Deleted



           });

           //IEnumerable<CompanyMaster> list = companyMasters.Where(a => a.CompanyID.Equals(companyID)).FirstOrDefault();

           var companyMaster = companyMasters.Where(a => a.CompanyID.Equals(companyID)).FirstOrDefault();
           //var user1 = users.Where(a => a.UserName.Equals(user.UserName) && a.Password.Equals(EncriptPassword(user.Password))).FirstOrDefault();

           //return Json(companyMasters1, JsonRequestBehavior.AllowGet);
          return new JsonResult { Data = companyMaster, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
       }

       public ActionResult GetCompanyDetails()
       {
           //int companyID = Convert.ToInt32(TempData["companyID"]);
           int companyID = Convert.ToInt32(TempData["UserCompanyID"]);


           IEnumerable<CompanyMasterModel> companyMasters = companyMasterService.GetCompanyMasters().Select(e => new CompanyMasterModel
           {

               CompanyID = e.CompanyID
               ,
               Code = e.Code
               ,
               Name = e.Name
               ,
               Email = e.Email
               ,
               Website = e.Website
               ,
               ContactPerson = e.ContactPerson
               ,
               ContactNo = e.ContactNo
               ,
               AlternateNo = e.AlternateNo
               ,
               Address = e.Address
               ,
               City = e.City
               ,
               State = e.State
               ,
               Country = e.Country
               ,
               PageTitle = e.PageTitle
               ,
               PageLogo = e.PageLogo
               ,
               CreateDate = e.CreateDate
               ,
               StartDate = e.StartDate
               ,
               EndDate = e.EndDate
               ,
               HRMPlan = e.HRMPlan
               ,
               PaymentType = e.PaymentType
               ,
               PaymentStatus = e.PaymentStatus
               ,
               UserName = e.UserName
               ,
               Password = e.Password
                   // ,PasswordSalt       =   e.PasswordSalt
               ,
               LastLoginDate = e.LastLoginDate
               ,
               CanEdit = e.CanEdit
               ,
               Active = e.Active
               // ,Deleted            =   e.Deleted



           });

           //IEnumerable<CompanyMaster> list = companyMasters.Where(a => a.CompanyID.Equals(companyID)).FirstOrDefault();
           var companyMaster = companyMasters.Where(a => a.CompanyID.Equals(companyID)).FirstOrDefault();
           //var companyMaster = companyMasters1;
           //var user1 = users.Where(a => a.UserName.Equals(user.UserName) && a.Password.Equals(EncriptPassword(user.Password))).FirstOrDefault();

           //return Json(companyMasters1, JsonRequestBehavior.AllowGet);
           return new JsonResult { Data = companyMaster, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
       }

    }
}
