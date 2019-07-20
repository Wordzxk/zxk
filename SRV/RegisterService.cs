using BLL;
using BLL.Repository;
using SRV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

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

        public UserModel GetById(int id)
        {
            User user = _userRepository.GetById(id);

            return mapForm(user);
        }
        public UserModel mapForm(User user)
        {
            if (user == null)
            {
                return null;
            }
            else
            {
                UserModel model = new UserModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    MD5Password = user.Password
                };
                return model;
            }
        }

        public bool PasswordCorrect(string raw, string md5)
        {
            return User.GetMd5Hash(raw) == md5;

        }

        public UserModel GetByName(string name)
        {
            User user = _userRepository.GetByName(name);
            return mapForm(user);
        }

        public bool HasExist(string username)
        {
            return _userRepository.GetByName(username) != null;
        }
        //Email
        public void SendValidationEmail(string emailAddress, string validationUrlFormat)
        {

            Email email = new Email { Address = emailAddress };
            email.MakeValidationCode();
            _userRepository.Save(email);
            //string validationUrl = string.Format(validationUrlFormat, email.Id, email.ValidationCode);
            string validationUrl = string.Format(validationUrlFormat, email.ValidationCode, email.Id);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("you_email_address@gmail.com");
            mail.To.Add(emailAddress);            //to_address
            mail.Subject = "尝试激活Email邮件";     //Text Mail
            mail.Body = validationUrl;          //This is for texting Smtp mail form GMAIL

            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

        public UserModel GetUser(string userName)
        {
            User user = _userRepository.GetByName(userName);

            if (user == null)
            {
                return null;
            }
            else
            {
                UserModel model = new UserModel();

                model.Id = user.Id;
                model.MD5Password = user.Password;

                return model;

            }
        }


        //从仓库中得到Email
        public bool ValidateEmail(int id, string code)
        {
            Email email = _userRepository.GetEmailById(id);
            //激活Email
            email.Validated();

            //_userRepository.Save(email);
            //_userRepository.Flush();
            return email.ValidationCode == code;
            //return false;
        }
    }


}
