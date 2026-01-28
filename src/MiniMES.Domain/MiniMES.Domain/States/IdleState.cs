using MiniMES.Domain.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Domain.States
{
    public class IdleState : IMachineState
    {
        public void Start(MachineContext context)
        {
            // Transition to RunningState
            context.SetState(new RunningState());
            context.RaiseStatusChanged("Machine started and is now running.");
        }

        

        public void Stop(MachineContext context)
        {
            // Already in IdleState, no action needed
            context.RaiseStatusChanged("Machine is already idle.");
        }

        
    }
}
