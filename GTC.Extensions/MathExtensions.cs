using System;
using System.Collections.Generic;
using System.Linq;

namespace GTC.Extensions
{
    /// <summary>
    /// Extension class for <see cref="IEnumerable{T}"/> objects that exposes Statistical mathematics methods.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Allows you to call either Sample based or Normal Std Dev methods that are based on this article:
        /// https://stackoverflow.com/questions/2253874/standard-deviation-in-linq  
        /// 
        /// </summary>
        /// <param name="values">The <see cref="IEnumerable{T}"/> list to which the method is exposed.</param>
        /// <param name="useNormalStdDev"></param>
        /// <param name="minNumberOfEntries"></param>
        /// <returns>A <see cref="double"/> that contains the standard deviation.</returns>
        public static double? StdDev(this IEnumerable<double> values, bool useNormalStdDev, int minNumberOfEntries = 10)
        {
            if (values.Count() < minNumberOfEntries)
                return null;

            if (useNormalStdDev)
                return values.NormalStdDev();
            else
                return values.SampleStdDev();
        }

        /// <summary>
        /// SAMPLE Std Dev
        /// https://stackoverflow.com/questions/2253874/standard-deviation-in-linq  
        /// </summary>
        /// <param name="values">The <see cref="IEnumerable{T}"/> list to which the method is exposed.</param>
        /// <returns>A <see cref="double"/> that contains the standard deviation.</returns>
        public static double SampleStdDev(this IEnumerable<double> values)
        {

            // ref: http://warrenseen.com/blog/2006/03/13/how-to-calculate-standard-deviation/
            double mean = 0.0;
            double sum = 0.0;
            double stdDev = 0.0;
            int n = 0;
            foreach (double val in values)
            {
                n++;
                double delta = val - mean;
                mean += delta / n;
                sum += delta * (val - mean);
            }
            if (1 < n)
                stdDev = Math.Sqrt(sum / (n - 1));

            return stdDev;
        }

        /// <summary>
        /// NORMAL Std Dev
        /// https://stackoverflow.com/questions/2253874/standard-deviation-in-linq  
        /// Divide by n instead of divide by n-1
        /// </summary>
        /// <remarks>
        /// If a data distribution is approximately normal then about 68 percent of the data values are 
        /// within one standard deviation of the mean (mathematically, μ ± σ, where μ is the arithmetic mean), 
        /// about 95 percent are within two standard deviations (μ ± 2σ), and about 99.7 percent lie within 
        /// three standard deviations (μ ± 3σ). This is known as the 68-95-99.7 rule, or the empirical rule.
        /// See this link for more information: http://warrenseen.com/blog/2006/03/13/how-to-calculate-standard-deviation/
        /// </remarks>
        /// <param name="values">The <see cref="IEnumerable{T}"/> list to which the method is exposed.</param>
        /// <returns>A <see cref="double"/> that contains the standard deviation.</returns>
        public static double NormalStdDev(this IEnumerable<double> values)
        {
            double mean = 0.0;
            double sum = 0.0;
            double stdDev = 0.0;
            int n = 0;
            foreach (double val in values)
            {
                n++;
                double delta = val - mean;
                mean += delta / n;
                sum += delta * (val - mean);
            }
            if (1 < n)
                stdDev = Math.Sqrt(sum / n);

            return stdDev;
        }



        /// <summary>
        /// Returns the value from the list that is the largest value
        /// within the subset of percentile values sorted by
        /// smallest to largest.
        /// </summary>
        /// <remarks>
        /// To get the value 
        /// <list type="number">
        /// <item>The list is sorted from smallest to largest.</item>
        /// <item>The index for the value is calculated by multiplying the list's count by the <paramref name="percentile"/>.</item>
        /// <item>The value at the calculated index is returned.</item>
        /// </list>  
        /// <c>Math.Floor(values.Count() * percentile);</c>
        /// calculated and the and the value just before that one is returned.
        /// </remarks>
        /// <param name="values">The <see cref="IEnumerable{T}"/> list to which the method is exposed.</param>
        /// <param name="percentile">a <see cref="double"/> numeric between 0 and 1.</param>
        /// <returns></returns>
        public static int? PercentileValue(this IEnumerable<double> values, double percentile, int minNumberOfEntries = 10)
        {
            if (values == null)
            {
                return null;
            }

            if(values.Count() < minNumberOfEntries)
            {
                return null;
            }
            var sortedValues = values.OrderBy(v => v);

            int ordinal = (int)Math.Floor(values.Count() * percentile);
            return (int?)values.ElementAt(ordinal);
        }
    }
}
