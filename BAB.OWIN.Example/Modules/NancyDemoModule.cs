using System;
using Nancy;
using Nancy.Owin;

namespace BAB.OWIN.Example.Modules
{
    public class NancyDemoModule : NancyModule
    {
        public NancyDemoModule()
        {
            Get["/nancy"] = x => {
                var env = Context.GetOwinEnvironment();
                return "Hello from Nancy! Your requested: " + env["owin.RequestPath"];
            };
        }
    }
}
