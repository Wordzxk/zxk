using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repositorys
{
    public class SuggestRepository : Repository<Suggest>
    {
      

        public SuggestRepository(DbContext context) : base(context)
        {

        }
        public void Add(Post Post)
        {

        }
        public IList<Suggest> Get(int pageIndex, int pageSize)
        {
            //跳过几条，取几条的值
            return entities
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

        }
        //public IList<Blog> GetByAuthor(int authorId)
        //{
        //    return entities.Where(e => e.Id == authorId).ToList();
        //}

        public Suggest Get(int id)
        {
            return entities.Where(u => u.Id == id).SingleOrDefault();
        }
       
    }
}
