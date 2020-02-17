using System;
using Microsoft.AspNetCore.Mvc;

namespace hello1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get() => "Hello world! v1";
    }
}
