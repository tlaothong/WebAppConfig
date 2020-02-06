using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

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