using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_Methods_Parameters.MESService
{
    public class MachineService
    {
        public bool canStartMachine(string status)
        {
            if(status =="Running")
                return false;
            return true;
        }
        public void ResetProduction(ref int production)
            { 
            production = 0;
        }
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
