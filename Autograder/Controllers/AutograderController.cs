using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autograder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutograderController : ControllerBase
    {
        private readonly ILogger<AutograderController> _logger;

        public AutograderController(ILogger<AutograderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Test()
        {
            int count = AutograderService.GetAllCountInArray();

            return Ok(count);
        }

    }
}
