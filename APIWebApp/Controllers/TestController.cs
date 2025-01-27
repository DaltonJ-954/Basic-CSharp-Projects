using Microsoft.AspNetCore.Mvc;

namespace APIWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "GetInteger")]
        public int Get()
        {
            return 1978;
        }

        [HttpPost(Name = "PostInteger")]
        public int Post()
        {
            return 2024;
        }
    }
}
