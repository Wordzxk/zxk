using System;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class User
    {
        //加密
        private const string _salt = "KB5A*two2";
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        

        public void Register()
        {
            if (InvitedBy != null)
            {

            }
            using (MD5 md5Hash = MD5.Create())
            {
                //密码加严
                Password = GetMd5Hash(md5Hash, Password+_salt);
            }
        }
       
       private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            //将字符串转换为byte[]
            //进行MD5单向加密
            byte[] date = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

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
