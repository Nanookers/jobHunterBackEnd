using Microsoft.AspNetCore.Mvc;
using jobHunterBackEnd.Models;

namespace jobHunterBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobHunterController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public JobHunterController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Application> GetApplications()
        {
            return _context.Applications.ToList(); // Update this line
        }
    }
}
