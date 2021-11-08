using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8.Controllers
{

    [ApiController]
    [Route("Test/[action]")]
    public class TestController
         : ControllerBase
    {


        public string Get()
        {
            return "ITI Sohag";
        }


        public string Get2()
        {
            return "ITI Sohag again";
        }
    }
}
