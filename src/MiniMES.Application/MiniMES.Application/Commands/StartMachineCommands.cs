using MiniMES.Domain.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Application.Commands
{
    public class StartMachineCommands : ICommand
    {
        private readonly IMachine _machine;

        public StartMachineCommands(IMachine machine) {
            _machine = machine;
        }
        public void Execute()
        {
            _machine.Start();

        }

    }
}
