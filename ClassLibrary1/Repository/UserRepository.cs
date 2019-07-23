using System.Linq;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositorys
{
    public class UserRepository :Repository<User>
    {
     
        //public DbSet<User> Entities { get; set; }
        //查询Name
        public User GetByName(string name)
        {
           
            return entities.Where(u => u.Name == name).SingleOrDefault();
        }
        //查询Id
        public User GetById(int id)
        {
            return entities.Where(u => u.Id == id).SingleOrDefault();
        }

      
    }
}
