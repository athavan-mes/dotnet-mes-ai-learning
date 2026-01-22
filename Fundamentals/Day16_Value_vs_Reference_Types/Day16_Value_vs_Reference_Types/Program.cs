// Move struct declaration above all top-level statements to fix CS8803
using Day16_Value_vs_Reference_Types.Model;
using Day16_Value_vs_Reference_Types.Structs;



// Day 16 Learning

// Project type :Console APP

/* Topics:
 * struct vs class
 * stack vs heap(conceptual)
 * Copy by value vs Copy by reference
 * Passing parameters to methods
 * ref vs out vs in
 * immutability basic
 * 
 */

// Task :1 Production Count Copy Issue 
// 

int productionCountA = 100;
int productionCountB = productionCountA; // Copy by Value
productionCountB += 50;
Console.WriteLine($"Production Count A : {productionCountA}");

// Task :2

var machineA = new MachineBase("M001", "Running");

var machineB = machineA; // Copy by Reference

machineB.Status = "Stopped";

Console.WriteLine($"Machine A Status : {machineA.Status}");

// Task 3 : Struct vs Class for MachineState

var machineStateA = new MachineBase("M002", "Running");
machineStateA.Status = "Stopped";
machineStateA.PartsProcessed = 5000;

Console.WriteLine($"Machine State A Status : {machineStateA.Status}");
Console.WriteLine($"Machine State A Parts Processed : {machineStateA.PartsProcessed}");

MachineState machineStateB = new("M003", "Running");
machineStateB.Status = "Stopped";
machineStateB.PartsProcessed = 3000;

Console.WriteLine($"Machine State B Status : {machineStateB.Status}");
Console.WriteLine($"Machine State B Parts Processed : {machineStateB.PartsProcessed};");

// Task 4 : Passing parameters to methods
// create method that updates machine state
// Pass:
//      -Value type
//     -Reference type
// observe behavior

static void UpdateStatus(MachineBase machine)
{
    machine.Status = "Running";
}

static void ProcessParts(long parts)
{
    parts += 50;
}
int partsProcessed = 200;
ProcessParts(partsProcessed);
Console.WriteLine($"Parts Processed : {partsProcessed}");

var machineC = new MachineBase("M004", "Idle");
UpdateStatus(machineC);

Console.WriteLine($"Machine C Status : {machineC.Status}");















