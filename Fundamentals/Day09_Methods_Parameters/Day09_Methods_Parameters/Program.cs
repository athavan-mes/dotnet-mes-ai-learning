// Day 09 
// Project type : Console App

// Methods and Parameters

using Day09_Methods_Parameters.Actions;
using Day09_Methods_Parameters.MESService;

// Create instances of the ProductionCalculator and MachineService classes
var calculator = new ProductionCalculator ();
var machineService = new MachineService ();

// Hourly production data for a shift
int[] hourly = { 100, 120, 88, 130, 140, 125, 140, 45 };

// Calculate total and average production
int total = calculator.CalculateTotal (hourly);
double avg = calculator.CalculateAverage(total, hourly.Length);
Console.WriteLine ($" Total Production :{total}");
Console.WriteLine ($" Average Production :{avg}");

// Calculate Overall Equipment Effectiveness (OEE)
double oee = calculator.CalculateOEE(0.9, 0.95, 0.98);
Console.WriteLine ($"OEE : {oee}");

string status = "Idel";
/// Check if machine can start
if (machineService.canStartMachine(status))
{
    Console.WriteLine("Machine can Start");

}

// Reset production using ref parameter
int production = total;
machineService.ResetProduction(ref production);
Console.WriteLine ($"Production after reset : {production}");

// Calculate efficiency using out parameter
if (machineService.TryGetEfficiency(total, 800,out double efficiency))
{
    Console.WriteLine ($"Efficiency : {efficiency}");
}

Console.ReadLine ();