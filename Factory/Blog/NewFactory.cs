using BLL.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Suggest
{
   internal class NewFactory
    {

        internal static void Create()
        {

      
        }
        private static BLL.Blog publich(string title, string body, BLL.User author)
        {
            BlogRepository repository = new BlogRepository(Help.contest);
            BLL.Blog blog = new BLL.Blog
            {
                Title = title,
                Body = body,
                Author = author
            };
            repository.Save(blog);
            return blog;
        }
        
    }
}
