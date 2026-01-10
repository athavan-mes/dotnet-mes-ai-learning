using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_Classes_Objects.Models
{
    /// <summary>
    /// Represents a machine with identification, status, and production tracking.
    /// </summary>
    public class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public long Produced { get; set; }

        /// <summary>
        /// Initializes a new instance of the Machine class with the specified ID, name, and status.
        /// </summary>
        /// <param name="id">The unique identifier for the machine.</param>
        /// <param name="name">The name of the machine.</param>
        /// <param name="status">The status of the machine.</param>
        public Machine(string id ,string name ,string status) 
        {
            Id = id;
            Name = name;
            Status = status;

        }

        /// <summary>
        /// Sets the status to "Running".
        /// </summary>
        public void Start()
        {
            Status = "Running";
        }

        /// <summary>
        /// Sets the status to "Stopped".
        /// </summary>
        public void Stop()
        {
            Status = "Stopped";
        }
        /// <summary>
        /// Outputs the object's ID, name, and status to the console.
        /// </summary>
        public void DisplayStatus () 
        {
            Console.WriteLine ($"{Id}-{Name} is {Status}");
        }
        /// <summary>
        /// Increases the Produced count by the specified material count.
        /// </summary>
        /// <param name="materialCount">The number of materials to add to the production count.</param>
        public void AddProductionCount (int materialCount)
        {
            Produced += materialCount;
            
        }
    }
}
