using BLL;
using SRV.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
   public interface IUserService
    {
        User Register(string username, string password);
        UserModel GetById(int id);
        bool PasswordCorrect(string raw, string md5);
        UserModel GetByName(string name);
        bool HasExist(string username);
         void SendValidationEmail(string emailAddress, string validationUrlFormat);
        bool ValidateEmail(int id, string code);

    }
}
