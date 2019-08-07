using BLL.Repositorys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BLL
{
    public class Blog : Article
    {
        public string Url { get; set; }
        public IList<Post> Posts { get; set; }

    }
    [NotMapped]
    public class Post : Entity
    {
        public virtual User Author { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }


       //public int? BlogId { get; set; }          //不声明会产生“影子”属性
        public virtual Blog Blog { get; set; }
    }
}