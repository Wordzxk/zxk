using FirstMVC_UI.Filters;
using FirstMVC_UI.Models.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Controllers
{
    public class ProblemController : Controller
    {
        //集合数据
        private static IList<ItemModel> problems = new List<ItemModel>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        public ActionResult New(ItemModel model)
        {
            //存数据
            int id = Save(model);
            //转页面
            return RedirectToAction("Single", new { id = id });
        }

        private int Save(ItemModel itemModel)
        {
            //把itemmodel数据添加进集合
            problems.Add(itemModel);
            //集合的下标
            return problems.Count - 1;

        }
        //实现
        public ActionResult Single(int id)
        {
            ItemModel model = Get(id);
            return View(model);
        }
        private ItemModel Get(int id)
        {
            return problems[id];
        }

        public ActionResult Post(int id, ItemModel itemModel)
        {
            ItemModel Problem = Get(id);
            Problem.Posts = Problem.Posts ?? new List<string>();
            Problem.Posts.Add(itemModel.NewPost);
            return PartialView("Post",itemModel.NewPost);
        }

    }
}