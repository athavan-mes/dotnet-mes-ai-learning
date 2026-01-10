using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_ExceptionHandling
{
    /// <summary>
    /// Represents errors that occur during machine operations and includes the machine identifier.
    /// </summary>
    public class MachineException:Exception
    {
        public string MachineId { get; }
        /// <summary>
        /// Initializes a new instance of the MachineException class with the specified machine ID and error message.
        /// </summary>
        /// <param name="machineId">The identifier of the machine associated with the exception.</param>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public MachineException( string  machineId, string message) : base(message) 
        {
            MachineId   = machineId;
        }

    }
}
