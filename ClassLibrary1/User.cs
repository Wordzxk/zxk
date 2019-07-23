﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    [BindProperties]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[Required]
        public string Password { get; set; }
        //public string ConfimPassword { get; set; }
        public User InvitedBy { get; set; }
        public Email Email { get; set; }

        public void Register()
        {
            if (InvitedBy != null)
            {

            }

            Password = GetMd5Hash(Password);
        }

        /*进行了重构*/

        public static string GetMd5Hash(string input)
        {
            //加密
            const string _salt = "KB5A*two2";
            //

            using (MD5 md5Hash = MD5.Create())
            {
                //字符串转换为byte[]
                //进行MD5加密运算，加严
                byte[] date = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input + _salt));

                //StringBuilder提高性能
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < date.Length; i++)
                {
                    sBuilder.Append(date[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }

        }
    }
}
