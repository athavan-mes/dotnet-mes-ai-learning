using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Value_vs_Reference_Types.Model
{
    public class MachineBase
    {
        public string Id { get; set; }
        public string Status { get; set; }

        public long PartsProcessed { get; set; }

        public MachineBase(string id, string status)
        {
            Id = id;
            Status = status;
            PartsProcessed = 0;


        }
        
    }
}
