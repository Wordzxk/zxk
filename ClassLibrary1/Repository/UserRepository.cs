using System.Linq;
using System;
using System.Text;
namespace BLL.Repository
{
    public class UserRepository 
    {
        private SQLContext _sqLContext;
        public UserRepository()
        {
            _sqLContext = new SQLContext();
        }

        public void Save(User user)
        {
            _sqLContext.Add(user);
           _sqLContext. SaveChanges();
        }
        //Email储存
        public void Save(Email email)
        {
            _sqLContext.Add(email);
            _sqLContext. SaveChanges();
        }

        public User GetByName(string name)
        {
            //查询Name
            return _sqLContext._users.Where(u => u.Name == name).SingleOrDefault();
        }

        public User GetById(int id)
        {
            return  _sqLContext._users.Where(u => u.Id == id).SingleOrDefault();
        }

        //得到Email
        public Email GetEmailById(int id)
        {
            Email email =_sqLContext. Emails.Where(e => e.Id == id).SingleOrDefault();
            return email;
        }
      
        //public void Flush()
        //{
        //    SaveChanges();
        //}
    }
}
