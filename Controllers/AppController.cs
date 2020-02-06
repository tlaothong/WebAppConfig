using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebAppConfig.Controllers
{
    [ApiController]
    [Route("/")]
    public class AppController : ControllerBase
    {
        private readonly IConfiguration config;

        public AppController(IConfiguration config)
        {
            this.config = config;
        }

        [HttpGet("")]
        public string GetRootContent() => GetContent(string.Empty);
        [HttpGet("{id}")]
        public string GetContent(string id) => config["ManaAppConfig"];
    }
}