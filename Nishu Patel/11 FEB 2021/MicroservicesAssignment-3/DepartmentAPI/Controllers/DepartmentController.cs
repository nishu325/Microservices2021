using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepartmentAPI.Services;
using DepartmentEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DepartmentAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : Controller
    {
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(ILogger<DepartmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet, Route("GetDepartments")]
        public IEnumerable<Department> GetDepartments()
        {
            return new DepartmentService().GetDepartment();
        }
    }
}
