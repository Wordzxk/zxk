using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//暂时无用
namespace WebApplicationfirst
{
    /// <summary>
    /// pager指定tag的名字，Attribute指定tag里可以包含的属性
    /// </summary>
    [HtmlTargetElement("pager", Attributes = "pageUndex, path")]
    ///必须继承自TagHelper
    public class PagerTagHelper : TagHelper 
    {
        //context：能够获取attributes的信息
        //output：输出的原生html的标签
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            /* base.Process(context, output);   ???*/

            output.TagName = "a";//原声标签名
            //设置a标签里的href的值
            object pageIndex = context.AllAttributes["pageindex"].Value;
            object path = context.AllAttributes["path"].Value;
            output.Attributes.Add("href", $"{path}/page-{pageIndex}");
        }

    }
}
