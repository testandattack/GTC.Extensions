using LoggingOutputHelper;
using System.Net.Http;
using Xunit;
using Xunit.Abstractions;

namespace GTC.HttpUtilities.Tests
{
    // https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/

    [Collection("xUnitHelper Collection")]
    public class HttpRequestHelpers_Tests : IClassFixture<xUnitClassFixture>
    {
        xUnitCollectionFixture _collectionFixture;
        xUnitClassFixture _classFixture;

        public HttpRequestHelpers_Tests(xUnitClassFixture classFixture, xUnitCollectionFixture collectionFixture, ITestOutputHelper output)
        {
            _collectionFixture = collectionFixture;
            _classFixture = classFixture;
            collectionFixture.ConfigureLogging(output, LogOutputHelper.OutputPath);
        }

        [Theory]
        [ClassData(typeof(TestDataForGetMethodTypeFromString))]
        public void HttpRequestHelpers_GetMethodTypeFromString_Test(string methodTypeAsString, HttpMethod expectedResponse)
        {
            var actualResponse = HttpRequestHelpers.GetMethodTypeFromString(methodTypeAsString);
            Assert.Equal(expectedResponse, actualResponse);
        }
    }

    public class TestDataForGetMethodTypeFromString : TheoryData<string, HttpMethod>
    {
        public TestDataForGetMethodTypeFromString()
        {
            Add("DELETE", HttpMethod.Delete);
            Add("GET", HttpMethod.Get);
            Add("HEAD", HttpMethod.Head);
            Add("OPTIONS", HttpMethod.Options);
            Add("PATCH", HttpMethod.Patch);
            Add("POST", HttpMethod.Post);
            Add("PUT", HttpMethod.Put);
            Add("TRACE", HttpMethod.Trace);
            Add("Invalid Value", HttpMethod.Get);
        }
    }
}
