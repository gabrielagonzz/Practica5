using Microsoft.AspNetCore.Mvc;
using Practica5.Interfaz;
using Practica5.Models;

namespace Practica5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly IUserRepository userRepository;

        public LoginController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User loginModel)
        {
            var user = userRepository.GetAllUsers()
               .FirstOrDefault(u => u.Name == loginModel.Name && u.Password == loginModel.Password);

            if (user == null)
            {
                return BadRequest(new { success = false, message = "Invalid name or password." });
            }

            return Ok(new { success = true, message = "Successful login!" });
        }
    }
}
