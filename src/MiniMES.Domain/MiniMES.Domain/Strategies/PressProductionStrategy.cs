using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Domain.Strategies
{
    /// <summary>
    /// Represents a production strategy that calculates output for press operations.
    /// </summary>
    public class PressProductionStrategy : IProductionStrategy
    {
        public int Calculate(int input)
        {
            return (int)(input * 10);
        }
    }
}
