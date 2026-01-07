using Day07_Inheritance_Polymorphism.BaseModels;


namespace Day07_Inheritance_Polymorphism.DerrivedModels
{
    public class ConveyorMachine:Machine
    {
        public ConveyorMachine(string id , string name):base(id , name) { }
        public override void Start()
        {
            Status = "Running";
            Console.WriteLine($"Conveyor {Id} - {Name} is moving material.");

        }
    }
}
