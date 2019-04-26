using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMExpress.WebMVCAn.Models;
using HRMExpress.Core.Data;
using HRMExpress.Service;
using System.IO;

namespace HRMExpress.WebMVCAn.Controllers
{
    public class MenuMasterController : Controller
    {
        //
        // GET: /MenuMaster/

        private IMenuMasterService menuMasterService;
        public MenuMasterController(IMenuMasterService menuMasterService)
        {
            this.menuMasterService = menuMasterService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuIndex()
        {
            int RoleID = Convert.ToInt32(Session["RoleID"]);
            
                IEnumerable<MenuMasterModel> menuMasters = menuMasterService.GetMenuMasters().Select(e => new MenuMasterModel
                {

                    ID = e.ID
                    ,Code = e.Code
                    ,Name = e.Name
                    ,Description = e.Description
                    ,IsGroup = e.IsGroup
                    ,GroupID = e.GroupID
                    ,GroupLevel = e.GroupLevel
                    ,Active = e.Active
                    ,MenuIcon = e.MenuIcon
                    ,Sequence = e.Sequence
                    ,ActionURL = e.ActionURL
                    ,CompanyID = e.CompanyID
                    ,RoleID = e.RoleID


                }).Where(e => e.RoleID == RoleID);
               
           

           

            return Json(menuMasters, JsonRequestBehavior.AllowGet);
            // return View();
        }

    }
}
