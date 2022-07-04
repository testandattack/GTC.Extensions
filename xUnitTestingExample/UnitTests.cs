using Serilog;
using System;
using Xunit;

namespace XUnitTestingExample
{
    // Documentation on Xunit shared context behaviors can be found at:
    // https://xunit.github.io/docs/shared-context
    // This file allows for validation of the behaviors.

    #region -- Xunit Collection Fixture Declaration -----
    // https://xunit.github.io/docs/shared-context#collection-fixture
    public class XunitCollectionFixture : IDisposable
    {
        public string FixtureName { get; set; }
        private Guid _guid;
        public XunitCollectionFixture()
        {
            _guid = Guid.NewGuid();
            FixtureName = $"{_guid}";
        }

        public void Dispose()
        {
            FixtureName = "XunitCollectionFixture value disposed";
        }
    }

    [CollectionDefinition("Xunit Collection")]
    public class XunitCollection : ICollectionFixture<XunitCollectionFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
    #endregion

    #region - Xunit Class Fixture Declaration -----
    // https://xunit.github.io/docs/shared-context#class-fixture
    public class XunitClassFixture : IDisposable
    {
        public string FixtureName { get; set; }
        private Guid _guid;
        public XunitClassFixture()
        {
            _guid = Guid.NewGuid();
            FixtureName = $"{_guid}";
        }

        public void Dispose()
        {
            FixtureName = "XunitClassFixture value disposed";
        }
    }
    #endregion

    #region -- Sample Xunit tests to evaluate behaviors -----
    [Collection("Xunit Collection")]
    public class ClassOne : IClassFixture<XunitClassFixture>
    {
        XunitClassFixture classFixture;
        XunitCollectionFixture collectionFixture;
        private Guid localGuid;

        // Constructor - https://xunit.github.io/docs/shared-context#constructor
        public ClassOne(XunitClassFixture classFixture, XunitCollectionFixture collectionFixture)
        {
            this.classFixture = classFixture;
            this.collectionFixture = collectionFixture;
            localGuid = Guid.NewGuid();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"C:\temp\xUnitTriage.txt",
                    shared: true,
                    outputTemplate: "[{Level:u3}]{Message:lj}{NewLine}")
                .CreateLogger();
        }

        [Trait("Category", "ClassOneTests")]
        [Fact]
        public void Test1()
        {
            Log.Information("Class1-Test1: local: {0}", localGuid);
            Log.Information("Class1-Test1: class: {0}", classFixture.FixtureName);
            Log.Information("Class1-Test1: collection: {0}", collectionFixture.FixtureName);
        }

        [Trait("Category", "ClassOneTests")]
        [Fact]
        public void Test2()
        {
            Log.Information("Class1-Test2: local: {0}", localGuid);
            Log.Information("Class1-Test2: class: {0}", classFixture.FixtureName);
            Log.Information("Class1-Test2: collection: {0}", collectionFixture.FixtureName);
        }
    }

    [Collection("Xunit Collection")]
    public class ClassTwo : IClassFixture<XunitClassFixture>
    {
        XunitClassFixture classFixture;
        XunitCollectionFixture collectionFixture;
        private Guid localGuid;

        public ClassTwo(XunitClassFixture classFixture, XunitCollectionFixture collectionFixture)
        {
            this.classFixture = classFixture;
            this.collectionFixture = collectionFixture;
            localGuid = Guid.NewGuid();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"C:\temp\xUnitTriage.txt",
                    shared: true,
                    outputTemplate: "[{Level:u3}]{Message:lj}{NewLine}")
                .CreateLogger();
        }

        [Trait("Category", "ClassOneTests")]
        [Fact]
        public void Test1()
        {
            Log.Information("Class2-Test1: local: {0}", localGuid);
            Log.Information("Class2-Test1: class: {0}", classFixture.FixtureName);
            Log.Information("Class2-Test1: collection: {0}", collectionFixture.FixtureName);
        }

        [Trait("Category", "ClassOneTests")]
        [Fact]
        public void Test2()
        {
            Log.Information("Class2-Test2: local: {0}", localGuid);
            Log.Information("Class2-Test2: class: {0}", classFixture.FixtureName);
            Log.Information("Class2-Test2: collection: {0}", collectionFixture.FixtureName);
        }
    }
    #endregion
}
