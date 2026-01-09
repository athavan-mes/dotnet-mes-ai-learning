using Day08_Interfaces_Abstraction.Interfaces;

namespace Day08_Interfaces_Abstraction.Base
{
    /// <summary>
    /// Abstract base class that provides shared implementation
    /// for all MES machines.
    ///
    /// IMPORTANT:
    /// - This class is NOT a system contract.
    /// - MES must never depend on this type directly.
    /// - It exists only to avoid code duplication in concrete machines.
    ///
    /// System contracts are defined using interfaces (e.g., IMachine).
    /// </summary>
    public abstract class MachineBase : IMachine
    {
        /// <summary>
        /// Unique identifier of the machine within MES.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Human-readable machine name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Current runtime status of the machine.
        /// Setter is protected to prevent external modification.
        /// </summary>
        public string Status { get; protected set; }

        /// <summary>
        /// Protected constructor ensures this class
        /// cannot be instantiated directly.
        /// Only derived machine types can initialize it.
        /// </summary>
        protected MachineBase(string id, string name)
        {
            Id = id;
            Name = name;
            Status = "Idle";
        }

        /// <summary>
        /// Default start behavior shared by most machines.
        /// Derived classes can override this to implement
        /// machine-specific startup logic.
        /// </summary>
        public virtual void Start()
        {
            Status = "Running";
            Console.WriteLine($"Machine {Id}-{Name} started");
        }

        /// <summary>
        /// Default stop behavior shared by most machines.
        /// Marked virtual to allow customization
        /// when specific machines require special shutdown logic.
        /// </summary>
        public virtual void Stop()
        {
            Status = "Stopped";
            Console.WriteLine($"Machine {Id}-{Name} stopped");
        }

        /// <summary>
        /// Displays the current status of the machine.
        /// MES uses this for monitoring and diagnostics.
        /// </summary>
        public void DisplayStatus()
        {
            Console.WriteLine($"{Id}-{Name} is {Status}");
        }
    }
}
