using Microsoft.AspNetCore.Mvc;

namespace MVCMongoDB.Controllers
{
    [Route("/")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
 
        [HttpGet]
        public string Index()
        {
            return "Running ... ";
        }
    }

}