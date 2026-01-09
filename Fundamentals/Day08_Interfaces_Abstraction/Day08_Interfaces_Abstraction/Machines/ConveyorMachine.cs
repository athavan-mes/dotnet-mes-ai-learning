using Day08_Interfaces_Abstraction.Base;

namespace Day08_Interfaces_Abstraction.Machines
{
    /// <summary>
    /// Conveyor machine implementation.
    ///
    /// ROLE IN SYSTEM:
    /// - Represents a conveyor responsible for moving material
    ///   between machines in the production line.
    ///
    /// ARCHITECTURAL NOTES:
    /// - Inherits from MachineBase to reuse lifecycle behavior.
    /// - Does NOT implement IProductionMachine because it does not
    ///   create or modify production output.
    /// - Does NOT implement IVisionMachine because it performs no inspection.
    ///
    /// This design prevents the conveyor from being forced
    /// to support irrelevant behavior.
    /// </summary>
    public class ConveyorMachine : MachineBase
    {
        /// <summary>
        /// Creates a new conveyor machine instance.
        /// </summary>
        /// <param name="id">Unique MES identifier</param>
        /// <param name="name">Conveyor display name</param>
        public ConveyorMachine(string id, string name)
            : base(id, name)
        {
        }

        /// <summary>
        /// Conveyor-specific startup logic.
        ///
        /// Overrides default behavior to reflect
        /// continuous material transport.
        /// </summary>
        public override void Start()
        {
            Status = "Running";
            Console.WriteLine($"Conveyor {Id}-{Name} started moving material");
        }

        /// <summary>
        /// Uses the default stop behavior from MachineBase.
        /// No override is required because shutdown logic
        /// is identical to most machines.
        /// </summary>
        // Inherits Stop() from MachineBase
    }
}
