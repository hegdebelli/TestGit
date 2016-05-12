using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplication
{
    public class Student
    {
        public int Id { get; set; }
        public string StudName { get; set; }
        public string StudAddress { get; set; }
        //public string Course { get; set; }

        //public virtual ICollection<Department> Department { get; set; }
        // For Forgin key navigation property
        public virtual Department Departments { get; set; }
        public virtual Course Courses { get; set; }
    }
}