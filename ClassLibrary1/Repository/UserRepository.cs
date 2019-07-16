using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Text;
namespace BLL.Repository
{
    public class UserRepository : DbContext
    {

        public DbSet<User> _users { get; set;}
       public void Save(User user)
        {
            
            _users.Add(user);
            SaveChanges();
            
        }

        public User GetByName(string name)
        {
            
            return _users.Where(u => u.Name == name).SingleOrDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Great;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
