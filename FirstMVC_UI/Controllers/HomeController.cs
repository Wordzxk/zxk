using FirstMVC_UI.Models.MainModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
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
            AboutModel aboutModel = new AboutModel();

            return View(aboutModel);
        }
        [OutputCache(Duration =100
            ,Order =300,VaryByParam ="none")]
        public ActionResult Contact()
        {
            Thread.Sleep(1000);

            ViewData["TIMN"] = DateTime.Now;

            return View();
        }

        
    }
}