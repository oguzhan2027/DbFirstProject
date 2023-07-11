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
            ViewBag.totalCityCount=db.TblEmployee.Distinct().Count();
            ViewBag.avgEmployeeSalary= db.TblEmployee.Average(x=> x.EmployeeSalary);
            ViewBag.countSofWareDepartment=db.TblEmployee.Where(x=>x.EmployeeDepartment==db.TblDepartment.Where(z=>z.DepartmentName=="Yazılım").Select(y=>y.DepartmentID).FirstOrDefault()).Count();
            ViewBag.cityAnkaraOrAdanaSumSalary = db.TblEmployee.Where(x => x.EmployeeCity == "Adana"||x.EmployeeCity == "Ankara").Sum(y => y.EmployeeSalary);
            ViewBag.cityAnkaraDepartmentSoftwareSumSalary = db.TblEmployee.Where(x => x.EmployeeCity == "Ankara" && x.EmployeeDepartment == db.TblDepartment.Where(z => z.DepartmentName == "Yazılım").Select(y => y.DepartmentID).FirstOrDefault()).Sum(w => w.EmployeeSalary);

            return View();
        }
    }
}