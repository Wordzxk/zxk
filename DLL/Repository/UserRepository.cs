using System;
using System.Collections.Generic;
using System.Text;

//添加贮存室
namespace BLL.Repository
{
    public class UserRepository
    {
        //储存Id
        public User Get(int Id)
        {
            return new User();
        }
        //取出Id
        public int Save(User user)
        {
            return -1;
        }
        //检查Id
        public User GetBy(string name)
        {
            return null;
        }
    }
}
