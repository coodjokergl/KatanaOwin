using System;
using Microsoft.Owin;
using Owin;
using OwinSelfHost.AppCode;

[assembly: OwinStartup(typeof(StartupOwin))]

namespace OwinSelfHost.AppCode
{
    public class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888

            app.UseErrorPage();
           
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello world.");
            });

            //app.Use((c,t) =>
            //{
            //    c.Response.ContentType = "text/plain";
            //    return c.Response.WriteAsync("Hello world.");
            //});
        }
    }
}
