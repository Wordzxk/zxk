using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVC_UI.Models.Register
{
    public class IndexModel
    {
        [Required(ErrorMessage = "*用户民不能为空┗|｀O′|┛ 嗷~~")]
        public string UserName { get; set; } = "用户名";
        public string Password { get; set; }
        public bool? IsMale { get; set; }
        public Cities? InCitys { get; set; }
        public string SelfIntroduction { get; set; }
        public bool RememberMe { get; set; }

    }
    public enum Cities
    {
        [Display(Name ="北京")]
        BeiJing,
        [Display(Name = "上海")]
        ShangHai,
        [Display(Name ="重庆")]
        ChongQing,
        [Display(Name ="郑州")]
        ZhengZhou
    }
}