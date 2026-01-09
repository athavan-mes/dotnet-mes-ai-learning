
using Day07_Inheritance_Polymorphism.BaseModels;

namespace Day07_Inheritance_Polymorphism.DerrivedModels
{
    
    public class CncMachine: Machine
    {
        public CncMachine(string id , string name):base(id, name) { }
        public override void Start()
        {
            Status = "Running";
            Console.WriteLine($"CNC {Id} - {Name} is cutting material.");

        }

    }
}
