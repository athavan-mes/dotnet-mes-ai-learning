// Day 02 Learning

// Project type Console APP

// 1.Variable declaration
// 2.Valus Type vs Reference Type
// 3.var vs Explicit Type
// 4.Constants & Readonly
// 5.Nullable Types
// 6.Type Conversion
// 7.Create Git Branch , Commit code , Merge Branch 


int machineId = 100;
string machineName = "Planning-01";
string machineDescription = "Machine were Production order will be Planned , like lable printing etc..";
bool isRunning = true;
double temperature = 70.8;

var speed = 100.0;
// speed = "fast"; // will get complie time error because  variable speed is already assigned with value typw double

const double maxTemperature = 100; // const Complie time and readonly runtime

// int downtime = null; // will get error because int doesn't normally allow  null 
int? downtime = null; // 

// Conversion
string input = "45";
int rpm = int.Parse(input);


Console.WriteLine($"Machine {machineName}- ID {machineId} Running :{isRunning}");
Console.WriteLine($"Temperature : {temperature} and Max temperature allowed is {maxTemperature}");


string operatorName = "Athavan M";
int shiftNumber = 1;
double machineSpeed = 77.0;
bool isMaintenanceRequired = false;
long productionCount = 100000;


Console.WriteLine($"Operator Name : {operatorName}");
Console.WriteLine($"Shift Number : {shiftNumber}");
Console.WriteLine($"Machine Speed is {machineSpeed}");
Console.WriteLine($"Maintenance Reqquired {isMaintenanceRequired}");
Console.WriteLine($"Curren Production Count {productionCount}");


        

