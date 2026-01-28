using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMES.Domain.Strategies
{
    /// <summary>
    /// Defines a strategy for calculating a production value based on an input.
    /// </summary>
    public interface IProductionStrategy
    {
        int Calculate(int input);
    }
}
