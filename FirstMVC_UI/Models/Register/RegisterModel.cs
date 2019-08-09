using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_UI.Models.Model
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool? IsMale { get; set; }
        public Cities? InCitys { get; set; }
        public string SelfIntroduction { get; set; }


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
}