using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    public class GreetController : ApiController
    {
        public string get (int id)
        {
            int num = id;
            return "Greetings to"+" "+id+" "+"people!";
        }
    }
}
