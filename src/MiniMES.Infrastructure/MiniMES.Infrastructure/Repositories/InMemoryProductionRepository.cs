using MiniMES.Domain.Machines;
using MiniMES.Application.Abstractions;


namespace MiniMES.Infrastructure.Repositories
{
    public class InMemoryProductionRepository : IProductionRepository
    {
        private static readonly List<string> _store = new();
        public void SaveProduction(
            MachineType machineType,
            string machineId,
            int input,
            int output)
        {
            var record = $"{DateTime.UtcNow:o} | {machineType} | {machineId} | Input={input} | Output={output} ";
            _store.Add(record);
        }

        // Help[er for debugging / testing
        public IReadOnlyList<string> GetAll() => _store.AsReadOnly();
    }
}
