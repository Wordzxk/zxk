using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_UI.Models.Problem
{
    public class ItemModel
    {
        //允许使用Html标签
        [AllowHtml]
        public string Body { get; set; }
        public string NewPost { get; set; }
        public IList<string> Posts { get; set; }

    }
}