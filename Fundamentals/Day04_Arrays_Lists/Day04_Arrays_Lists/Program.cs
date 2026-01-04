// Day 04 Learning

// Project type :Console APP


// 1. Array
// 2.Lists

// 1.Array   - can be fixed no of elements

using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;

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

// Task 01:

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
    return;
}

int totalProduction = hourlyProduction.Sum();
Console.WriteLine($"Total Production : {totalProduction}");

// int averageProduction = (int)hourlyProduction.Average(); // can do casting which will truncates the decimal values

double averageProduction = hourlyProduction.Average(); 

Console.WriteLine($"Average Production : {averageProduction:F2}");  // here F2 means Formating to two decimal points



//Task 2: Find Max & Min Temperature
/*Problem

Track temperature readings and find:

Maximum temperature

Minimum temperature

Requirements

Use double[]

Use a loop (NO LINQ yet) */


double[] temperatures = { 50.50, 60.33, 40.00, 25.80 };
double minmumTemperature = temperatures[0];
double maximumTemperature = temperatures[0];

foreach (var temperature in temperatures)
{
    
    if(temperature < minmumTemperature) 
        minmumTemperature = temperature;

    if(temperature > maximumTemperature)
        maximumTemperature = temperature;
}
Console.WriteLine($"Minimum Temperature : {minmumTemperature}");
Console.WriteLine($"Maximum Temperature : {maximumTemperature}");

// Task 3
// Machine Status List (String Logic)
/* Problem

Maintain machine statuses.

Requirements

Create List<string> with:

"Running"

"Idle"

"Stopped"

Check if "Running" exists

Print message based on status
*/

// re visit

List<string> machineStatus = new List<string>
{
    "Running",
    "Idle",
    "Stopped"
};

if (machineStatus.Contains("Running"))
{
    Console.WriteLine("Machine is currently running.");
}
else if (machineStatus.Contains("Idle"))
{
    Console.WriteLine("Machine is idle.");
}
else if (machineStatus.Contains("Stopped"))
{
    Console.WriteLine("Machine is stopped.");
}
else
{
    Console.WriteLine("Unknown machine status.");
}




