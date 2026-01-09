
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

//Points to remember 
/* 
 * What is OOP?
 *  -Programming Paradigm (way of designing software) where you organize code around objets instead of only functions or logic
 * What is Object?
 *  - real world entity represented in code
 *  - each object has properties(data) and Behaviors(actions)
 *  - class is blueprint or template
 *  - object is instance of a class
 *  
 * Encapsulation(Data Protection)
 *  - hiding internal details and exposing only what is necessary
 *  - prevents invalid access
 *  - Improves security
 *  - ** private properties
 *  
 * Inheritance(Reuse)
 *  - reuse another class's features
 *  - reduce duplication
 *  - builds hierarchy
 *  - ** :
 *  
 * Polymorphism(Many Forms)
 *  - Same method name different behavior
 *  - flexible code
 *  - easy to extend
 *  - ** virtual , override
 *  
 * Abstraction(Simplification)
 *  - showing only essential features
 *  - hides complexity
 *  - improves design
 *  - ** interface , abstract
 *  
 *  
 * Access Modifiers
 *  Public - everywhere
 *  private - same class
 *  Protected - Derived classes
 *  internal - same assembly
 *  protected internal - combined
 *  
 *  
 *  
 *
 *  
 *  
 */


/* =========================================================
   CTS – Common Type System (in .NET / C#)
   =========================================================

   CTS defines how data types are declared, used, and 
   managed in the .NET runtime so that all .NET languages
   can interoperate.
*/

// ---------- CTS TYPES ----------

// class     → Reference type
// interface → Contract / abstraction
// struct    → Value type (lightweight object)
// enum      → Named numeric constants
// delegate  → Type-safe function pointer



/* =========================================================
   Members of a Class
   ========================================================= */

// 1. Fields
//    Variables that store data

// 2. Constructors
//    Used to initialize the object

// 3. Properties
//    Controlled access to fields

// 4. Methods
//    Behavior of the class

// 5. Events
//    Used to notify other objects

// 6. Indexers
//    Allow objects to be accessed like arrays

// 7. Operators
//    Custom operator overloading

// 8. Nested Types
//    Classes inside classes

/* =========================================================
   Members of an Interface
   ========================================================= */

// 1. Methods
//    Define behavior (no implementation by default)

// 2. Properties
//    Define getters and setters

// 3. Events
//    Define notifications

// 4. Indexers
//    Allow indexed access

// 5. Default Interface Methods (C# 8+)
//    Methods with implementation

// 6. Static Members (C# 8+)
//    Static methods and fields


/* =========================================================
   Members of a Struct
   ========================================================= */

// 1. Fields
//    Variables that store data

// 2. Constructors
//    Used to initialize the struct

// 3. Properties
//    Controlled access to fields

// 4. Methods
//    Define behavior

// 5. Events
//    Notifications (rare, but allowed)

// 6. Indexers
//    Allow array-like access

// 7. Operators
//    Operator overloading (+, -, ==, etc.)

// 8. Nested Types
//    Structs, classes, enums inside a struct


/* Enum members are:

        - Named constants

        - Backed by an integer type (default: int)

        - Static

        - Read-only

*/


/*
 * Unlike classes, delegates do not have fields, properties, or methods written by us.
But internally, every delegate type has these built-in members:

Member	- Purpose
Invoke()	- Calls the method
BeginInvoke()	- Starts async call (obsolete now)
EndInvoke()	- Ends async call
GetInvocationList()	- Returns all methods in multicast delegate
Target	- Object on which the method is called
Method	- Information about the method
*/
