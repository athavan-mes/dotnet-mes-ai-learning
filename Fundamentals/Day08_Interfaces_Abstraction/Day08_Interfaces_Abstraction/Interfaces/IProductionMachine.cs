namespace Day08_Interfaces_Abstraction.Interfaces
{
    /// <summary>
    /// Optional MES capability representing production behavior.
    ///
    /// PURPOSE:
    /// - Implemented only by machines that physically produce parts
    ///   (e.g., CNC machines, robots, simulators).
    ///
    /// ARCHITECTURAL ROLE:
    /// - Allows MES to interact with production behavior
    ///   without knowing concrete machine types.
    /// - Prevents non-producing machines (e.g., conveyors, cameras)
    ///   from being forced to implement irrelevant logic.
    ///
    /// DESIGN NOTES:
    /// - This interface is intentionally small and focused.
    /// - Production data storage and internal calculations
    ///   remain the responsibility of the implementing machine.
    /// </summary>
    public interface IProductionMachine
    {
        /// <summary>
        /// Increases the production count for the machine.
        /// MES invokes this method only when the machine
        /// supports the production capability.
        /// </summary>
        /// <param name="materialCount">
        /// Number of units produced in the current operation.
        /// </param>
        void AddProductionCount(int materialCount);
    }
}
