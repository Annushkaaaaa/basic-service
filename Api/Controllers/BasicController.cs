using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

//[Authorize]
[Route("api")]
public class BasicController : Controller
{
    public BasicController()
    {
    }

    [HttpGet("get")]
    public async Task<object> Get()
    {
        return Ok();
    }
}