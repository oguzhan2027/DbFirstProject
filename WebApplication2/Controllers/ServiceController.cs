using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    public class ServiceController : Controller
    {
        casgemEntities2 db = new casgemEntities2();
        public ActionResult Index()
        {
            var value = db.TBLService.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService(TBLService p)
        {
            db.TBLService.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
            var value= db.TBLService.Find(id);
            db.TBLService.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.TBLService.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(TBLService p)
        {
            var value = db.TBLService.Find(p.ServiceID);
            value.ServiceTitle = p.ServiceTitle;
            value.ServiceIcon = p.ServiceTitle;
            value.ServiceNumber = p.ServiceTitle;
            value.ServiceContent = p.ServiceTitle;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}