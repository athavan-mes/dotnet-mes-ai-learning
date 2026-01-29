using MiniMES.Domain.Events;
using MiniMES.Domain.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Application.Factories
{
    public static class MachineFactory
    {
        public static IMachine CreateMachine(MachineType type, MachineEvents events)
        {
            return type switch
            {
                MachineType.CNC => new CncMachine(events),
                MachineType.PRESS => new PressMachine(events),
                _ => throw new ArgumentException("Invalid machine type"),
            };
        }
    }
}
