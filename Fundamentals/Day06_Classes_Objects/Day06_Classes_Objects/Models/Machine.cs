using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_Classes_Objects.Models
{
    public class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public long Produced { get; set; }

        public Machine(string id ,string name ,string status) 
        {
            Id = id;
            Name = name;
            Status = status;

        }

        public void Start()
        {
            Status = "Running";
        }

        public void Stop()
        {
            Status = "Stopped";
        }

        public void DisplayStatus () 
        {
            Console.WriteLine ($"{Id}-{Name} is {Status}");
        }

        public void AddProductionCount (int materialCount)
        {
            Produced += materialCount;
            
        }
    }
}
