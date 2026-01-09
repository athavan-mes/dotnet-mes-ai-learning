using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_Methods_Parameters.Actions
{
    public class ProductionCalculator
    {
        public int CalculateTotal(int[] hourlyCounts)
        {
            int total = 0;
            foreach (int hourly in hourlyCounts) 
            { 
                total += hourly;
            }
            return total;
        }

        public double CalculateAverage(int totalProduction, int hours)
        {
            if (hours == 0)
                throw new ArgumentException("Hours Cannot be zero");
            return (double)totalProduction / hours;
        }

        public double CalculateOEE(double availability , double performance, double quality)
        {
            return availability * performance * quality;
        }
    }
}
