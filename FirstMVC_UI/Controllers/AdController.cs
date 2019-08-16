using FirstMVC_UI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class AdController:Controller
    {
        [ContextPerRequest]
        [ErrorLogOn]
        [NeedLogOn]
        public ActionResult Write()
        {
            return View();
        }

    }
}