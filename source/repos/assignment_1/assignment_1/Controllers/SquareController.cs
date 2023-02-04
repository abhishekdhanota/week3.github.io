using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        public int get(int id) 
        {
            int num = id * id;
            return num;
        }
    }
}
