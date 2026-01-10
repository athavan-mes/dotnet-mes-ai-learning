using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_ExceptionHandling
{
    /// <summary>
    /// Provides production-related operations such as calculating efficiency and controlling machines.
    /// </summary>
    public class ProductionService
    {
        /// <summary>
        /// Calculates the production efficiency as a percentage based on produced and target values.
        /// </summary>
        /// <param name="produced">The number of units produced.</param>
        /// <param name="target">The target number of units.</param>
        /// <returns>The efficiency percentage as an integer.</returns>
        /// <exception cref="ArgumentException">Thrown when target is less than or equal to zero, or produced is negative.</exception>
        public int CalculateEfficiency(int produced, int target)
        {
            if (target <= 0)
                throw new ArgumentException("Target must be greater than zero.");
            if (produced < 0)
                throw new ArgumentException("Produced cannot be negative.");
            return (produced * 100) / target;
        }
        /// <summary>
        /// Starts the specified machine by its identifier.
        /// </summary>
        /// <param name="machineId">The unique identifier of the machine to start.</param>
        /// <exception cref="MachineException">Thrown when the machine fails to start due to a motor failure.</exception>
        public void StartMachine(string machineId)
        {
            // Simulate machine startup logic
            if (machineId == "M-FAIL")
                throw new MachineException(machineId,"Machine motor failure.");

            Console.WriteLine($"Machine {machineId} started successfully.");

            
        }
    }
}
