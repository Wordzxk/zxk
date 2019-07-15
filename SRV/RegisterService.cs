using BLL;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SRV
{
    public class UserService
    {
        private UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public void Register(string username, string password)
        {
            User user = new User { Name = username, Password = password };
            user.Register();
            new UserRepository().Save(user);
        }
        public bool HasExist(string username)
        {
            return _userRepository.GetByName(username) != null;
        }
    }
}
