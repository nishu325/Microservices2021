using FacultyEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyAPI.Services
{
    public class FacultyServices
    {
        public List<Faculty> GetFaculties()
        {
            var faculty = new List<Faculty>();
            for (int i = 1; i < 5; i++)
            {
                faculty.Add(new Faculty
                {
                    Id = i,
                    Course = new Course
                    {
                        Id = i,
                        Name = $"Course_{i}",
                        EndDate = DateTime.Now ,
                        StartDate=DateTime.UtcNow
                    },
                    Qualification = $"Qualification_{i}",
                    Salary = i * 1000,
                    Name = $"Faculty_Name_{i}"

                }) ;

            }
            return faculty;
        }
    }
}
