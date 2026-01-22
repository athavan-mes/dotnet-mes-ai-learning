using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Value_vs_Reference_Types.Structs
{
    public struct MachineState
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public long PartsProcessed { get; set; }
        public MachineState(string id, string status)
        {
            Id = id;
            Status = status;
            PartsProcessed = 0;
        }
    }
}
