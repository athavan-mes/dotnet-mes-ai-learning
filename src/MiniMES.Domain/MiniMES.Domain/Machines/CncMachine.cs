using MiniMES.Domain.Events;
using MiniMES.Domain.States;
using MiniMES.Domain.Strategies;


namespace MiniMES.Domain.Machines
{
    public class CncMachine : IMachine
    {
        public string MachineId { get; } = "CNC-01";
        public MachineType Type => MachineType.CNC;

        private readonly MachineContext _context;
        private readonly IProductionStrategy _strategy = new CncProductionStrategy();

        public CncMachine(MachineEvents events)
        {
            _context = new MachineContext(new IdleState(), events);
        }

        public void Start() => _context.Start();
        public void Stop() => _context.Stop();

        public int Produce(int input)
        {
            return _strategy.Calculate(input);
        }
    }
}
