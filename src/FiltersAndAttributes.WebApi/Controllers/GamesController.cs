using Microsoft.AspNetCore.Mvc;
using FiltersAndAttributes.WebApi.Attributes;

namespace FiltersAndAttributes.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[LogStatus("GamesController:")]
public class GamesController : ControllerBase
{

    [HttpGet]
    [LogStatus("Get:")]
    [CustomAuthorize]
    public IActionResult Get()
    {
        Console.WriteLine("Executing Get");
        return Ok();
    }

}
