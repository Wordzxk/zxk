
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_UI.Filters
{
    
    public class NeedLogOnAttribute : AuthorizeAttribute
    {
        public const string USER_ID = "UserId";
        public const string USER_PASSWORD = "UserPassword";
        //授权
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpContextBase context = filterContext.HttpContext;
            HttpCookie cookieUser = context.Request.Cookies[USER_ID];
            if (cookieUser!=null)
            {
                int userId = Convert.ToInt32(cookieUser.Value);
                User user = GetUser(userId);
                if (user !=null)
                {

                }
            }
            //记住当前页面
            string currentPath = context.Request.Url.PathAndQuery;
            //存cookie
            context.Response.Cookies.Add(new HttpCookie("PrePage", currentPath));

            //进入错误页面
            filterContext.Result = new RedirectResult("/Register/Index");
            //base.OnAuthorization(filterContext);
        }

        private User GetUser(int userId)
        {
            return new User();
        }

        
        public class User
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public bool MD5Password { get; set; }
        }

    }
}