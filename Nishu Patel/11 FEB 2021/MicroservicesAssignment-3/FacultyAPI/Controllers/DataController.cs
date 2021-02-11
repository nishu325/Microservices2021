using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonObjects.Models;
using FacultyAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FacultyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : Controller
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get orders
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetFaculties")]
        public IEnumerable<DropdownDto> GetFaculties()
        {
            return new FacultyServices().GetFaculties().Select(r => new DropdownDto { id = r.Id, Name = r.Name });
        }
    }
}
