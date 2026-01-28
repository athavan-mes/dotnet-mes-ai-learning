using MiniMES.Domain.Events;
using MiniMES.Domain.States;

namespace MiniMES.Domain.Machines;

public class MachineContext
{
    private IMachineState _currentState;
    private readonly MachineEvents _events;

    public MachineContext(IMachineState initialState, MachineEvents events)
    {
        _currentState = initialState;
        _events = events;
    }

    public void SetState(IMachineState newState)
    {
        _currentState = newState;
    }

    public void Start() => _currentState.Start(this);
    public void Stop() => _currentState.Stop(this);

    public void RaiseStatusChanged(string status)
    {
        _events.Notify(status);
    }
}
