using System.Threading.Tasks;
using AutoMapper;
using jwt_api.Controllers.Resources;
using jwt_api.Core.Domain.Models;
using jwt_api.Core.Domain.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace jwt_api.Controllers
{
    [Route("/api/[controller]")]
    [EnableCors("AllowSpecificOrigins")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        public readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync([FromBody] UserCredentialsResource userCredentials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _mapper.Map<UserCredentialsResource, User>(userCredentials);

            var response = await _userService.CreateUserAsync(user, ERole.User);

            if (!response.Success)
            {
                return BadRequest(response.Message);
            }

            var userResource = _mapper.Map<User, UserResource>(response.User);
            return Ok(userResource);
        }
    }
}