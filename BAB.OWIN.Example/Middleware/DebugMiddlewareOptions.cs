using System;
using Microsoft.Owin;

namespace BAB.OWIN.Example.Middleware
{
    public class DebugMiddlewareOptions
    {
        public Action<IOwinContext> OnIncomingRequest { get; set; }

        public Action<IOwinContext> OnOutgoingRequest { get; set; }

        public DebugMiddlewareOptions()
        {
            
        }
    }
}
