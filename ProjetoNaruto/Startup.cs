using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Impl;
using BLL.Interfaces;
using DAO;
using DAO.Impl;
using DAO.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ProjetoNaruto
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IGenninService, GenninService>();
            services.AddTransient<IGenninRepository, GenninRepository>();
            services.AddTransient<IJounninService, JounninService>();
            services.AddTransient<IJounninRepository, JounninRepository>();
            services.AddTransient<IEquipeService, EquipeService>();
            services.AddTransient<IEquipeRepository, EquipeRepository>();
            services.AddTransient<IKageService, KageService>();
            services.AddTransient<IKageRepository, KageRepository>();

            services.AddDbContextPool<ChuninContext>(c => c.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NarutoDb;Integrated Security=True;Connect Timeout=30;"));
            
            services.AddControllersWithViews();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Kage/Login";
                options.LogoutPath = "/Usuario/LogOff";
                options.Cookie.Name = "Kage";
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(" / Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
