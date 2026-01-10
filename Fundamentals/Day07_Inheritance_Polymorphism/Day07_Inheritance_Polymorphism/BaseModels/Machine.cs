
namespace Day07_Inheritance_Polymorphism.BaseModels
{ 

    /// <summary>
    /// Represents an abstract machine with identification, status, and production tracking functionality.
    /// </summary>
    public abstract class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public long Produced { get; set; }
        /// <summary>
        /// Initializes a new instance of the Machine class with the specified identifier and name, setting the status
        /// to "Idle".
        /// </summary>
        /// <param name="id">The unique identifier for the machine.</param>
        /// <param name="name">The name of the machine.</param>
        protected  Machine(string id, string name)
        {
            Id = id;
            Name = name;
            Status = "Idle";

        }
       
        /// <summary>
        /// Sets the machine status to running and outputs a start message to the console.
        /// </summary>
        public virtual void Start()
        {
            Status = "Running";
            Console.WriteLine($"Machine {Id}-{Name} started");
        }

        /// <summary>
        /// Stops the machine and updates its status to "Stopped".
        /// </summary>
        public virtual void Stop()
        {
            Status = "Stopped";
            Console.WriteLine($"Machine {Id}-{Name} Stopped");
        }

        /// <summary>
        /// Outputs the object's Id, Name, and Status to the console.
        /// </summary>
        public virtual void DisplayStatus()
        {
            Console.WriteLine($"{Id}-{Name} is {Status}");
        }

        /// <summary>
        /// Increases the produced material count by the specified amount.
        /// </summary>
        /// <param name="materialCount">The number of materials to add to the produced count.</param>
        /// 

        public void AddProductionCount(int materialCount)
        {
            Produced += materialCount;

        }
    }
}
