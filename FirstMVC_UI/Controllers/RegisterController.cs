using FirstMVC_UI.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{

    public class RegisterController : Controller
    {

        //给View传参数
        [HttpGet]
        //简易缓存
        [OutputCache(Duration = 60,VaryByParam ="Title")]
        public ActionResult Index(int? Id, string name)
        {
            string cachekey = "Register-Index";
            if (HttpContext.Cache[cachekey] == null)
            {
                string cacheValue = GetFromDB();
                //缓存
                HttpContext.Cache.Add(cachekey, cacheValue
                    , null, DateTime.MinValue,new TimeSpan(0,0,10)
                    , System.Web.Caching.CacheItemPriority.NotRemovable
                    , (key, value, reason) =>
                    {
                        Console.WriteLine($"缓存{key}(值为{value})因为{reason}被移除");
                    });
            }

            RegisterModel registerModel = new RegisterModel();
            ViewBag.Id = Id;
            return View(registerModel);
        }

        private string GetFromDB()
        {
            Thread.Sleep(1);
            return "This is Register_cache";
        }

        //接受前台数据
        [HttpPost]
        public ActionResult Index(string UserName, RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }
            if (registerModel.Captcha != Session[CaptchaController.CAPTCHA].ToString())
            {
                ModelState.AddModelError("Captcha", "* 验证码输入错误");
                return View(registerModel);
            }
            ViewBag.UserName = UserName;
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult Reminder()
        {
            ViewData["Id"] = 11;
            ViewBag.Name = "Look";

            User user = new User
            {
                Id = 22,
                Name = "Book"
            };

            return PartialView(user);
        }

    }
}