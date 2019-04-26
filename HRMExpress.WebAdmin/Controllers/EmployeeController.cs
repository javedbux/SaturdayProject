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
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        public ActionResult Index()
        {
            IEnumerable<EmployeeModel> employees = employeeService.GetEmployees().Select(e => new EmployeeModel
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Designation = e.Designation,
                    DepartmentName = e.Department.DepartmentName

                });
            return View(employees);
        }
        public ActionResult GetAllEmp()
        {

            IEnumerable<EmployeeModel> employees = employeeService.GetEmployees().Select(e => new EmployeeModel
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Designation = e.Designation,
                DepartmentName = e.Department.DepartmentName 


            });
            //return View(employees);

            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveFiles(string description)
        {
            string Message, fileName, actualFileName;
            Message = fileName = actualFileName = string.Empty;
            bool flag = false;
            if(Request.Files !=null)
            {
                var file = Request.Files[0];
                actualFileName = file.FileName;
                fileName = Guid.NewGuid() + Path.GetFileName(file.FileName);

                int size = file.ContentLength;

                try
                {
                    file.SaveAs(Path.Combine(Server.MapPath("~/UploadedFiles"), fileName));
                    

                }
                catch
                {

                }

            }
            return new JsonResult { Data = new { Message = Message, Status = flag } };
        }
    }
}
