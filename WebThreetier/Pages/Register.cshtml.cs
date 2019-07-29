using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using WebThreetier.Pages.Shared;

namespace WebThreetier.Pages
{
    
    [BindProperties]
    public class RegisterModel : _LayoutModel 
    {
        private UserService _userService;
        public RegisterModel()
        {
            _userService = new UserService();
        }
      
        public Register Register { get; set; }
        public override void OnGet()
        {
            base.OnGet();
            
        }
        public void Onpost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            if (_userService.HasExist(Register.Name))
            {
                ModelState.AddModelError("Register.Name", "用户名已经存在");
                return;
            }
            _userService.Register(Register.Name, Register.Password);
        }
     
    }
    [BindProperties]
    public class Register
    {
        [BRquired]
        [Display(Name = "用户名")]
        public  string Name { get; set; }
        [BRquired]
        [Display(Name = "密码")]
        public  string Password { get; set; }
        [BRquired]
        [Compare("Password", ErrorMessage = "* 两次输入不一致")]
        public string ConfirmPassword { get; set; }
    }
}