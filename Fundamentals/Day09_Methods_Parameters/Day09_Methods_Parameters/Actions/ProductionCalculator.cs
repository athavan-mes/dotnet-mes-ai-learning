using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_Methods_Parameters.Actions
{
    /// <summary>
    /// Provides calculation utilities for production metrics such as total output,
    /// average production rate, and Overall Equipment Effectiveness (OEE).
    /// </summary>
    public class ProductionCalculator
    {
        /// <summary>
        /// Calculates the total number of pieces produced during a shift.
        /// </summary>
        /// <param name="hourlyCounts">
        /// An array containing the number of pieces (PCE) produced in each hour.
        /// </param>
        /// <returns>
        /// The total number of pieces produced during the shift.
        /// </returns>
        public int CalculateTotal(int[] hourlyCounts)
        {
            int total = 0;
            foreach (int hourly in hourlyCounts) 
            { 
                total += hourly;
            }
            return total;
        }

        /// <summary>
        /// Calculates the average number of pieces produced per hour during a shift.
        /// </summary>
        /// <param name="totalProduction">
        /// The total number of pieces (PCE) produced during the shift.
        /// </param>
        /// <param name="hours">
        /// The total duration of the shift or production time in hours.
        /// </param>
        /// <returns>
        /// The average number of pieces produced per hour.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="hours"/> is zero.
        /// </exception>
        public double CalculateAverage(int totalProduction, int hours)
        {
            if (hours == 0)
                throw new ArgumentException("Hours Cannot be zero");
            return (double)totalProduction / hours;
        }
        /// <summary>
        /// Calculates the Overall Equipment Effectiveness (OEE) of a machine
        /// based on availability, performance, and quality factors.
        /// </summary>
        /// <param name="availability">
        /// The availability ratio of the machine (value between 0.0 and 1.0).
        /// </param>
        /// <param name="performance">
        /// The performance ratio of the machine (value between 0.0 and 1.0).
        /// </param>
        /// <param name="quality">
        /// The quality ratio of the machine (value between 0.0 and 1.0).
        /// </param>
        /// <returns>
        /// The calculated OEE value as a ratio between 0.0 and 1.0.
        /// </returns>
        public double CalculateOEE(double availability , double performance, double quality)
        {
            return availability * performance * quality;
        }
    }
}
