using BLL.Repositorys;
using SRV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    //用扩展方法添加生命周期与依赖注入的映射关系
    public static class ServiceExtension
    { 
        public static void AddMockService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, MockUserService>();
        }
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<ISuggestService, SuggestService>();

        }
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<UserRepository, UserRepository>();
            services.AddScoped<SuggestRepository, SuggestRepository>();
            services.AddScoped<EmailRepository, EmailRepository>();
        }
         
    }
}
