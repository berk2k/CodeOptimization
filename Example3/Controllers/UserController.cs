using Microsoft.AspNetCore.Mvc;
using Example3.Models;
using Example3.Services;

namespace Example3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserViewModel>> GetUsers()
        {
            var users = userService.GetUsersAsync();
                            

            return Ok(users);
        }
        //[HttpGet("GetUsers")]
        //public ActionResult<List<UserViewModel>> GetUsers()
        //{
        //    var users = userService
        //                    .GetUsersAsync()
        //                    .ToList();

        //    return Ok(users);
        //}

        [HttpPost]
        public ActionResult<bool> CreateUser([FromBody] CreateUserRequestModel user)
        {
            var isUserCreated = userService.CreateUser(user);
            return Ok(isUserCreated);
        }
        //[HttpPost("CreateUser")]
        //public void CreateUser([FromQuery] UserViewModel user)
        //{
        //    _ = userService.CreateUser(user);
        //}
    }
}
