using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }


        public int BlogId { get; set; }          //不声明会产生“影子”属性
        public Blog Blog { get; set; }
    }
}
