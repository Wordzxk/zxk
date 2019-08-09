using FirstMVC_UI.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    
    public class RegisterController : Controller
    {
        //给View传参数
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        //接受前台数据
        [HttpPost]
        public ActionResult PIndex(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }

            return View();
        }
        [ChildActionOnly]
        public PartialViewResult Reninder()
        {
            ViewData["Id"] = 11;
            ViewBag.Name = "？？？";

            return PartialView();
        }
    }
}