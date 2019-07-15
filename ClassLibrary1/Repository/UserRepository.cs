using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository : DbContext
    {

        private DbSet<User> _users;
       public void Save(User user)
        {
            _users.Add(user);
            //储存
            //Save(user);
            SaveChanges();
        }

        public User GetByName(string name)
        {
            return _users.Where(u => u.Name == name).SingleOrDefault();
        }
    }
}
