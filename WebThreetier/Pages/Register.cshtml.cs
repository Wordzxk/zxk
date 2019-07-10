using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebThreetier.Pages
{
    //添加以绑定字段
    [BindProperties]
    public class RegisterModel : PageModel
    {
        //声明字段
        public string UserName{ get; set; }
        public string Password { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            ////如果不等赋值一个
            //if (!BLL.User.IsNameDuplicated(UserName))
            //{
            //    //调用Register
            //    BLL.User.Register(new BLL.User { Name = UserName, Password = Password });
            //}
            //调用UserRepository
            new UserRepository().Save(new BLL.User { Name = UserName, Password = Password });


        }
    }
}