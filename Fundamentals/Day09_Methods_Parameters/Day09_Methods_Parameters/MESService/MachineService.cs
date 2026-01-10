using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_Methods_Parameters.MESService
{
    public class MachineService
    {
        /// <summary>
        /// Determines whether the machine can be started based on its current status.
        /// </summary>
        /// <param name="status">The current status of the machine.</param>
        /// <returns>true if the machine is not running; otherwise, false.</returns>
        public bool canStartMachine(string status)
        {
            if(status =="Running")
                return false;
            return true;
        }
        /// <summary>
        /// Resets the specified production value to zero.
        /// </summary>
        /// <param name="production">Reference to the production value to reset.</param>
        public void ResetProduction(ref int production)
            { 
            production = 0;
        }
        /// <summary>
        /// Calculates the efficiency percentage based on produced and target values.
        /// </summary>
        /// <param name="produced">The number of units produced.</param>
        /// <param name="target">The target number of units.</param>
        /// <param name="efficiency">When this method returns, contains the calculated efficiency percentage if successful; otherwise, zero.</param>
        /// <returns>true if the efficiency was calculated successfully; false if the target is zero.</returns>
        public bool TryGetEfficiency(int produced , int target ,out double efficiency)
        {
            if (target == 0)
            {
                efficiency = 0;
                return false;
            }
            efficiency = (double)produced / target * 100;
            return true;
        }
    }
}
