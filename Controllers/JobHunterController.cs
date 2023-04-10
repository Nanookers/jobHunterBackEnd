using Microsoft.AspNetCore.Mvc;

namespace jobHunterBackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class JobHunterController : ControllerBase
{
    private readonly ILogger<JobHunterController> _logger;

    public JobHunterController(ILogger<JobHunterController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Application> Get()
    {
        return null;
    }
}
