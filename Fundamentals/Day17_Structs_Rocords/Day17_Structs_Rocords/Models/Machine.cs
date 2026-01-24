using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Structs_Rocords.Models
{
    public class Machine
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public long PartsProcessed { get; set; }

        public Machine(string id, string status, long partsProcessed)
        {
            Id = id;
            Status = status;
            PartsProcessed = partsProcessed;
        }
        public void Produce(int parts)
        {
            PartsProcessed += parts;
        }
    }
}
