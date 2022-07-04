using GTC.Utilities;
using GTC.Utilities.Test;
using LoggingOutputHelper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace GTC.Utilities.Tests
{
    // https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/

    [Collection("xUnitHelper Collection")]
    public class BaseCollection_Tests : IClassFixture<xUnitClassFixture>
    {
        xUnitCollectionFixture _collectionFixture;
        xUnitClassFixture _classFixture;

        public BaseCollection_Tests(xUnitClassFixture classFixture, xUnitCollectionFixture collectionFixture, ITestOutputHelper output)
        {
            _collectionFixture = collectionFixture;
            _classFixture = classFixture;
            collectionFixture.ConfigureLogging(output, LogOutputHelper.OutputPath);
        }

        [Theory]
        [ClassData(typeof(TestDataForAddRange))]
        public void HttpRequestHelpers_GetMethodTypeFromString_Test(CollectionOfObjects collection1, CollectionOfObjects collection2, int expectedResult)
        {
            collection1.AddRange(collection2);
            var actualResult = collection1.Count;
            Assert.Equal(expectedResult, actualResult);
        }
    }

    public class TestDataForAddRange : TheoryData<CollectionOfObjects, CollectionOfObjects, int>
    {
        public TestDataForAddRange()
        {
            Add(new CollectionOfObjects(), new CollectionOfObjects(4), 4);
            Add(new CollectionOfObjects(3), new CollectionOfObjects(4), 7);
        }
    }

    public class CollectionOfObjects : BaseCollection<ObjectForCollection>
    {
        public CollectionOfObjects() { }

        public CollectionOfObjects(int numObjects)
        {
            for (int x = 0; x < numObjects; x++)
            {
                base.Add(new ObjectForCollection("Test String Value", x));
            }
        }
    }

    public class ObjectForCollection
    {
        public string someString { get; set; }
        public int someInt { get; set; }

        public ObjectForCollection() { }

        public ObjectForCollection(string strValue, int intValue)
        {
            someString = strValue;
            someInt = intValue;
        }
    }
}
