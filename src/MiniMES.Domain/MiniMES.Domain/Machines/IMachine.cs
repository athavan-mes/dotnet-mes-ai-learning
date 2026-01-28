

namespace MiniMES.Domain.Machines
{
    public interface IMachine
    {
        string MachineId { get; }
        MachineType Type { get; }

        public void Start();
        public void Stop();
         public int Produce(int input);

    }
}

