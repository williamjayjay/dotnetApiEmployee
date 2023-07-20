using Microsoft.AspNetCore.Mvc;
using SegundaAPI.Model;
using SegundaAPI.Services;

namespace SegundaAPI.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if(username == "william" && password == "12345678")
            {
                var token = TokenService.GenerateToken(new Employee("teste", 10, "image/teste"));
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
