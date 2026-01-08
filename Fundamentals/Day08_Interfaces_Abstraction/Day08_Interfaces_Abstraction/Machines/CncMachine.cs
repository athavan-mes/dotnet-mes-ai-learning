using Day08_Interfaces_Abstraction.Base;
using Day08_Interfaces_Abstraction.Interfaces;

namespace Day08_Interfaces_Abstraction.Machines
{
    /// <summary>
    /// CNC machine implementation.
    ///
    /// ROLE IN SYSTEM:
    /// - Represents a physical CNC machine controlled by MES.
    /// - Participates in production by machining parts.
    ///
    /// ARCHITECTURAL NOTES:
    /// - Inherits from MachineBase to reuse common machine behavior.
    /// - Implements IProductionMachine to expose production capability.
    /// - MES interacts with this class ONLY through interfaces.
    ///
    /// This class contains machine-specific behavior only.
    /// </summary>
    public class CncMachine : MachineBase, IProductionMachine
    {
        /// <summary>
        /// Total number of successfully produced parts.
        /// Internal state managed by the machine.
        /// </summary>
        public long Produced { get; private set; }

        /// <summary>
        /// Number of parts currently in machining process.
        /// </summary>
        public long InProgress { get; private set; }

        /// <summary>
        /// Number of rejected or scrapped parts.
        /// </summary>
        public long Scrap { get; private set; }

        /// <summary>
        /// Creates a new CNC machine instance.
        /// Initialization details are handled by the base class.
        /// </summary>
        /// <param name="id">Unique MES identifier</param>
        /// <param name="name">Machine display name</param>
        public CncMachine(string id, string name)
            : base(id, name)
        {
        }

        /// <summary>
        /// CNC-specific startup logic.
        ///
        /// Overrides the default start behavior provided by MachineBase
        /// to perform machine-specific actions.
        /// </summary>
        public override void Start()
        {
            Status = "Running";
            Console.WriteLine($"CNC {Id}-{Name} started machining");
        }

        /// <summary>
        /// Updates the production count for the CNC machine.
        ///
        /// This method is called by MES only when the machine
        /// supports the production capability.
        /// </summary>
        /// <param name="materialCount">
        /// Number of parts produced in the current cycle.
        /// </param>
        public void AddProductionCount(int materialCount)
        {
            Produced += materialCount;
            InProgress -= materialCount;

            Console.WriteLine(
                $"CNC {Id}-{Name} produced {materialCount} parts. Total: {Produced}");
        }
    }
}
