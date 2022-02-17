using Bll.Service;
using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Util.Log;

namespace JW
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
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));
            services.AddControllersWithViews();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();       
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();
            app.UseRequestResponseLogging();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            //获取系统路由
            Jw_MapControllerRouteService mapControllerRouteService = new Jw_MapControllerRouteService();
            var mapControllerRouteList = mapControllerRouteService.GetMapControllerRouteList();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("news", "/news{param1}/list_{param2}.html", new
                {
                    controller = "NewsClassList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+", param2 = @"\w+" }
                });
                endpoints.MapControllerRoute("game", "/game/{param1}.html", new
                {
                    controller = "GameDetails",
                    action = "Index"
                });
                endpoints.MapControllerRoute("gamelist", "/game{param1}/{param2}.html", new
                {
                    controller = "GameClassList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+", param2 = @"\w+" }
                });

                endpoints.MapControllerRoute("gamelist", "/game{param1}/", new
                {
                    controller = "GameClassList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+" }
                });




                endpoints.MapControllerRoute("Topic", "/topic{param1}/", new
                {
                    controller = "Topic",
                    action = "Index",
                    constraints = new { param1 = @"^\w+" }
                });

                endpoints.MapControllerRoute("TopicList", "/type{param1}/", new
                {
                    controller = "TopicList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+" }
                });

                endpoints.MapControllerRoute("TopicList", "/type{param1}/list_{param2}.html", new
                {
                    controller = "TopicList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+", param2 = @"\w+" }
                });


                endpoints.MapControllerRoute("news", "/news/{param1}.html", new
                {
                    controller = "NewsDetails",
                    action = "Index",
                    constraints = new { param1 = @"^\d+" }
                });
                endpoints.MapControllerRoute("news", "/news/", new
                {
                    controller = "News",
                    action = "Index"
                });
                endpoints.MapControllerRoute("news", "/news/{param1}/", new
                {
                    controller = "News",
                    action = "Index",
                    constraints = new { param1 = @"^\d+" }
                });


                endpoints.MapControllerRoute("NewsClass", "/newsclass/{param1}/", new
                {
                    controller = "NewsClassList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+" }
                });

                endpoints.MapControllerRoute("NewsClass", "/newsclass/{param1}/{param2}.html", new
                {
                    controller = "NewsClassList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+", param2 = @"\d+" }
                });





                endpoints.MapControllerRoute("AzGame", "/azgame/", new
                {
                    controller = "AzGame",
                    action = "Index",

                });


                endpoints.MapControllerRoute("FactoryHouseDetails", "/changfangchuzu/{param1}.html", new
                {
                    controller = "FactoryHouseDetails",
                    action = "Index",
                    constraints = new { param1 = @"^\d+" }
                });

                endpoints.MapControllerRoute("FactoryHouseList", "/changfang/", new
                {
                    controller = "FactoryHouseList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+" }
                });

                endpoints.MapControllerRoute("AzGameClassList", "/azgmcs/{param1}/{param2}.html", new
                {
                    controller = "AzGameClassList",
                    action = "Index",
                    constraints = new { param1 = @"^\w+", param2 = @"\d+" }
                });
 
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                });


             



        }
    }
}
