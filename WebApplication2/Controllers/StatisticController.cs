using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    public class StatisticController : Controller
    {
        casgemEntities2 db = new casgemEntities2();
        public ActionResult Index()
        {
            ViewBag.employeeCount = db.TblEmployee.Count();
            ViewBag.maxSalaryEmployee = db.TblEmployee.Where(x => x.EmployeeSalary == salary).Select(y => y.EmployeeName + "" + y.EmployeeSurname).FirstOrDefault();
            return View();
        }
    }
}