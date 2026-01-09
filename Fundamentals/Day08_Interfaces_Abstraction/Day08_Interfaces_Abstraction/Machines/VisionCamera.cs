using Day08_Interfaces_Abstraction.Base;
using Day08_Interfaces_Abstraction.Interfaces;

namespace Day08_Interfaces_Abstraction.Machines
{
    /// <summary>
    /// Vision camera implementation.
    ///
    /// ROLE IN SYSTEM:
    /// - Represents a vision device used for inspection
    ///   and image capture in MES workflows.
    ///
    /// ARCHITECTURAL NOTES:
    /// - Inherits from MachineBase for lifecycle management.
    /// - Implements IVisionMachine to expose vision capability.
    /// - Does NOT participate in production tracking.
    ///
    /// This separation keeps the machine contract clean
    /// and avoids irrelevant behavior.
    /// </summary>
    public class VisionCamera : MachineBase, IVisionMachine
    {
        /// <summary>
        /// Creates a new vision camera instance.
        /// </summary>
        /// <param name="id">Unique MES identifier</param>
        /// <param name="name">Camera display name</param>
        public VisionCamera(string id, string name)
            : base(id, name)
        {
        }

        /// <summary>
        /// Camera-specific startup logic.
        ///
        /// Overrides default behavior to reflect
        /// readiness for image capture.
        /// </summary>
        public override void Start()
        {
            Status = "Running";
            Console.WriteLine($"Camera {Id}-{Name} is ready for inspection");
        }

        /// <summary>
        /// Captures an image for inspection or analysis.
        ///
        /// MES invokes this method only when the machine
        /// supports vision capability.
        /// </summary>
        public void CaptureImage()
        {
            Console.WriteLine($"Camera {Id}-{Name} captured an image");
        }
    }
}
