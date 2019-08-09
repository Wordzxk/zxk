﻿using FirstMVC_UI.Models.Model;
using FirstMVC_UI.Models.TargerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class TargerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TargerModel targerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(targerModel);
            }
            return View();
        }
    }
}