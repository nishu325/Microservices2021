using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacultyAPI.Services;
using FacultyEntities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FacultyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacultyController : Controller
    {
        private readonly ILogger<FacultyController> _logger;

        public FacultyController(ILogger<FacultyController> logger)
        {
            _logger = logger;
        }

        [HttpGet, Route("GetFaculties")]
        public IEnumerable<Faculty> GetFaculties()
        {
            return new FacultyServices().GetFaculties();
        }

    }
}
