using FirstMVC_UI.Models.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //添加View参数可以使数据流动
        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            AboutModel aboutModel = new AboutModel();

            return View(aboutModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}