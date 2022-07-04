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
    public class Property_Tests : IClassFixture<xUnitClassFixture>
    {
        xUnitCollectionFixture _collectionFixture;
        xUnitClassFixture _classFixture;

        public Property_Tests(xUnitClassFixture classFixture, xUnitCollectionFixture collectionFixture, ITestOutputHelper output)
        {
            _collectionFixture = collectionFixture;
            _classFixture = classFixture;
            collectionFixture.ConfigureLogging(output, LogOutputHelper.OutputPath);
        }

        [Theory]
        [ClassData(typeof(TestDataForCloneProperty))]
        public void Utilities_CloneProperty_Test(Property property, string newName, object newValue)
        {
            Property clonedProperty = (Property)property.Clone();
            property.Name = newName;
            property.Value = newValue;

            // The name in the cloned copy should not have changed
            Assert.False(clonedProperty.Name == property.Name);
            
            if (property.IsObfuscated)
            {
                // If it is a password, the shown value should be the same, regardless of the actual value
                Assert.True(clonedProperty.Value == property.Value);
                // The actual values should be different
                Assert.False(clonedProperty.GetPwdValue() == property.GetPwdValue());
            }
            else
                // The actual values should be different
                Assert.False(clonedProperty.Value == property.Value);
        }


        [Theory]
        [ClassData(typeof(TestDataForCreateProperty))]
        public void Utilities_CreateProperty_Test(string name, object objValue, bool isPassword, string expectedString)
        {
            if (isPassword)
            {
                Property property = new Property(name, objValue.ToString(), isPassword);
                Assert.Equal(expectedString, property.Value.ToString());
                Assert.Equal(objValue.ToString(), property.GetPwdValue());
            }
            else
            {
                Property property = new Property(name, objValue);
                Assert.Equal(expectedString, property.Value.ToString());
            }
        }
    }

    public class TestDataForCloneProperty : TheoryData<Property, string, object>
    {
        public TestDataForCloneProperty()
        {
            Add(new Property("User", "SomeUser", false), "User2", "AnotherUser");
            Add(new Property("User", 23), "User2", 25);
            Add(new Property("User", "SomePassword", true), "User2", "Password");
        }
    }


    public class TestDataForCreateProperty : TheoryData<string, object, bool, string>
    {
        public TestDataForCreateProperty()
        {
            Add("User", "SomeUser", false, "SomeUser");
            Add("User", "SomeUser", true, "********");
            Add("User", 23, false, "23");
        }
    }
}
