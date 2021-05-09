using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Topic
    {
        public int TopicID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public ICollection<TopicTrainer> TopicTrainers { get; set; }
        public Course Course { get; set; }
    }
}
