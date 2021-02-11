using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.HttpAggregator.Util;

namespace Web.HttpAggregator.Controllers
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
        [HttpGet, Route("GetFaculties")]
        public async Task<IEnumerable<DropdownDto>> GetFaculties()
        {
            var faculties = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:44358/Faculty/GetFaculties");
           
            return faculties;
        }

        [HttpGet, Route("GetDepartments")]
        public async Task<IEnumerable<DropdownDto>> GetDepartments()
        {
            var departments = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:44318/Department/GetDepartments");
           
            return departments;
        }

        [HttpGet, Route("GetStudents")]
        public async Task<IEnumerable<DropdownDto>> GetStudents()
        {
            var students = await HttpCall.GetRequest<List<DropdownDto>>("https://localhost:44374/Student/GetStudents");

            return students;
        }
    }
}
