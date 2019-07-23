using BLL.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Blog : Article
    {
        public string Url { get; set; }
        public IList<Post> Posts{get; set;}
        //public IList<BlogToKeywords> Keywords { get; set; }

    }

}
