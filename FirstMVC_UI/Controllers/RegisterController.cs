using FirstMVC_UI.Models.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PIndex(IndexModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View();
        }
    }
}