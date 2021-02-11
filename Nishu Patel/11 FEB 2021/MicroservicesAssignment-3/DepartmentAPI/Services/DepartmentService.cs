using DepartmentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentAPI.Services
{
    public class DepartmentService
    {
        public List<Department> GetDepartment()
        {
            var department = new List<Department>();
            for(int i=1;i<5;i++)
            {
                department.Add(new Department
                {
                    Id=i,
                    Name=$"Department_{i}",
                    Location=$"Location_{i}"
                });
            }
            return department;

        }
    }
}
