

using Day07_Inheritance_Polymorphism.BaseModels;
using Day07_Inheritance_Polymorphism.DerrivedModels;

// Create a list of different machine types
List<Machine> machines = new()
{
    new CncMachine ("C01" ,"Facing"),
    new RobotMachine ("R01", "Picking"),
    new ConveyorMachine ("CV01", "Main")
};


// Start each machine and display its status
foreach (Machine machine in machines)
{
    machine.Start();
}
