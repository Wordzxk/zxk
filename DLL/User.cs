using BLL.Repository;
using DAL;
using System;

namespace BLL
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsPasswordValid()
        {
            return Password.Length >= 4;
        }
        public void Register()
        {
            new UserRepository().Save(this);
        }

        //private static UserHelper _userHelper;
        ////静态构造函数
        //static User()
        //{
        //    _userHelper = new UserHelper();
        //}

        //声明静态类字段进行赋值
        //private static UserHelper _userHelper = new UserHelper();
        //声明字段

        ////声明方法
        //public static bool IsNameDuplicated(string name)
        //{
        //    //取DAL里的name
        //    return new UserHelper().GetByName(name) != null;
        //}
        ////直接传User
        //public static void Register(User user)
        //{
        //    //传入实例化的Save
        //    new UserHelper().Save(user.Name, user.Password);
        //}

    }

}

