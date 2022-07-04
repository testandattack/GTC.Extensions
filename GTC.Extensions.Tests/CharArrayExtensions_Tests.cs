using System;
using Xunit;
using GTC.Extensions;

namespace GTC.Extensions.Test
{
    public class CharArrayExtensions_Tests
    {
        string testStr = "this is a test";

        [Theory]
        [InlineData('a')]
        [InlineData(' ')]
        public void CharArrayExtensions_Contains_Test1(char value)
        {
            char[] testCharArray = testStr.ToCharArray();
            Assert.True(testCharArray.Contains(value));
        }

        [Theory]
        [InlineData('z')]
        public void CharArrayExtensions_Contains_Test2(char value)
        {
            char[] testCharArray = testStr.ToCharArray();
            Assert.False(testCharArray.Contains(value));
        }

        [Theory]
        [InlineData('a', 8)]
        [InlineData(' ', 4)]
        [InlineData('z', -1)]
        public void CharArrayExtensions_Location_Test1(char value, int expectedResponse)
        {
            char[] testCharArray = testStr.ToCharArray();
            Assert.Equal(expectedResponse, testCharArray.Location(value));
        }


        [Fact]
        public void CharArrayExtensions_AsString_Test1()
        {
            char[] testCharArray = testStr.ToCharArray();
            Assert.Equal(testCharArray.AsString(), testStr);
        }


    }
}
