using MiniMES.Domain.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Infrastructure.Repositories
{
    public  interface IProductionRepository
    {
        void SaveProduction(MachineType machineType, string machineId, int input, int output);
    }
}
