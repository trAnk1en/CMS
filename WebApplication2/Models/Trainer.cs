using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Trainer: User
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string WorkingPlace { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public ICollection<TopicTrainer> TopicTrainers { get; set; }
    }
}
