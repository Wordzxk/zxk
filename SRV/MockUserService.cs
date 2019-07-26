using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using SRV.Model;

namespace SRV
{
    public class MockUserService : IUserService
    {
        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
            //测试用例
            //if (id == 1)
            //{
            //    return new UserModel { Name = "", MD5Password = "1234" };
            //}
            //else
            //{
            //    return null;
            //}

        }

        public UserModel GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool HasExist(string username)
        {
            throw new NotImplementedException();
        }

        public bool PasswordCorrect(string raw, string md5)
        {
            throw new NotImplementedException();
        }

        public User Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void SendValidationEmail(string emailAddress, string validationUrlFormat)
        {
            throw new NotImplementedException();
        }

        public bool ValidateEmail(int id, string code)
        {
            throw new NotImplementedException();
        }
    }
}
