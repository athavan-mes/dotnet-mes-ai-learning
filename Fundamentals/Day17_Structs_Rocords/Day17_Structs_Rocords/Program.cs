


using Day17_Structs_Rocords.Models;

var machineTemperature = new Temperature("Machine_01", 75.0f, "Celsius");
var machineTemperature2 = machineTemperature; // Copy by Value

machineTemperature2 = new Temperature("Machine_02", 80.0f, "Celsius");

Console.WriteLine($"Machine ID: {machineTemperature.MachineID}, Temperature: {machineTemperature.CurrentTemperature} {machineTemperature.Unit}");
Console.WriteLine($"Machine ID: {machineTemperature2.MachineID}, Temperature: {machineTemperature2.CurrentTemperature} {machineTemperature2.Unit}");



// create record for ProductionReport
// create a new version using with expression
// verify original data remains unchanged

var report1 = new ProductionReport
{
    MachineId = "Machine_01",
    ShiftId = "Shift_A",
    PartsProduced = 1000
};

var report2 = report1 with { PartsProduced = 1200 };

Console.WriteLine($"Report 1 - Machine ID: {report1.MachineId}, Shift ID: {report1.ShiftId}, Parts Produced: {report1.PartsProduced}");
Console.WriteLine($"Report 2 - Machine ID: {report2.MachineId}, Shift ID: {report2.ShiftId}, Parts Produced: {report2.PartsProduced}");


// equality Comparision

var tempA = new Temperature("Machine_03", 70.0f, "Celsius");
var tempB = new Temperature("Machine_03", 70.0f, "Celsius");
Console.WriteLine($"Temperature A equals Temperature B: {tempA.Equals(tempB)}");

var reportA = new ProductionReport
{
    MachineId = "Machine_02",
    ShiftId = "Shift_B",
    PartsProduced = 1500
};

var reportB = new ProductionReport
{
    MachineId = "Machine_02",
    ShiftId = "Shift_B",
    PartsProduced = 1500
};

Console.WriteLine($"Report A equals Report B: {reportA.Equals(reportB)}");

var machine1 = new Machine("M100", "Running",100);
var machine2 = new Machine("M100", "Running",18);
Console.WriteLine($"Machine 1 equals Machine 2: {machine1.Equals(machine2)}");

// Task 4 API snapshot simulation 
// simulate fetching machine data
// convert live Machine class - > immutable Machine Snapshot

static MachineSnapshot GetMachineSnapshot(Machine liveMachine)
{
    return new MachineSnapshot(liveMachine.Id, liveMachine.Status, liveMachine.PartsProcessed);
}

var machine = new Machine("M200", "Running", 2500);
var snapshot = GetMachineSnapshot(machine);
machine.Produce(50);

var snapshot2 = GetMachineSnapshot(machine);

Console.WriteLine($"Snapshot 1 - Machine ID: {snapshot.Id}, Status: {snapshot.Status}, Parts Processed: {snapshot.PartsProcessed}");
Console.WriteLine($"Snapshot 2 - Machine ID: {snapshot2.Id}, Status: {snapshot2.Status}, Parts Processed: {snapshot2.PartsProcessed}");



