using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Domain.Strategies
{
    /// <summary>
    /// Represents a CNC-based production strategy implementing the IProductionStrategy interface.
    /// </summary>
    public class CncProductionStrategy : IProductionStrategy
    {
        public int Calculate(int input)
        {
            
            return (int)(input * 2);
        }

    }
}
