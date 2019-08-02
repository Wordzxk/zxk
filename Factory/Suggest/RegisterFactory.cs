using BLL;
using BLL.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class RegisterFactory
    {
        internal static User CeshiB, CeshiC;

        private static UserRepository _userRe;
        static RegisterFactory()
        {
            _userRe = new UserRepository();
        }

        internal static void Create()
        {
            CeshiB = register("测试B");

            CeshiC = register("测试C");

        }
        private static User register(string Name)
        {
            User user = new User { Name = Name, Password = Help.PASSWORD };
            user.Register();
            _userRe.Save(user);

            return user;
        }

    }
}
