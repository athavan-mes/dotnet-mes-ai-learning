using MiniMES.Domain.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Application.Commands
{
    public class StopMachineCommand :ICommand
    {
        private readonly IMachine _machine;
        public StopMachineCommand(IMachine machine)
        {
            _machine = machine;
        }
        public void Execute()
        {
            _machine.Stop();
        }
        }
}
