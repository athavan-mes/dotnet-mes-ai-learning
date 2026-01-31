using MiniMES.Domain.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Infrastructure.Repositories
{
    public class SqlIProductionRepository : IProductionRepository
    {
        public void SaveProduction(
            MachineType machineType,
            string machineId,
            int input,
            int output)
        {
            // TODO:
            // - EF core or Dapper implementation
            // - Transaction handling
            // - Retry / resiliency

            throw new NotImplementedException();
        }
    }
}
