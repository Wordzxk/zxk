using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_UI.Models.TargerModel
{
    public class TargetModel
    {

        [Required(ErrorMessage = "* 标题必填")]
        public string Headline { get; set; }
        public string Explain { get; set; }
        public string Label { get; set; }
        public int Begintime { get; set; }
        public int EndTime { get; set; }
        public List<MessageItemModel> Messages { get; set; }
    }
    public class MessageItemModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
        public bool Selected { get; set; }


    }
}