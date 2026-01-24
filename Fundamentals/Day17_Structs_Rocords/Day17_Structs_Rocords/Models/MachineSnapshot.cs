using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Structs_Rocords.Models
{
    public record MachineSnapshot(string Id, string Status, long PartsProcessed);
}
