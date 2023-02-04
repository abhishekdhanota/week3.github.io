using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public string get(int id)
        {
            int num = id * 10;
            int num1 = id + 10;
            int num2 = id / 2;
            int num3 = id % 3;
            return ("multiplication ="+ num +" "+"addition="+num1+" "+"division="+" "+num2+" "+"modulus="+" "+num3);   
        }
    }
}
