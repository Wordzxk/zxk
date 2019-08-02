using BLL.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Article:Entity
    {
       public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }

        public string DiscrimintorTybe { get;  set; }
    }
}
