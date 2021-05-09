using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<TraineevCourse> TraineevCourses { get; set; }
        public Categories Categories { get; set; }
    }
}
