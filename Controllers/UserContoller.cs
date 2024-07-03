using Microsoft.AspNetCore.Mvc;
using WebAppForDocker.Abstraction.Repository;
using WebAppForDocker.Dto;
using WebAppForDocker.Models;

namespace WebAppForDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("add_user")]
        public ActionResult<int> AddUser(UserDto user)
        {
            try
            {
                return Ok(_repository.AddUser(user));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<RoleId> CheckUser(LoginDto login)
        {
            try
            {
                return Ok(_repository.CheckUser(login));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }
    }
}
