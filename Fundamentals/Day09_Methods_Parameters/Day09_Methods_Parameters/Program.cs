// Day 09 
// Project type : Console App

// Methods and Parameters

using Day09_Methods_Parameters.Actions;
using Day09_Methods_Parameters.MESService;

var calculator = new ProductionCalculator ();
var machineService = new MachineService ();

int[] hourly = { 100, 120, 88, 130, 140, 125, 140, 45 };
int total = calculator.CalculateTotal (hourly);
double avg = calculator.CalculateAverage(total, hourly.Length);

Console.WriteLine ($" Total Production :{total}");
Console.WriteLine ($" Average Production :{avg}");

double oee = calculator.CalculateOEE(0.9, 0.95, 0.98);
Console.WriteLine ($"OEE : {oee}");

string status = "Idel";
if(machineService.canStartMachine(status))
{
    Console.WriteLine("Machine can Start");

}


int production = total;
machineService.ResetProduction(ref production);
Console.WriteLine ($"Production after reset : {production}");


if(machineService.TryGetEfficiency(total, 800,out double efficiency))
{
    Console.WriteLine ($"Efficiency : {efficiency}");
}

Console.ReadLine ();