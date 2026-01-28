using MiniMES.Domain.Machines;

namespace MiniMES.Domain.States;

public interface IMachineState
{
     void Start(MachineContext context);
    void Stop(MachineContext context);
}
