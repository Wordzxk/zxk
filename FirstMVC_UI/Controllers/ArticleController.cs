using FirstMVC_UI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        [NeedLogOn]
        public JsonResult Agree(int id)
        {
            return Json("JsonController",JsonRequestBehavior.AllowGet);
        }
    }
}