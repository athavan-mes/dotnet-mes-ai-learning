var machines = new List<(string Name, string Status, int PartsProduced)>
{
    ("CNC-01", "Running", 120),
    ("CNC-02", "Stopped", 0),
    ("CNC-03", "Running", 150),
    ("Robot-01", "Running", 200),
    ("Conveyor-01", "Idle", 0),
    ("Vision-01", "Stopped", 0),
    ("CNC-04", "Running", 170)
};


// From a machine list, find only machines that are running.

var runningMachines = machines.Where(m => m.Status == "Running");
foreach(var machine in runningMachines)
{
    Console.WriteLine(machine.Name);
}



// Calculate how many machines are currently producing.

var currentlyProducingMachines = machines.Count(m => m.Status =="Running");
Console.WriteLine($"Currently Producing Machine Count: {currentlyProducingMachines}");

// Calculate total parts produced by all machines.

var totalParstProduced = machines.Sum(m => m.PartsProduced);
Console.WriteLine($"Total Parts Produced : {totalParstProduced}");


// Identify which machine produced the most parts.
var mostProductiveMachine = machines.OrderByDescending(m => m.PartsProduced).First();
Console.WriteLine($"Most Productive Machine :{mostProductiveMachine.Name} : {mostProductiveMachine.PartsProduced}");

// Find machines that are not producing.

    var nonProductiveMachine = machines.Where(m=>m.Status == "Stopped");
foreach(var machine in nonProductiveMachine)
    { 
    Console.WriteLine(machine.Name); 
}

// Find machines that exceeded the production target.

int target = 150;

var productiveMachines = machines.Where(m=> m.PartsProduced >= target);
foreach (var machine in productiveMachines)
{
    Console.WriteLine(machine.Name);
}

// Detect if any machine is not working.
if(machines.Any(m => m.Status == "Idle"))
{
    Console.WriteLine("Some machine is Idle");

}
Console.WriteLine("No machine is Idle");


// Calculate how many machines are in each state.
int runningMachineCount = machines.Count(m => m.Status == "Running");
int idleMachineCount = machines.Count(m => m.Status == "Idle");
int stoppedMachineCount = machines.Count( m => m.Status == "Stopped");

Console.WriteLine($"Running Machine Count : {runningMachineCount}");
Console.WriteLine($"Idle Machine Count : {idleMachineCount}");
Console.WriteLine($"Stopped Machine Count : {stoppedMachineCount}");



var machinesList = new List<(string Name, string Type, string Status, int Parts)>
{
    ("CNC-01", "CNC", "Running", 120),
    ("CNC-02", "CNC", "Stopped", 0),
    ("CNC-03", "CNC", "Running", 150),

    ("Robot-01", "Robot", "Running", 200),
    ("Robot-02", "Robot", "Idle", 0),

    ("Conveyor-01", "Conveyor", "Running", 300),
    ("Conveyor-02", "Conveyor", "Stopped", 0),

    ("Vision-01", "Vision", "Running", 180),
    ("Vision-02", "Vision", "Idle", 0)
};





/*🔹 Task 1 — Production by Machine Type

Requirement
Group machines by Type and calculate:

Total production per type

Output example:

CNC → 270
Robot → 200
Conveyor → 300
Vision → 180*/

var productionByType = machinesList
    .GroupBy(m => m.Type)
    .Select(g => new
    {
        Type = g.Key,
        TotalProduction = g.Sum(m => m.Parts)
    });
foreach (var item in productionByType)
{
    Console.WriteLine($"{item.Type} total production is {item.TotalProduction} ");

}



/*🔹 Task 2 — Machine Count by Status

Requirement
Group by Status and count:

Running

Idle

Stopped

This becomes MES KPI.*/

var machineCountByStatus = machinesList.GroupBy(m => m.Status)
    .Select(g => new
    {
        Status = g.Key,
        Count = g.Count()
    });
foreach (var item in machineCountByStatus)
{
    Console.WriteLine($"{item.Status} : {item.Count}");
}


/*🔹 Task 3 — Average Production per Type

Requirement
Group by Type
Calculate Average Parts Produced 

Used to see efficiency.*/

var averageProductionPerType = machinesList
    .GroupBy(m => m.Type)
    .Select(g => new
    {
        Type = g.Key,
        AverageProduction = g.Average(m => m.Parts)
    });
foreach (var item in averageProductionPerType)
{
    Console.WriteLine($"{item.Type} : {item.AverageProduction}");
}



/*🔹 Task 4 — Identify Bottleneck

Requirement
Find machine with lowest production but Status = Running

This is the bottleneck machine.*/

var bottelNeckMachine = machinesList.Where(m => m.Status == "Running")
    .OrderBy(m => m.Parts)
    .First();
Console.WriteLine($"Bottleneck Machine is {bottelNeckMachine.Name} with production {bottelNeckMachine.Parts}");

/*🔹 Task 5 — Find Idle Capacity

Requirement
Calculate how many machines are Idle per Type

Helps capacity planning. */

var idleCapacityPerType = machinesList
    .Where(m => m.Status == "Idle")
    .GroupBy(m => m.Type)
    .Select(g => new
    {
        Type = g.Key,
        IdleCount = g.Count()
    });
foreach (var item in idleCapacityPerType)
{
    Console.WriteLine($"Ideal Machine in {item.Type} Type is {item.IdleCount}");
        }

/*🔹 Task 6 — Top Performer per Type

Requirement
For each machine type:
Find the machine with the highest production. */

var topPerformancePerType = machinesList.GroupBy(m => m.Type)
    .Select(g => new
    {
        Type = g.Key,
        TopMachine = g.OrderByDescending(m => m.Parts).First()
    });

foreach(var item in topPerformancePerType)
{
    Console.WriteLine($"Top Performer in {item.Type} is {item.TopMachine.Name} with production {item.TopMachine.Parts}");
}


/* 🔹 Task 7 — Factory Health Report

Requirement
Create a summary showing:

Total machines

Running machines

Idle machines

Stopped machines

Total production
*/


int totalMachines = machinesList.Count;
Console.WriteLine($"Total Machines : {totalMachines}");

int runningMachinesCount = machinesList.Count(m => m.Status == "Running");
Console.WriteLine($"Running Machines : {runningMachinesCount}");

int idleMachinesCount = machinesList.Count(m => m.Status == "Idle");
Console.WriteLine($"Idle Machines : {idleMachinesCount}");

int stoppedMachinesCount = machinesList.Count(m => m.Status == "Stopped");
Console.WriteLine($"Stopped Machines : {stoppedMachinesCount}");

int totalProductionAllMachines = machinesList.Sum(m => m.Parts);
Console.WriteLine($"Total Production : {totalProductionAllMachines}");

