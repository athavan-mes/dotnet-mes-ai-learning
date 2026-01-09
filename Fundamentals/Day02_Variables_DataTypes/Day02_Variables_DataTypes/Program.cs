// Day 02 Learning

// Project type Console APP

// 1.Variable declaration
// 2.Valus Type vs Reference Type
// 3.var vs Explicit Type
// 4.Constants & Readonly
// 5.Nullable Types
// 6.Type Conversion
// 7.Create Git Branch , Commit code , Merge Branch 

// Syntax :
// type identifier  = value;   // declared and assigned/initilized
// type identifier ; identifier = value;  // declared and then initilized later


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




/* =========================================================
   C# Data Types – Points to Remember
   ========================================================= */

// ---------- INTEGER TYPES ----------
// Signed integers
// int    = System.Int32   = 32-bit signed
// long   = System.Int64   = 64-bit signed
// short  = System.Int16   = 16-bit signed
// sbyte  = System.SByte  = 8-bit signed

// Unsigned integers
// uint   = System.UInt32 = 32-bit unsigned
// ulong  = System.UInt64 = 64-bit unsigned
// ushort = System.UInt16 = 16-bit unsigned
// byte   = System.Byte  = 8-bit unsigned


// ---------- FLOATING POINT TYPES ----------
// float  = System.Single = 32-bit (approximate)
// double = System.Double = 64-bit (approximate)
// decimal = System.Decimal = 128-bit (high precision, financial)


// ---------- CHARACTER & BOOLEAN ----------
// char = System.Char = 16-bit Unicode character
// bool = System.Boolean = true / false (1 byte)


// ---------- TEXT ----------
// string = System.String = sequence of characters (immutable)


// ---------- BASE TYPE ----------
// object = System.Object = base type of all C# types


// ---------- DYNAMIC ----------
// dynamic = runtime-typed variable (type resolved at runtime)


// ---------- VOID ----------
// void = represents no return value (used for methods)


// ---------- VALUE TYPES ----------
// struct = custom value type
// enum   = named numeric constants


// ---------- COLLECTION TYPES ----------
// Array  = fixed-size collection of same type
// Tuple  = group of multiple values of different types







