using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositorys
{
   public class BlogRepository : Repository<Blog>
    {
        private SQLContext contest;

        public BlogRepository(SQLContext contest)
        {
            this.contest = contest;
        }

        public void Add(Post post)
        {

        }
    }
}
