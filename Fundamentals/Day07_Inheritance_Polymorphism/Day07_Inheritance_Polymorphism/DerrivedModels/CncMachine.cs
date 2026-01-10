
using Day07_Inheritance_Polymorphism.BaseModels;

namespace Day07_Inheritance_Polymorphism.DerrivedModels
{
    /// <summary>
    /// Represents a CNC machine that extends the base Machine class and provides functionality specific to CNC
    /// operations.
    /// </summary>
    public class CncMachine: Machine
    {
        /// <summary>
        /// Initializes a new instance of the CncMachine class with the specified identifier and name.
        /// </summary>
        /// <param name="id">The unique identifier for the CNC machine.</param>
        /// <param name="name">The name of the CNC machine.</param>
        public CncMachine(string id , string name):base(id, name) { }

        /// <summary>
        /// Sets the status to "Running" and outputs a message indicating the CNC machine is cutting material.
        /// </summary>
        public override void Start()
        {
            Status = "Running";
            Console.WriteLine($"CNC {Id} - {Name} is cutting material.");

        }

    }
}
