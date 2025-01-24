using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: localhost:xx/api/Test -> 4
        // GET: localhost:xx/api/Test/7 -> 7
        // GET: localhost:xx/api/Test/{id} -> {id}
        [HttpGet(template:"/api/Test/{id}")]
        public int Get(int id)
        {
            int difference = id - 1;
            return difference;
        }

    }
}
