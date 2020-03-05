﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleCRM.Web
{
    public class Startup
    {
        //public Startup(IConfiguration config)
        //{
        //    Configuration = config;
        //}

        //public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IGreeter, ConfigurationGreeter>();
            services.AddScoped <ICustomerData, InMemoryCustomerData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            IGreeter greeter)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(new ExceptionHandlerOptions
                {
                    ExceptionHandler = context => context.Response.WriteAsync("Oops!")
                });
            }

            app.UseFileServer();

            app.UseMvc(ConfigureRoutes);

            app.Run(ctx => ctx.Response.WriteAsync("Not found"));
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            // /Home/Index
            // HomeController class, Index method

            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            routeBuilder.MapRoute("Address", "{controller=About}/{action=Address}/{id?}");
            routeBuilder.MapRoute("Phone", "{controller=About}/{action=Phone}/{id?}");
        }
    }
}
