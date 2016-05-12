using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplication
{
    public class StudentRepository
    {
        public List<Student> GetStudents()
        {
            var studentDbContext = new StudentDbContext();
            return studentDbContext.Students.Include("Courses").ToList();      
        }
    }
}