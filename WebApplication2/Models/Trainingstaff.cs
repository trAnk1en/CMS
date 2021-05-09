using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Trainingstaff: User
    {
        public string Name { get; set; }
        public string Edu { get; set; }
        public string Experience { get; set; }
        public string Department { get; set; }
        public ICollection<Categories> Categories { get; set; }
    }
}
