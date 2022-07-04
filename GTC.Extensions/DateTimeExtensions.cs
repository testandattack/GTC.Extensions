using System;

namespace GTC.Extensions
{
    /// <summary>
    /// Extension class for <see cref="DateTime"/> objects that exposes extra methods.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Calculates the number of days since January 1, 2000 and returns that value.
        /// </summary>
        /// <param name="theDate">the DtaeTime ob ject to which this extension method is exposed. </param>
        /// <returns>an <see cref="int"/> representing the number of days.</returns>
        public static int DaysSince2000(this DateTime theDate)
        {
            return (int)theDate.Subtract(new DateTime(2000, 1, 1)).TotalDays;
        }

        /// <summary>
        /// Gets the number of elapsed seconds between the <paramref name="dateTime"/> object and the current DateTime.
        /// </summary>
        /// <remarks>This method is useful to calculate elapsed execution times for various code that needs to log or report metrics.</remarks>
        /// <param name="dateTime">the DtaeTime ob ject to which this extension method is exposed. </param>
        /// <returns>a <see cref="double"/> that reprersents the total seconds.</returns>
        public static double GetElapsedSeconds(this DateTime dateTime)
        {
            TimeSpan ts = DateTime.UtcNow - dateTime;
            return ts.TotalSeconds;
        }

        /// <summary>
        /// Gets the number of elapsed seconds between the <paramref name="dateTime"/> object and the current DateTime, using 
        /// the 'N1' format for the value.
        /// </summary>
        /// <param name="dateTime">the DtaeTime ob ject to which this extension method is exposed. </param>
        /// <returns>a formatted <see cref="string"/> that reprersents the total seconds.</returns>
        public static string GetElapsedSecondsForDisplay(this DateTime dateTime)
        {
            return dateTime.GetElapsedSeconds().ToString("N1");
        }

        /// <summary>
        /// Gets the number of elapsed seconds between the <paramref name="dateTime"/> object 
        /// and the current DateTime, using the specified <paramref name="numberFormat"/> format for the value.
        /// </summary>
        /// <param name="dateTime">the DtaeTime ob ject to which this extension method is exposed. </param>
        /// <param name="numberFormat"></param>
        /// <returns>a formatted <see cref="string"/> that reprersents the total seconds.</returns>
        public static string GetElapsedSecondsForDisplay(this DateTime dateTime, string numberFormat)
        {
            return dateTime.GetElapsedSeconds().ToString(numberFormat);
        }
    }
}
