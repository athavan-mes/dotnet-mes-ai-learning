// Day 04 Learning

// Project type :Console APP


// 1. Array
// 2.Lists

// 1.Array   - can be fixed no of elements

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

foreach(var  machine in machineNames )
{
    if (machine == "CNC-05")
        machineNames.Remove(machine);
    else if (machine == "CNC-08")
        continue;
    else if (machine == "CNC-09")
        break;
    Console.WriteLine($"Machine Name : {machine}");

}