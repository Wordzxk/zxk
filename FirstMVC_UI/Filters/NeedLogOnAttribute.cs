using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Filters
{
    //缺少页面,Controller类
    public class NeedLogOnAttribute : AuthorizeAttribute
    {
        //授权
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }
    }
}