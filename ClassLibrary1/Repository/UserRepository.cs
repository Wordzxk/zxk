using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Text;
namespace BLL.Repository
{
    public class UserRepository : DbContext
    {
        public DbSet<User> _users { get; set;}
        public DbSet<Email> Emails { get; set; }

       public void Save(User user)
        {
            _users.Add(user);
            SaveChanges();
        }
        public void Save(Email email)
        {
            Emails.Add(email);
            SaveChanges();
        }

        public User GetByName(string name)
        {
            
            return _users.Where(u => u.Name == name).SingleOrDefault();
        }

        //得到Email
        public Email GetEmailById(int id)
        {
            Email email = Emails.Where(e => e.Id == id).SingleOrDefault();
            return email;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=First;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
       
    }
}
