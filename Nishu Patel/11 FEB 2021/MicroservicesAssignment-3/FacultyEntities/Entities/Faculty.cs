using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyEntities.Entities
{
    public class Faculty
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public double Salary { get; set; }
        public Course Course { get; set; }
    }
}
