using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Categories
    {
        public int CategoriesID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public Trainingstaff Trainingstaff { get; set; }
    }
}
