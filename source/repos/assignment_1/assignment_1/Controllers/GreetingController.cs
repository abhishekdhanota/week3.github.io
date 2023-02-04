using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        public string post()
        {
             return "hello world";
        }
    }
}
