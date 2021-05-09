using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class TopicTrainer
    {
        public int TopicID { get; set; }
        public int TrainerID { get; set; }
        public Trainer Trainer { get; set; }
        public Topic Topic { get; set; }
    }
}
