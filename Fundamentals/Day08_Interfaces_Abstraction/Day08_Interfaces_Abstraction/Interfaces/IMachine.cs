namespace Day08_Interfaces_Abstraction.Interfaces
{
    /// <summary>
    /// Core MES machine contract.
    ///
    /// PURPOSE:
    /// - Defines the minimum lifecycle operations that every machine
    ///   in the MES system must support.
    ///
    /// ARCHITECTURAL ROLE:
    /// - Acts as a system boundary between MES logic and machine implementations.
    /// - MES depends ONLY on this interface, never on concrete or abstract classes.
    ///
    /// DESIGN NOTES:
    /// - This interface intentionally exposes behavior, not internal state.
    /// - Optional machine capabilities are modeled using separate interfaces
    ///   (e.g., IProductionMachine, IVisionMachine).
    /// </summary>
    public interface IMachine
    {
        /// <summary>
        /// Starts the machine.
        /// The concrete implementation decides how startup is performed.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops the machine gracefully.
        /// The default behavior may be overridden by specific machine types.
        /// </summary>
        void Stop();

        /// <summary>
        /// Displays the current operational status of the machine.
        /// Used by MES for monitoring and diagnostics.
        /// </summary>
        void DisplayStatus();
    }
}
