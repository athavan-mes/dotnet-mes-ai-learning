using MiniMES.Application.Commands;
using MiniMES.Application.Factories;
using MiniMES.Domain.Events;
using MiniMES.Domain.Machines;



namespace MiniMES.Application.Services
{
    public class ProductionService
    {
        public int RunProduction(MachineType machineType,int input)
        {
            // observer
            var events = new MachineEvents();
            events.StatusChanged += (status) => 
            {
                Console.WriteLine($"Machine Status: {status}");
            };

            // Factory
            IMachine machine = MachineFactory.CreateMachine(machineType, events);

            // Commands
            ICommand start = new StartMachineCommands(machine);
            ICommand stop = new StopMachineCommand(machine);

            start.Execute();
            int output = machine.Produce(input);

            stop.Execute();

            return output;
        }
    }
}
