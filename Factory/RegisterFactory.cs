using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class RegisterFactory
    {
        private static UserService _userService;
        static RegisterFactory()
        {
            _userService = new UserService();
        }

        internal static void Create()
        {
            new UserService().Register("测试B",Help.PASSWORD);
            new UserService().Register("测试C", Help.PASSWORD);

        }

    }
}
