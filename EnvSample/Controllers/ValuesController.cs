using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EnvSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                hostname = Environment.GetEnvironmentVariable("HOSTNAME") ?? "null",
                nodename = Environment.GetEnvironmentVariable("MY_NODE_NAME") ?? "null",
                pod = new
                {
                    @namespace = Environment.GetEnvironmentVariable("MY_POD_NAMESPACE") ?? "null",
                    name = Environment.GetEnvironmentVariable("MY_POD_NAME") ?? "null",
                    service_account = Environment.GetEnvironmentVariable("MY_POD_SERVICE_ACCOUNT") ?? "null",
                    ip = Environment.GetEnvironmentVariable("MY_POD_IP") ?? "null"
                }
            });
        }
    }
}
