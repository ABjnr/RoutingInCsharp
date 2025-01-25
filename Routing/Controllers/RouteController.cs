using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {

        // GET: localhost:xx/api/Route/Get1 -> "Routing 1"

        [HttpGet(template:"Get1")]

        public string Get1() 
        {
            return "Routing 1";
        }

        // GET : localhost:xx/api/Route/Get2 -> "Routing 2"
        [HttpGet(template: "Get2")]
        public string Bananas() 
        {

            return "Routing 2";
        
        }

        // GET: localhost:xx/api/Route/Get2 -> "Routing 2"
        [HttpGet(template:"Get3")]

        public string Get3()
        {
            return "Routing 3";
        }

        // POST : localhost:xx/api/route/post1 -> "Post Request 1"
        [HttpPost(template:"Post1")] // doesn't work as a url, browsers only do GET request
        // POST requests are handled mostly through forms, nor url. It is to add data
        public string Get3([FromBody]string Animal)
        {
            ///
            /// -X "POST" -H "COntent-Type: application/json" -d "\"Almonds"\" "https://localhost:xx/api/route/post1"
            ///-d (represents data and the quotes after is for the body of the data)
            ///-H (represents HEADER)
            /// 
            /// FORM DATA / REQUEST BODY: Cat -> "Your favorite animal is Cat
            ///

            
            return "Your favorite animal is " + Animal;
        }
    }
}
