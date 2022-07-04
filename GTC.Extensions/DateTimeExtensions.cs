using System;

namespace GTC.Extensions
{
    /// <summary>
    /// A set of extension methods for <see cref="DateTime"/> objects.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Calculates the number of days since January 1, 2000.
        /// </summary>
        /// <param name="source">The DateTime to which this method is exposed.</param>
        /// <returns>an int.</returns>
        public static int DaysSince2000(this DateTime source)
        {
            return (int)source.Subtract(new DateTime(2000, 1, 1)).TotalDays;
        }

        /// <summary>
        /// Calculates the number of seconds between the object's creation time and <see cref="DateTime.UtcNow"/>.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> to which this method is exposed.</param>
        /// <param name="useMathFloor"> If true, the returned value is rounded DOWN to the nearest integer number, if False, the 
        /// returned value is rounded UP to the next nearest integer value.</param>
        /// <returns>a double.</returns>
        public static double GetElapsedSeconds(this DateTime dateTime, bool useMathFloor = true)
        {
            TimeSpan ts = DateTime.UtcNow - dateTime;
            if (useMathFloor)
                return Math.Floor(ts.TotalSeconds);
            else
                return Math.Ceiling(ts.TotalSeconds);
        }

        /// <summary>
        /// Calculates the number of seconds between the object's creation time and <see cref="DateTime.UtcNow"/>, formatting it as
        /// a string using the <see href="https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString"/>
        /// string formatter.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> to which this method is exposed.</param>
        /// <returns>a string.</returns>
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
