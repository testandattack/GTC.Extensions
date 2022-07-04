using System;
using Xunit;
using GTC.Extensions;
using System.Threading;

namespace GTC.Extensions.Test
{
    public class DateTimeExtensions_Tests
    {
        [Theory]
        [InlineData("1/1/2001", 366)]
        [InlineData("1/1/2001 13:59:23", 366)]
        [InlineData("3/5/2013", 4812)]
        public void DateTimeExtensions_DaysSince2000_Test(string dateToUse, int expectedResult)
        {
            DateTime dt = Convert.ToDateTime(dateToUse);
            int numDays = dt.DaysSince2000();
            Assert.Equal(expectedResult, numDays);
        }


        [Theory]
        [InlineData(200, 0)]
        [InlineData(1003, 1)]
        [InlineData(4015, 4)]
        public void DateTimeExtensions_GetElapsedSeconds_Test(int value, double expectedValue)
        {
            
            DateTime dt = DateTime.UtcNow;
            Thread.Sleep(value);
            DateTime dt2 = DateTime.UtcNow;

            double elapsedTime = dt.GetElapsedSeconds();
            Assert.Equal(expectedValue, elapsedTime);
        }

        [Theory]
        [InlineData(200, 1)]
        [InlineData(1003, 2)]
        [InlineData(4015, 5)]
        public void DateTimeExtensions_GetElapsedSeconds_RoundedUp_Test(int value, double expectedValue)
        {

            DateTime dt = DateTime.UtcNow;
            Thread.Sleep(value);
            DateTime dt2 = DateTime.UtcNow;

            double elapsedTime = dt.GetElapsedSeconds(false);
            Assert.Equal(expectedValue, elapsedTime);
        }

        [Theory]
        [InlineData(200)]
        [InlineData(1000)]
        [InlineData(4000)]
        public void DateTimeExtensions_GetElapsedSecondsForDisplay_Test(int value)
        {

            DateTime dt = DateTime.UtcNow;
            Thread.Sleep(value);
            DateTime dt2 = DateTime.UtcNow;

            string elapsedTime = dt.GetElapsedSecondsForDisplay();
            int totalTime = int.Parse(elapsedTime.Substring(0, elapsedTime.IndexOf(".")));

            Assert.Equal(totalTime, value / 1000);
        }


    }
}
