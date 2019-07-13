using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
namespace WebThreetier.Pages
{
    
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private RegisterService _registerService;
        public RegisterModel()
        {
            _registerService = new RegisterService();
        }
        public Register Register { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "注册";
        }
        public void Onpost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            if (_registerService.HasExist(Register.UserName))
            {
                ModelState.AddModelError("UserName", "* 用户名重复");
                return;
            }
            _registerService.Register(Register.UserName, Register.Password);
        }
        private void save()
        {
            throw new NotImplementedException();
        }
    }
    
    public class Register
    {
        [Copy]
        [Display(Name = "用户名")]
        public  string UserName { get; set; }
        [Copy]
        [Display(Name = "密码")]
        public  string Password { get; set; }
        [Copy]
        [Compare("Password", ErrorMessage = "* 两次输入不一致")]
        public string ConfirmPassword { get; set; }
    }
}