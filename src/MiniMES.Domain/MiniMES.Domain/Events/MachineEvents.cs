using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Domain.Events
{
    public class MachineEvents
    {
        public event Action<string>? StatusChanged;
        public void Notify(string status)
        {
            StatusChanged?.Invoke(status);
        }
    }
}
