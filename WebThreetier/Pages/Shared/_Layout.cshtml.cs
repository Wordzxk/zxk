using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SRV;
using SRV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebThreetier.Pages.Shared
{
    [BindProperties]
    public class _LayoutModel : PageModel
    {
        protected const string userIdKey = "userId";
        protected const string userAuthKey = "userAuth";

         public virtual void OnGet()
        {
            string userIdvalue;
            if (Request.Cookies.TryGetValue(userIdKey, out userIdvalue))
            {
                UserModel model = new UserService().GetById(Convert.ToInt32(userIdvalue));
                if (model != null)
                {
                    if (Request.Cookies.TryGetValue(userAuthKey, out string userAuthValue))
                    {
                        if (userAuthValue == model.MD5Password)
                        {
                            ViewData["UserName"] = model.Name;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
        }

        public int? CurrentUserId 
        {
            get
            {
                //空
                string fromSession = HttpContext.Session.GetString("UserName");
                if (string.IsNullOrEmpty(fromSession))
                {
                    return null;
                }
                return JsonConvert.DeserializeObject<UserModel>(fromSession).Id;
            }
        }

    }
}
