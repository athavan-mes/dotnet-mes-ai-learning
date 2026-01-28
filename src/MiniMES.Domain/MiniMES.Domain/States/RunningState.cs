using MiniMES.Domain.Machines;

namespace MiniMES.Domain.States;


public class RunningState : IMachineState
{
    public void Start(MachineContext context)
    {
        context.RaiseStatusChanged("Already Running");
    }


    public void Stop(MachineContext context)
    {
        context.SetState(new IdleState());
        context.RaiseStatusChanged("Stopped");
    }
}