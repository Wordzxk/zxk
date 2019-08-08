using FirstMVC_UI.Models.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    //MVC无法控制前台
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