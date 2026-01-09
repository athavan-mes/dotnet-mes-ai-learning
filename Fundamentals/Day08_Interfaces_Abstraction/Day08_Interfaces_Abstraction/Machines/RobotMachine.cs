using Day08_Interfaces_Abstraction.Base;
using Day08_Interfaces_Abstraction.Interfaces;

namespace Day08_Interfaces_Abstraction.Machines
{
    /// <summary>
    /// Robot machine implementation.
    ///
    /// ROLE IN SYSTEM:
    /// - Represents an industrial robot used for material handling
    ///   or assembly operations.
    ///
    /// ARCHITECTURAL NOTES:
    /// - Inherits from MachineBase to reuse common lifecycle behavior.
    /// - Implements IProductionMachine to participate in production tracking.
    /// - Does NOT support vision capabilities.
    ///
    /// MES interacts with this machine exclusively through interfaces.
    /// </summary>
    public class RobotMachine : MachineBase, IProductionMachine
    {
        /// <summary>
        /// Total number of units successfully processed by the robot.
        /// </summary>
        public long Produced { get; private set; }

        /// <summary>
        /// Number of units currently being handled by the robot.
        /// </summary>
        public long InProgress { get; private set; }

        /// <summary>
        /// Number of units rejected or dropped during handling.
        /// </summary>
        public long Scrap { get; private set; }

        /// <summary>
        /// Creates a new robot machine instance.
        /// </summary>
        /// <param name="id">Unique MES identifier</param>
        /// <param name="name">Robot display name</param>
        public RobotMachine(string id, string name)
            : base(id, name)
        {
        }

        /// <summary>
        /// Robot-specific startup logic.
        ///
        /// Overrides the default start behavior to reflect
        /// material handling operations.
        /// </summary>
        public override void Start()
        {
            Status = "Running";
            Console.WriteLine($"Robot {Id}-{Name} started material handling");
        }

        /// <summary>
        /// Updates production metrics for the robot.
        ///
        /// MES calls this method only when the robot
        /// participates in production workflows.
        /// </summary>
        /// <param name="materialCount">
        /// Number of units handled in the current operation.
        /// </param>
        public void AddProductionCount(int materialCount)
        {
            Produced += materialCount;
            InProgress -= materialCount;

            Console.WriteLine(
                $"Robot {Id}-{Name} processed {materialCount} units. Total: {Produced}");
        }
    }
}
