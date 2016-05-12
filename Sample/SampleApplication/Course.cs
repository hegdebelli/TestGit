using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplication
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}