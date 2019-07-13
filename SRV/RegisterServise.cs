using BLL;
using BLL.Repository;
using System;

namespace SRV
{
    public class RegisterService
    {
        private UserRepository _userRepository;
        public RegisterService()
        {
            _userRepository = new UserRepository();
        }
        public void Register(string username, string password)
        {
            User user = new User
            {
                Name = username,
                Password = password
            };
            user.Register();
            _userRepository.Save(user);
        }

        public bool HasExist(string userName)
        {
            return _userRepository.GetByName(userName) != null;
        }
    }
}
