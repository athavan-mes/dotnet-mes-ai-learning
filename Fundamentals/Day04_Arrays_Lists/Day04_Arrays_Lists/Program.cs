// Day 04 Learning

// Project type :Console APP


// 1. Array
// 2.Lists

// 1.Array   - can be fixed no of elements

using System.Reflection.PortableExecutable;

string[] machines = {"CNC-01", "CNC-02", "CNC-03"};

for (int i = 0; i < machines.Length; i++)
{
    Console.WriteLine($"Machine {machines[i]}");
}

foreach( string machine in machines )
{
    Console.WriteLine($"Machine {machine}");

}


// 2. Lists

List<string> alarms = new List<string>();
alarms.Add("Overheat");
alarms.Add("Low Pressure");
alarms.Add("Emergency Stop");


foreach(var alarm in alarms )
{
    Console.WriteLine($"Alarm :{alarm}");
}



bool lowPressureAck = true;
if ( lowPressureAck )
{
    alarms.Contains("Low Pressure");
    alarms.Remove("Low Pressure");
}
Console.WriteLine($"Active Alarm Count :{alarms.Count}");



/*Mini Exercise (IMPORTANT)
Write code to:

Create a List<string> of 10 machine names

Remove machine "CNC-05"

Skip printing "CNC-08"

Stop loop when machine "CNC-09" appear */


string[] names = { "CNC-01", "CNC-02", "CNC-03", "CNC-04", "CNC-05", "CNC-06", "CNC-07", "CNC-08", "CNC-09", "CNC-10" };
List<string> machineNames = new List<string>();
machineNames.AddRange(names);

/*“Can you modify a list inside foreach?”

Answer:

“No.Modifying a collection during foreach throws an exception.
I either modify before the loop or use a for loop.”

✔ for allows modification
✔ Index-based control

*/

if (machineNames.Contains("CNC-05"))
    machineNames.Remove("CNC-05");

foreach (var  machine in machineNames )
{
    
    if (machine == "CNC-08")
        continue;
    else if (machine == "CNC-09")
        break;
    Console.WriteLine($"Machine Name : {machine}");

}

/*
Problem

Store hourly production counts for a machine and calculate total production.

Requirements

Create an int[] with 8 values(8 - hour shift)

Calculate total production

Calculate average production   */

int[] hourlyProduction = { 120, 130, 125, 140, 135, 128, 132, 138 };

if(hourlyProduction.Length ==0)
{
    Console.WriteLine("No Production Data Available");
}

int totalProduction = hourlyProduction.Sum();
Console.WriteLine($"Total Production : {totalProduction}");

// int averageProduction = (int)hourlyProduction.Average(); // can do casting which will truncates the decimal values

double averageProduction = hourlyProduction.Average(); 

Console.WriteLine($"Average Production : {averageProduction:F2}");  // here F2 means Formating to two decimal points





