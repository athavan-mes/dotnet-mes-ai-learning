

using Day07_Inheritance_Polymorphism.BaseModels;
using Day07_Inheritance_Polymorphism.DerrivedModels;

List<Machine> machines = new()
{
    new CncMachine ("C01" ,"Facing"),
    new RobotMachine ("R01", "Picking"),
    new ConveyorMachine ("CV01", "Main")
};

foreach (Machine machine in machines)
{
    machine.Start();
}
