using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_Delegates_Events.Service
{
    public class MesService
    {
        public void OnMachineStatusChanged(string machineId, string status)
        {
            Console.WriteLine($"MES : Machine {machineId} is now {status}");
        }
    }
}
