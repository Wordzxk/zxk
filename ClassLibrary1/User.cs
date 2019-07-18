using System;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class User
    {
        //
        private const string _salt = "KB5A*two2";
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }

        //public string Email { get; set; }
        //public string EmailCode { get; set; }
        //public bool EmailHasValidated { get; set; }

        public void Register()
        {
            if (InvitedBy != null)
            {

            }
            using (MD5 md5Hash = MD5.Create())
            {
                Password = GetMd5Hash(md5Hash, Password+_salt);
            }
        }
       
       private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] date = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < date.Length; i++)
            {
                sBuilder.Append(date[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
