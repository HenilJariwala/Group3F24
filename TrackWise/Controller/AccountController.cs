using Microsoft.AspNetCore.Mvc;
using Group3F24.TrackWise.Model;

namespace TrackWise.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterModel model)
        {
            // Registration logic goes here
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Assume registration is successful
            return Ok(new { message = "User registered successfully" });
        }
    }
}
