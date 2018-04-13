using System;
using Owin;
using System.Diagnostics;
using Nancy.Owin;
using BAB.OWIN.Example.Middleware;
using Nancy;
using System.Web.Http;

namespace BAB.OWIN.Example
{
    public class Startup
    {
       
            public static void Configuration(IAppBuilder app)
            {
            app.UseDebugMiddleware(new DebugMiddlewareOptions
            {
                OnIncomingRequest = (ctx) =>
                {
                    var watch = new Stopwatch();
                    watch.Start();
                    ctx.Environment["DebugStopwatch"] = watch;
                },

                OnOutgoingRequest = (ctx) =>
                {
                    var watch = (Stopwatch)ctx.Environment["DebugStopwatch"];
                    watch.Stop();
                    Debug.WriteLine("Request took: " + watch.ElapsedMilliseconds + " ms");
                }
            });

            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            app.UseWebApi(config);

            // app.Map("/nancy", mappedApp => { mappedApp.UseNancy(); });
            app.UseNancy(conf => {
                conf.PassThroughWhenStatusCodesAre(HttpStatusCode.NotFound);
            });
                
                app.Use(async (ctx, next) => {
                    await ctx.Response.WriteAsync("<html><head></head><body>Hello World</body></html>");
                });
            }

    }
}
