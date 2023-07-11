﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    public class MessageController : Controller
    {
        casgemEntities2 db = new casgemEntities2();
        public ActionResult Index()
        {
            var values = db.TblMessage.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var values = db.TblMessage.Find(id);
            db.TblMessage.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MessageDetails(int id)
        {
            var value = db.TblMessage.Find(id);
            return View(value);
        }
    }
}