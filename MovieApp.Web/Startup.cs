using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieApp.Web.Data;

namespace MovieApp.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MovieContext>(
            options => options.UseSqlServer(Configuration.GetConnectionString("MsSQLConnection")));

            services.AddControllersWithViews();


            ////Sistem seviyesinde Authorization 
            //services.AddMvc(config =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //       .Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});

            services.AddMvc();
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(x =>
                    {
                        x.LoginPath = "/Login/Index";
                    }
                );

            services.ConfigureApplicationCookie(options =>
                {
                    options.Cookie.HttpOnly=true;
                    options.LoginPath = "/Login/Index";
                    options.SlidingExpiration = true;
                }
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                DataSeeding.Seed(app);
            }
            app.UseStaticFiles(); // wwwroot klasörünü kullanýma açar

            app.UseAuthentication();
            
            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    //localhost:48862/{controller}/{action}
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"


                    );

            });
        }
    }
}
