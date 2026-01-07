
namespace Day07_Inheritance_Polymorphism.BaseModels
{
    public abstract class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public long Produced { get; set; }

        protected  Machine(string id, string name)
        {
            Id = id;
            Name = name;
            Status = "Idle";

        }
       

        public virtual void Start()
        {
            Status = "Running";
            Console.WriteLine($"Machine {Id}-{Name} started");
        }

        public virtual void Stop()
        {
            Status = "Stopped";
            Console.WriteLine($"Machine {Id}-{Name} Stopped");
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"{Id}-{Name} is {Status}");
        }

        public void AddProductionCount(int materialCount)
        {
            Produced += materialCount;

        }
    }
}
