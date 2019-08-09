using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_UI.Models.TargerModel
{
    public class TargerModel
    {
        [Required(ErrorMessage = "* 标题必填哦")]
        public string Headline { get; set; }
        public string Explain { get; set; }
        public string Label { get; set; }
        public int Begintime { get; set; }
        public int EndTime { get; set; }
        
    }
    
}