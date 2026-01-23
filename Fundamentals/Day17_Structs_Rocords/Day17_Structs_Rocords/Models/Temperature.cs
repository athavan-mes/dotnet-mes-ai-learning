using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Structs_Rocords.Models
{
    public struct Temperature
    {
        public string MachineID { get; }
        public float CurrentTemperature { get; }
        public string Unit { get; }


        public Temperature(string machineID, float currentTemperature, string unit)
        {
            MachineID = machineID;
            CurrentTemperature = currentTemperature;
            Unit = unit;
        }

    }
}
