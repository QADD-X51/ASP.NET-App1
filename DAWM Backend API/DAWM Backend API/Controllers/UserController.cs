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

        [HttpGet("/user/get-all")]
        public ActionResult<List<User>> GetAll()
        {
            var returned = userService.GetAll();
            return Ok(returned);
        }

        [HttpGet("/user/get/{userId}")]
        public ActionResult<User> GetById(int userId)
        {
            var returned = userService.GetById(userId);

            if (returned == null)
                return BadRequest("User does not exist!");

            return Ok(returned);
        }

        [HttpPost("/user/add")]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            if (user == null) return BadRequest("User can't be null!");

            if (!userService.AddUser(user))
                return BadRequest("Something went wrong adding new user.");

            return Ok("User added!");
        }

        [HttpDelete("/user/del/{userId}")]
        public ActionResult<User> DeleteUserById(int userId)
        {
            if (!userService.DeleteUser(userId))
                return BadRequest("Could not remove user.");
            return Ok("User banished!");
        }

        [HttpPut("/user/edit/{userId}")]
        public ActionResult<User> EditUserById(int userId, [FromBody] User newUser)
        {
            if (!userService.EditUser(userId, newUser))
                return BadRequest("Something went wrong!");

            return Ok("User modified");
        }
    }
}
