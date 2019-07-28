using AutoMapper;
using BLL;
using BLL.Repositorys;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SRV.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    //暂未解决
    public class BaseService
    {
        protected UserRepository userRepository;
        protected IHttpContextAccessor accessor;

        protected static MapperConfiguration autoMapperConfig;


        public BaseService(IHttpContextAccessor accessor,
            UserRepository userRepository)
        {
            this.accessor = accessor;
            this.userRepository = userRepository;
        }
        protected User currentUser
        {
            get
            {
                //从_accessor中取出HTTPContext
                string fromSession = accessor.HttpContext.Session.GetString("UserName");
                if (string.IsNullOrEmpty(fromSession))
                {
                    return null;
                }
                int currentUserId = JsonConvert.DeserializeObject<UserModel>(fromSession).Id;
                return userRepository.GetById(currentUserId);
            }
        }

    }
}