using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMExpress.WebAdmin.Models;
using HRMExpress.Core.Data;
using HRMExpress.Service;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace HRMExpress.WebAdmin.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        //
        // GET: /User/

        public ActionResult Index()
        {
            //IEnumerable<UserModel> users = userService.GetUsers().Select(e => new UserModel
            //{
            //    UserName = e.UserName,
            //    Password = e.Password

            //});


            //var user1 = users.Where(a => a.UserName.Equals("Kathleenwhalen")).FirstOrDefault();
            //var testlist = users.ToList();

            
            return View();
        }

        public ActionResult ComIndex()
        {
            //IEnumerable<UserModel> users = userService.GetUsers().Select(e => new UserModel
            //{
            //    UserName = e.UserName,
            //    Password = e.Password

            //});


            //var user1 = users.Where(a => a.UserName.Equals("Kathleenwhalen")).FirstOrDefault();
            //var testlist = users.ToList();


            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public JsonResult UserLogin(UserModel user)
        {
            
            IEnumerable<UserModel> users = userService.GetUsers().Select(e => new UserModel
            {
               UserName = e.UserName,
               Password = e.Password,
               CompanyID = e.CompanyID,
               RoleID = e.RoleID
                

            });

            
            var user1 = users.Where(a => a.UserName.Equals(user.UserName)&& a.Password.Equals(EncriptPassword(user.Password))).FirstOrDefault();

            TempData["UserCompanyID"] = user1.CompanyID;

            return new JsonResult { Data = user1, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

          
        }

        private string EncriptPassword(string strPassword)
        {
            //string encPassword = null;
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(strPassword));

            StringBuilder encPassword = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                encPassword.Append(data[i].ToString("x2"));
            }

            return encPassword.ToString();
        }

    }
}
