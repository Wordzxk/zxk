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
        public ActionResult Index(int? Id)
        {
            RegisterModel registerModel = new RegisterModel();
            ViewBag.Id = Id;
            return View(registerModel);
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
        public PartialViewResult Reminder(int? Id)
        {
            ViewBag.Id = Id;
           

            return PartialView();
        }
        
    }
}