using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repositorys
{
   public class BlogRepository : Repository<Blog>
    {
        public int authorId { get; set; }

        public BlogRepository(DbContext context) 
        {

        }

        public void Add(Post post)
        {

        }

        public Blog Get(int id)
        {
            return entities
                .Include(e=>e.Author)
                //.ThenInclude(a=>a.Email)
                .Single(u => u.Id == id); 
        }

        public IList<Blog> GetByAuthor(int value)
        {
            return entities.Where(e => e.Author.Id == authorId).ToList();
        }

        public IList<Blog> Get(int pageIndex, int pageSize)
        {
            return Paged(entities.ToList(), pageIndex, pageSize);
        }

        private IList<Blog> Paged(List<Blog> list, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
