using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    public class ContactController : Controller
    {
        casgemEntities2 db = new casgemEntities2();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index (TblMessage p)
        {
            db.TblMessage.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Portfolio");
        }
    }
}