using Day08_Interfaces_Abstraction.Interfaces;
using Day08_Interfaces_Abstraction.Machines;
using Day08_Interfaces_Abstraction.MES;

namespace Day08_Interfaces_Abstraction
{
    /// <summary>
    /// Application entry point.
    ///
    /// RESPONSIBILITY:
    /// - Composes the MES system by selecting concrete machine implementations.
    /// - Wires dependencies together.
    ///
    /// DESIGN NOTES:
    /// - This file is the ONLY place that knows about concrete machine types.
    /// - Higher-level MES logic depends only on interfaces.
    /// - In real applications, this responsibility is handled by
    ///   Dependency Injection containers (e.g., ASP.NET Core).
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            /// <summary>
            /// Collection of machines provided to MES.
            ///
            /// Although concrete types are instantiated here,
            /// they are exposed to the system only as IMachine.
            /// </summary>
            List<IMachine> machines = new()
            {
                new CncMachine("C01", "Facing"),
                new RobotMachine("R01", "Picking"),
                new ConveyorMachine("CV01", "Main"),
                new VisionCamera("CM01", "Inspection")
            };

            /// <summary>
            /// MES orchestration service.
            /// </summary>
            MesService mesService = new MesService();

            // Run the MES workflow using interface-based abstraction
            mesService.Run(machines);
        }
    }
}
