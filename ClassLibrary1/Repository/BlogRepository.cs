using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositorys
{
   public class BlogRepository : Repository<Blog>
    {
        //public DbSet<Blog> Entities { get; set; }
        public void Add(Post post)
        {

        }
    }
}
