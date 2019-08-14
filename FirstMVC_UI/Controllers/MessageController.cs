using FirstMVC_UI.Models.Model;
using FirstMVC_UI.Models.TargerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            TargetModel targetModel = new TargetModel
            {
                Messages = new List<MessageItemModel>
                {
                    new MessageItemModel {Content="星期一",Id=1},
                    new MessageItemModel {Content="星期二",Id=2},
                    new MessageItemModel {Content="星期三",Id=3},
                    new MessageItemModel {Content="星期四",Id=4},
                    new MessageItemModel {Content="星期五",Id=4},
                    new MessageItemModel {Content="星期六",Id=4},
                    new MessageItemModel {Content="星期日",Id=4}

                }
            };
            return View(targetModel);
        }
        [HttpPost]
        public ActionResult Index(TargetModel targerModel)
        {
            foreach (var item in targerModel.Messages)
            {
                if (item.Selected)
                {
                    //使用item.Id进行处理
                }
            }

            if (!ModelState.IsValid)
            {
                return View(targerModel);
            }
            return View();
        }

    }
}