using FirstMVC_UI.Models.Model;
using FirstMVC_UI.Models.TargerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class TargetController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //TargetModel targetModel = new TargetModel
            //{
            //Messages = new List<MessageItemModel>{}
            //}
            return View();
        }
        [HttpPost]
        public ActionResult Index(TargetModel targerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(targerModel);
            }
            return View();
        }
    }
}