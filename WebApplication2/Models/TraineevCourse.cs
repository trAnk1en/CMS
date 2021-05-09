using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class TraineevCourse
    {
        public int TraineeID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public Trainee Trainee { get; set; }
    }
}
