using System;
using Owin;
using System.Diagnostics;
using BAB.OWIN.Example.Middleware;

namespace BAB.OWIN.Example
{
    public class Startup
    {
       
            public static void Configuration(IAppBuilder app)
            {
            app.Use<DebugMiddleware>();
                
                app.Use(async (ctx, next) => {
                    await ctx.Response.WriteAsync("<html><head></head><body>Hello World</body></html>");
                });
            }

    }
}
