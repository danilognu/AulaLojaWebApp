﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaLojaWebApp.AcessosDados;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AulaLojaWebApp
{
    public class Startup
    {
        private IConfiguration _configuration;


        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true)
                .AddJsonFile("config.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //var connection = @"Server=(localdb)\mssqllocaldb;Database=bd_endividamento;Trusted_Connection=True;ConnectRetryCount=0";
            //services.AddDbContext<MyWebAppContext>(options => options.UseSqlServer(connection));

            var sqlConnection = _configuration.GetConnectionString("MyWebAppDB");
            services.AddDbContext<MyWebAppContext>(options => options.UseSqlServer(sqlConnection, b => b.MigrationsAssembly("AulaLojaWebApp")  ));

            services.AddMvc();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();


            //var sqlConnection = _configuration.GetConnectionString("MyWebAppDB");
            //services.AddDbContext<MyWebAppContext>(optins => optins.UseMySql());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            
            /* if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}
