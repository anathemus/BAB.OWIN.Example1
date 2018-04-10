using System;
using Owin;
using System.Diagnostics;

namespace BAB.OWIN.Example
{
    public class Startup
    {
       
            public static void Configuration(IAppBuilder app)
            {
            app.Use(async (ctx, next) => {
                Debug.WriteLine("Incoming Request: " + ctx.Request.Path);
                await next();
                Debug.WriteLine("Outgoing Request: " + ctx.Request.Path);
            });

                app.Use(async (ctx, next) => {
                    await ctx.Response.WriteAsync("<html><head></head><body>Hello World</body></html>");
                });
            }

    }
}
