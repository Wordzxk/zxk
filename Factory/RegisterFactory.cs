using BLL;
using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class RegisterFactory
    {
        internal static User CeshiB, CeshiC;

        private static UserService _userService;
        static RegisterFactory()
        {
            _userService = new UserService();
        }

        internal static void Create()
        {
            CeshiB = _userService.Register("测试B", Help.PASSWORD);
            CeshiC = _userService.Register("测试C", Help.PASSWORD);

        }

    }
}
