using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BAB.OWIN.Example.Controllers
{
    [System.Web.Http.RoutePrefix("api")]

    public class HelloWorldWebApiController : ApiController
    {
        [System.Web.Http.Route("hello")]
        [HttpGet]
        public IHttpActionResult HelloWorld()
        {
            return Content(System.Net.HttpStatusCode.OK, "Hello from Web Api!");
        }
    }
}
