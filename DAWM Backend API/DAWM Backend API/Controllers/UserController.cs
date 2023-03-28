using DAWM_Backend_API.Core.Services;
using DAWM_Backend_API.DataLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAWM_Backend_API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private UserService userService { get; set; }

        public UserController(UserService _userService)
        {
            userService = _userService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<User>> GetAll()
        {
            var returned = userService.GetAll();
            return Ok(returned);
        }

        [HttpGet("/get/{userId}")]
        public ActionResult<User> GetById(int userId)
        {
            var returned = userService.GetById(userId);

            if (returned == null)
                return BadRequest("User does not exist!");

            return Ok(returned);
        }
    }
}
