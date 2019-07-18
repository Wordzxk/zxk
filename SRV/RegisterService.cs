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

        public void SendValidationEmail(string emailAddress, string validationUrlFormat)
        {
            Email email = new Email { Address = emailAddress };

            _userRepository.Save(email);
            string validationUrl = string.Format(validationUrlFormat, email.Id, email.ValidationCode);
        }
        //得到Email
        public bool ValidateEmail(int id, string code)
        {
            Email email = _userRepository.GetEmailById(id);
            //激活
            return email.ValidationCode == code;
        }
    }
}
