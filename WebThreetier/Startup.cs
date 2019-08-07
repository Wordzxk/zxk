using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Repositorys;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SRV;

namespace WebThreetier
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //session需要地方（MemoryCache）存放
            services.AddService();
            services.AddRepositories();

            services.AddScoped<DbContext, SQLContext>();

            //services.AddHttpContextAccessor();
            //引入session
            services.AddSession(option =>
            {
                ////自定义session的cookie的名字
                //option.Cookie = new CookieBuilder
                //{
                //    Name = "MySessionId",
                //    //确保session的cookie不受cookie policy影响
                //    IsEssential = true
                //};
                //session的有效时间，从上一次session的时间算起
                option.IdleTimeout = new TimeSpan(0, 10, 0);
            });
           
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseHttpsRedirection();   //这是后添加上的
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.UseSession();            //这是后添加上的

            app.UseMvc();
        }
    }
}
