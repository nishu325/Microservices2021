using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentAPI.Services;
using StudentEntities.Entities;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
                
        }
        [HttpGet, Route("GetStudents")]
        public IEnumerable<Student> Get()
        {
            return new StudentService().GetStudent();
        }
       

    }
}
