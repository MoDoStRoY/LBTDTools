using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LBTDTools.ServerApp.Scripts.CreateDocuments;
using LBTDTools.ServerApp.Scripts.CreateDocuments.CreateAct;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;

#pragma warning disable 618

namespace LBTDTools
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection s)
        {
            #region MVC

            s.AddSingleton<IActMain, ActMain>();
            
            s.AddMvc(o =>
                {
                    o.EnableEndpointRouting = false;
                    o.ModelBinderProviders.Insert(0, new DateTimeModelBinderProvider());
                })
#if DEBUG
                //.AddRazorRuntimeCompilation()
#endif
                .AddMvcOptions(o =>
                {
                    o.CacheProfiles.Add("Image",
                        new CacheProfile()
                        {
                            Duration = 3600 * 24 * 7, VaryByQueryKeys = new[] {"*"}, NoStore = false,
                            Location = ResponseCacheLocation.Any
                        });
                })
                /*.AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                }) // disable camelCase and back to PascalCase*/
                .SetCompatibilityVersion(CompatibilityVersion.Latest);

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

#if DEBUG
            if (env.IsDevelopment())
            {
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true,
                    HotModuleReplacementEndpoint = "/dist/__webpack_hmr"
                });
                app.UseDeveloperExceptionPage();
            }
#endif

            app.UseRouting();

            //app.UseMiddleware<ExceptionFormatter>();

            app.UseHttpsRedirection()
                .UseStaticFiles();

            app.UseRouting();

            app.UseResponseCaching()
                .UseAuthentication()
                .UseAuthorization();

            app.UseEndpoints(ep =>
            {
                ep.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                ep.MapFallbackToController("Index", "Home");
            });
        }
    }
}