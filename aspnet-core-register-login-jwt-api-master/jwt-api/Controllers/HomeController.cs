using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace jwt_api.Controllers
{
    [EnableCors("AllowSpecificOrigins")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Authorize]
        [Route("/api/homeuserdata")]
        public IActionResult GetDataUser()
        {
            return Ok("Hello User.");
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        [Route("api/homeadmindata")]
        public IActionResult GetDataAdmin()
        {
            return Ok("Hello Admin.");
        }
    }
}