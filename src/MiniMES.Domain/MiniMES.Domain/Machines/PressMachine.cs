using MiniMES.Domain.Events;
using MiniMES.Domain.States;
using MiniMES.Domain.Strategies;


namespace MiniMES.Domain.Machines;


public class PressMachine : IMachine
{
    public string MachineId { get; } = "PRESS-01";
    public MachineType Type => MachineType.PRESS;


    private readonly IProductionStrategy _strategy = new PressProductionStrategy();
    private readonly MachineContext _context;


    public PressMachine(MachineEvents events)
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