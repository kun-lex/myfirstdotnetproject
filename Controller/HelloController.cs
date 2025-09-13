using Microsoft.AspNetCore.Mvc;

namespace myfirstdotnetproject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { message = "Hello from .NET 9 with Controllers!" });
}
