using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Trainee: User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Education { get; set; }
        public int TOEICScore { get; set; }
        public string Location { get; set; }
        public ICollection<TraineevCourse> TraineevCourses { get; set; }
    }
}
