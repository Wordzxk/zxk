using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace New_Wait
{
    public class WaitFor : DbContext
    {
        public DbSet<User> _users { get; set; }
        public User Save(User user)
        {
            _users.Add(user);
            SaveChanges();

            return user;
        }

        public User GetByName(string userName)
        {
            return _users.Where(u => u.UserName == userName).SingleOrDefault();
        }
    }

    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }


    }
}