using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_UI.Models.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="* 用户名出现异常")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "* 用户名或密码出现异常")]
        public string Password { get; set; }
        public bool? IsMale { get; set; }
        public Cities? InCitys { get; set; }
        public string SelfIntroduction { get; set; }
        public string Captcha { get;  set; }

        public User Inviter { get; set; }
    }
    public enum Cities
    {
        [Display(Name = "北京")]
        BeiJing,
        [Display(Name = "上海")]
        ShangHai,
        [Display(Name = "重庆")]
        ChongQing,
        [Display(Name = "郑州")]
        ZhengZhou
    }
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}