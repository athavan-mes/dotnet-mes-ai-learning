using MiniMES.Domain.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        // Help[er for debugging / testing
        public IReadOnlyList<string> GetAll() => _store.AsReadOnly();
    }
}
