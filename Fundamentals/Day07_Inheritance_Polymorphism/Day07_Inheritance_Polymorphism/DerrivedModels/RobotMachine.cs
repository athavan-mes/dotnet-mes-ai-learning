using Day07_Inheritance_Polymorphism.BaseModels;


namespace Day07_Inheritance_Polymorphism.DerrivedModels
{
    /// <summary>
    /// Represents a machine that performs robotic material cutting operations.
    /// </summary>
    public class RobotMachine:Machine
    {
        public RobotMachine(string id , string name) : base(id , name) { }
        public override void Start()
        {
            Status = "Running";
            Console.WriteLine($"Robot {Id} - {Name} is cutting material.");

        }
    }
}
