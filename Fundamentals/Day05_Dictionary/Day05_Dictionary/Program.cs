// Day 05 Learning

// Project type :Console APP

// 1. Dictionary
// data  will stored in key value pair
// keys will be unique 
//Lookup will be faster than list
// 


Dictionary<string, string> machineStatus = new Dictionary<string, string>();
machineStatus.Add("CNC-01", "Running");
machineStatus.Add("CNC-02", "Idle");
machineStatus.Add("CNC-03", "Stopped");

// check if machine "CN-01" exists and print it's status
if(machineStatus.ContainsKey("CNC-01"))
{
    Console.WriteLine($"Machine CNC-01 Status : {machineStatus["CNC-01"]}");

}
else
{
    Console.WriteLine("Machine Does not Exists");
}

// update machine Status

machineStatus["CNC-02"] = "Running";

// Task 01 
// Remove the machines from the list which has Status Stopped
// Count Active Machine 
// Update machine Status Idle -> Running

var stoppedMachineList = new List<string>();
int activeMachineCount = 0;

stoppedMachineList = machineStatus.Where(m => m.Value == "Stopped").Select(m => m.Key).ToList();
foreach(var stoppedMachine in stoppedMachineList)
{
    machineStatus.Remove(stoppedMachine);

}
foreach(var machine in machineStatus)
{
    Console.WriteLine($"{machine.Key} : {machine.Value}");

    if(machine.Value == "Running")
    {
        activeMachineCount++;
    }

}
Console.WriteLine($"Active Machine Count : {activeMachineCount}");


var idleMachineList = machineStatus.Where(m => m.Value == "Idle").Select(m => m.Key).ToList();
for(int i = 0; i < idleMachineList.Count; i++)
{
    machineStatus[idleMachineList[i]] = "Running";

}