using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Emails
    {

   
        [BindProperty]
        public User Owner { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public string ValidationCode { get; set; }
        public DateTime? HasValidated { get; set; }
        public int OwnerId { get;  set; }

        public void MakeValidationCode()
        {
            //抛异常
            if (!string.IsNullOrEmpty(ValidationCode))
            {
                throw new InvalidOperationException(
                    $"在Validation已有值的情况下（{ValidationCode}）试图再次生成");
            }
            //生成Email验证码
            ValidationCode = new Random().Next().ToString();
        }

        public void Send(string validationUrl)
        {
            //SRV层
        }

        public void Validated()
        {
            //显示时间
            HasValidated = DateTime.Now;
        }

    }
}
