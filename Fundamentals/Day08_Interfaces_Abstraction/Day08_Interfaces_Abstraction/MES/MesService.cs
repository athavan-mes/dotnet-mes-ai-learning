using Day08_Interfaces_Abstraction.Interfaces;

namespace Day08_Interfaces_Abstraction.MES
{
    /// <summary>
    /// Central MES orchestration service.
    ///
    /// RESPONSIBILITY:
    /// - Controls the lifecycle of machines (start / stop)
    /// - Coordinates optional machine capabilities
    /// - Does NOT know or care about concrete machine types
    ///
    /// DESIGN PRINCIPLES:
    /// - Depends only on interfaces (IMachine, IProductionMachine, IVisionMachine)
    /// - Uses capability-based checks instead of type checks
    /// - Easily extensible without modification
    /// </summary>
    public class MesService
    {
        /// <summary>
        /// Runs the MES workflow for a collection of machines.
        ///
        /// The MES treats all machines uniformly using IMachine.
        /// Optional behaviors are discovered at runtime using
        /// capability interfaces.
        /// </summary>
        /// <param name="machines">
        /// Collection of machines provided to MES.
        /// MES does not know their concrete implementations.
        /// </param>
        public void Run(IEnumerable<IMachine> machines)
        {
            foreach (var machine in machines)
            {
                // Display current status for monitoring
                machine.DisplayStatus();

                // MES controls machine lifecycle
                machine.Start();

                // Capability-based behavior: Production
                // Only machines that support production will participate
                if (machine is IProductionMachine productionMachine)
                {
                    productionMachine.AddProductionCount(10);
                }

                // Capability-based behavior: Vision
                // Only vision-enabled devices will execute this logic
                if (machine is IVisionMachine visionMachine)
                {
                    visionMachine.CaptureImage();
                }

                // Graceful shutdown handled uniformly
                machine.Stop();
            }
        }
    }
}
