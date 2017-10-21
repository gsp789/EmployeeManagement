using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using EmployeeUti.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeUtil
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=LAPTOP-D8N1NPGG\MSSQLSERVER1;Database=iCPMS_OMTI_FZ;Integrated Security=True;";
            services.AddDbContext<OMTIDBContext>(options => options.UseSqlServer(connection));
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseStaticFiles();
            app.UseMvc(config =>
            {
                config.MapRoute(
                   name: "default",
                   template: "{controller}/{action}/{id?}",
                   defaults: new { controller = "UserLogin", action = "Index" }
                    );
            });
        }
    }
}
