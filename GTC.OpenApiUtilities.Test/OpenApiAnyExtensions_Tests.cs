using LoggingOutputHelper;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using Microsoft.OpenApi.Writers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using GTC.Extensions;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi;
using Xunit.Abstractions;

namespace GTC.OpenApiUtilities.Test
{
    // https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/

    [Collection("xUnitHelper Collection")]
    public class OpenApiAnyExtensions_Tests : IClassFixture<xUnitClassFixture>
    {
        xUnitCollectionFixture _collectionFixture;
        xUnitClassFixture _classFixture;

        public OpenApiAnyExtensions_Tests(xUnitClassFixture classFixture, xUnitCollectionFixture collectionFixture, ITestOutputHelper output)
        {
            _collectionFixture = collectionFixture;
            _classFixture = classFixture;
            collectionFixture.ConfigureLogging(output, LogOutputHelper.OutputPath);
        }

        [Theory]
        [ClassData(typeof(TestDataForGetRequestBody))]
        public void OpenApiAnyExtensions_GetPrimitiveValue_Test(IOpenApiAny item, string expectedResponse)
        {
            var actualResponse = item.GetPrimitiveValue();
            Assert.Equal(expectedResponse, actualResponse);
        }
    }
    public class TestDataForGetRequestBody : TheoryData<IOpenApiAny, string>
    {
        private string expectedDateTime = "2021-03-23 1:34:56 PM";
        private string expectedDate = "2021-03-23";
        private string expectedInt = "4";
        private string expectedString = "Test String";
        private string expectedBool = "True";
        private string expectedDouble = "0.1";
        private string expectedFloat = "3.141592";
        private string expectedLong = "9223372036854775807";
        private string expectedByte = "32";
        private string expectedByteArray = "12345";

        public TestDataForGetRequestBody()
        {
            Add(GetOpenApiItem(Convert.ToDateTime("2021-03-23 13:34:56")), expectedDateTime);
            Add(GetOpenApiItem(Convert.ToDateTime("2021-03-23 00:00:00")), expectedDate);
            Add(GetOpenApiItem((int)4), expectedInt);
            Add(GetOpenApiItem((string)"Test String"), expectedString);
            Add(GetOpenApiItem((bool)true), expectedBool);
            Add(GetOpenApiItem((double)0.1), expectedDouble);
            Add(GetOpenApiItem((float)3.141592), expectedFloat);
            Add(GetOpenApiItem((long)9223372036854775807), expectedLong);
            Add(GetOpenApiItem((byte)32), expectedByte);
            Add(GetOpenApiItem(new byte[] {1,2,3,4,5 }), expectedByteArray);
        }

        private IOpenApiAny GetOpenApiItem(object item)
        {
            Type itemType = item.GetType();

            if (itemType == typeof(DateTime) &&
                ((DateTime)item).TimeOfDay == TimeSpan.Zero)
                return new OpenApiDate((DateTime)item);
            if (itemType == typeof(DateTime) &&
                ((DateTime)item).TimeOfDay != TimeSpan.Zero)
                return new OpenApiDateTime(new DateTimeOffset((DateTime)item));
            if (itemType == typeof(int))
                return new OpenApiInteger((int)item);
            if (itemType == typeof(string))
                return new OpenApiString((string)item);
            if (itemType == typeof(bool))
                return new OpenApiBoolean((bool)item);
            if (itemType == typeof(double))
                return new OpenApiDouble((double)item);
            if (itemType == typeof(float))
                return new OpenApiFloat((float)item);
            if (itemType == typeof(long))
                return new OpenApiLong((long)item);
            if (itemType == typeof(byte))
                return new OpenApiByte((byte)item);
            if (itemType == typeof(byte[]))
                return new OpenApiBinary((byte[])item);

            return new OpenApiString("");


        }
    }
}