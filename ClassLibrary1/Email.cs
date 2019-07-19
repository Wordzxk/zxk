using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Email
    {
        public int Id { get; set; }
                       //地址
        public string Address { get; set; }
                       //确认代码
        public string ValidationCode { get; set; }
        public DateTime? HasValidated { get; set; }

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
