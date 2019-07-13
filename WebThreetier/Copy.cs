using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebThreetier
{
    public class Copy : RequiredAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return $"{name}必须填写";
        }
    }
   
}
