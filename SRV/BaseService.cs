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
        //protected UserRepository userRepository;
        //protected IHttpContextAccessor accessor;
        //protected static MapperConfiguration autoMapperConfig;

        //在静态构造函数里进行AutMapper配置
        //static BaseService()
        //{
        //    autoMapperConfig = new MapperConfiguration(gg =>
        //    {
        //        gg.CreateMap<Suggest, DTOSuggest>()
        //        .ForMember(s => s.Body, opt => ignore());
        //    });
        //}
        //引入mapper属性使子类可以使用
        //protected IMapper mapper
        //{
        //    get
        //    {
        //        return autoMapperConfig.CreateMapper();
        //    }
        //}

        //public BaseService(IHttpContextAccessor accessor,
        //    UserRepository userRepository)
        //{
        //    this.accessor = accessor;
        //    this.userRepository = userRepository;
        //}
        //protected User currentUser
        //{
        //    get
        //    {
        //        //从_accessor中取出HTTPContext
        //        string fromSession = accessor.HttpContext.Session.GetString("UserName");
        //        if (string.IsNullOrEmpty(fromSession))
        //        {
        //            return null;
        //        }
        //        int currentUserId = JsonConvert.DeserializeObject<UserModel>(fromSession).Id;
        //        return userRepository.GetById(currentUserId);
        //    }
        //}

    }
}