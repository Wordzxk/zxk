using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using SRV.Model;

namespace SRV
{
    public class MockUserService : IUserService
    {
        private Guid guid;
        public MockUserService()
        {
            guid = new Guid();
        }

        public UserModel GetById(int id)
        {
            //测试用例
            if (id == 1)
            {
                return new UserModel { Name = "", MD5Password = "1234" };
            }
            else
            {
                return null;
            }
        }

        public UserModel GetByName(string name)
        {
            switch (name)
            {
                case "测试":
                    return new UserModel { Id = 1, MD5Password = "1111", Name = name };
                case "测试A":
                    return new UserModel { Id = 2, MD5Password = "1111", Name = name };
                default:
                    return null;
            }
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
