using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Text;
namespace BLL.Repository
{
    public class UserRepository : DbContext
    {
        //存到数据库
        public DbSet<User> _users { get; set;}
        public DbSet<Email> Emails { get; set; }

       public void Save(User user)
        {
            _users.Add(user);
            SaveChanges();
        }
        //Email储存
        public void Save(Email email)
        {
            Emails.Add(email);
            SaveChanges();
        }

        public User GetByName(string name)
        {
            //查询Name
            return _users.Where(u => u.Name == name).SingleOrDefault();
        }

        //得到Email
        public Email GetEmailById(int id)
        {
            Email email = Emails.Where(e => e.Id == id).SingleOrDefault();
            return email;
        }
        //定位数据库的地址
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=First;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public void Flush()
        {
            SaveChanges();
        }
    }
}
