namespace Day08_Interfaces_Abstraction.Interfaces
{
    /// <summary>
    /// Optional MES capability representing vision and inspection behavior.
    ///
    /// PURPOSE:
    /// - Implemented only by machines that perform visual inspection
    ///   or image capture (e.g., vision cameras, inspection stations).
    ///
    /// ARCHITECTURAL ROLE:
    /// - Enables MES to trigger vision-related operations
    ///   without depending on concrete device types.
    /// - Keeps vision functionality separate from core machine lifecycle
    ///   and other unrelated capabilities.
    ///
    /// DESIGN NOTES:
    /// - This interface represents a capability, not a device type.
    /// - Machines that do not support vision are not forced
    ///   to implement this contract.
    /// </summary>
    public interface IVisionMachine
    {
        /// <summary>
        /// Captures an image for inspection or analysis.
        /// The concrete implementation determines how
        /// the image is acquired and processed.
        /// </summary>
        void CaptureImage();
    }
}
