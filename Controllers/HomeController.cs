using CollegeProject.Models;
using CollegeProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeProject.Controllers
{
    public class HomeController : Controller
    {
        private CollegeDBEntities db = new CollegeDBEntities();

        public ActionResult GetInfo() 
        {
            var tables = new EmployeeDepartmentViewModel
            {
                Employees = db.Employees.ToList(),
                Departments = db.Departments.ToList(),
            };
            return View(tables);        
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}