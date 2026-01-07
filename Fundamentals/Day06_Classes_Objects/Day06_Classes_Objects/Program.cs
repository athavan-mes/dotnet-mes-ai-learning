
// Day 06 Learning

// Project type :Console APP


// Classes and Objects


using Day06_Classes_Objects.Models;


// without Constructor
/*
var Machine1 = new Machine
{
    Id = "MC-01",
    Name = "CNC Lathe",
    Status = "Running"
};

var Machine2 = new Machine
{
    Id = "MC-02",
    Name = "Drill Machine ",
    Status = "Idle"
};

Machine1.DisplayStatus();
Machine2.DisplayStatus();

*/

// After adding Constructor to class Machine 
/*  Forces vaild Object Creation
 *  Prevent half initialized objects
   
   */

var Machine3 = new Machine("MC-03", "Milling Machine", "Stopped");
var Machine4 = new Machine("MC-04", "Buffing Machine", "Idle");

Machine3.DisplayStatus();
Machine3.Start();
Machine3.DisplayStatus();
Machine4.DisplayStatus();
Machine4.Stop();
Machine4.DisplayStatus();

List<Machine> machines = new()
{ Machine3, Machine4};

foreach (var machine in machines)
{
    Console.WriteLine(machine.Status);
}

int runningMachineCount = machines.Count(m=> m.Status == "Running");
Console.WriteLine($"Running Machines :{runningMachineCount}");

Machine3.AddProductionCount(20);
Console.WriteLine($"{Machine3.Id}-{Machine3.Name} Production Count : {Machine3.Produced} ");



// created machine class and derived machine1,2 ,3 4 objects from it

