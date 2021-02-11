using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Services
{
    public class StudentService
    {
        public List<Student> GetStudent()
        {
            var student = new List<Student>();
            for (int i= 1;i< 5; i++)
            {
                student.Add(new Student
                {
                    Id = i,
                    Name=$"Student_Name_{i}",
                    City=$"City_{i}",
                    ContactNo=$"ContactNo_{i}"


                }) ;
            }

            return student;
        }
       

       
    }
}
