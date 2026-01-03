// Day 03 Learning

// Project type Console APP

// 1. if else
// 2. else if
// 3. logical operators
// 4. switch
// 5. for loop
// 6. while loop
// 7. do while
// 8. continue , break 
// 9. 

// 1. if else
using System.ComponentModel;

int temperature = 85;

if (temperature < 80)
{
    Console.WriteLine("Temperature is Normal");

}
else
{
    Console.WriteLine("Temperature is High");
}

// 2. else if

int machineStatus = 2;   // 0 = Stop, 1 = Idle, 2 = Running

if (machineStatus == 0)
{
    Console.WriteLine("Machine Stopped");

}
else if (machineStatus == 1)
{
    Console.WriteLine("Machine Idel");

}
else if (machineStatus == 2)
{
    Console.WriteLine("Machine Running");
}
else
{
    Console.WriteLine("Unkown State");
}

// 3. logical operators

bool isRunning  = false;
int speed = 120;

if(isRunning && speed > 100)
{
    Console.WriteLine("Production is Inprogress");
}

// 4. switch

int shiftNumber = 2;

// 1-Morning 2- Evening 3-Night

switch(shiftNumber)
{
    case 1:
         Console.WriteLine("Morning Shift");
        break;

    case 2:
        Console.WriteLine("Evening Shift");
        break;
    case 3:
        Console.WriteLine("Night Shift");
        break;
    default:
        Console.WriteLine("Invalid Shift");
        break;             

}

// 5. for loop

for (int i = 0; i < 10; i++)
{ 
    Console.WriteLine($"Production Count {i}");
}

// 6. while Loop

int Count = 0;
while (Count < 3)
{
    Console.WriteLine("Tool Running Fine");
    Count++;

}


// 7. do While

int retryCount =0;
do
{
    Console.WriteLine("Checking Sensor Status");
    retryCount++;

}while (retryCount < 3);

// 8. break , continue

for (int i = 1; i <= 5; i++)
{
    if (i == 3)
        continue;

    if (i == 5)
        break;

    Console.WriteLine(i);
}

//Mini Exercise

/* Write logic to:

Loop through 10 machines

If machine number is 5 → skip

If machine number is 8 → stop loop

Print remaining machine numbers */



for( int machineNumber = 1; machineNumber <= 10; machineNumber++)
{
    if(machineNumber == 5)
        continue;
    else if (machineNumber == 8)
        break;

        Console.WriteLine($"Machine Number {machineNumber}");

}

