using LoggingOutputHelper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace GTC.HttpUtilities.Tests
{
    // https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/

    [Collection("xUnitHelper Collection")]
    public class HttpRequestMessageExtensions_Tests : IClassFixture<xUnitClassFixture>
    {
        xUnitCollectionFixture _collectionFixture;
        xUnitClassFixture _classFixture;

        public HttpRequestMessageExtensions_Tests(xUnitClassFixture classFixture, xUnitCollectionFixture collectionFixture, ITestOutputHelper output)
        {
            _collectionFixture = collectionFixture;
            _classFixture = classFixture;
            collectionFixture.ConfigureLogging(output, LogOutputHelper.OutputPath);
        }

        [Theory]
        [ClassData(typeof(TestDataForGetRequestBody))]
        public void HttpRequestMessageExtensions_GetRequestBody_Test(HttpRequestMessage message, string expectedResponse)
        {
            if (expectedResponse != "Not Implemented")
            {
                string actualResponse = message.GetRequestBody();
                Assert.Equal(expectedResponse, actualResponse);
            }
            else
            {
                bool exceptionThrown = false;
                try
                {
                    string actualResponse = message.GetRequestBody();
                }
                catch(NotImplementedException ex)
                {
                    exceptionThrown = true;
                }
                Assert.True(exceptionThrown == true);
            }
        }

        [Theory]
        [ClassData(typeof(TestDataForGetContentHeaders))]
        public void HttpRequestMessageExtensions_GetContentHeaders_Test(HttpRequestMessage message, Dictionary<string, string> expectedResponse)
        {
            var actualResponse = message.GetContentHeaders();
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Theory]
        [ClassData(typeof(TestDataForGetFormPostParamsFromContent))]
        public void HttpRequestMessageExtensions_GetFormPostParamsFromContent_Test(HttpRequestMessage message, Dictionary<string, string> expectedResponse)
        {
            var actualResponse = message.GetFormPostParamsFromContent();
            Assert.Equal(expectedResponse, actualResponse);
        }
    }

    #region -- TheoryData -----
    public class TestDataForGetRequestBody : TheoryData<HttpRequestMessage, string>
    {
        private string noContentValue = "No request content found";
        private string stringValue = "this is some static string content";
        private string multiPartFormValue = "Not Implemented";
        private string byteArrayValue = "12345";
        private string formUrlEncodedValue = "Key1=Value1&Key2=Value2"; //application/x-www-form-urlencoded

        public TestDataForGetRequestBody()
        {
            var testRequests = new BuildTestRequests();

            Add(testRequests.BuildMessageWithNoContent(), noContentValue);
            Add(testRequests.BuildMessageWithStringContent(stringValue), stringValue);
            Add(testRequests.BuildMessageWithMultiPartFormContent(), multiPartFormValue);
            Add(testRequests.BuildMessageWithByteArrayContent(), byteArrayValue);
            Add(testRequests.BuildMessageWithFormUrlEncodedContent(), formUrlEncodedValue);
        }
    }

    public class TestDataForGetContentHeaders : TheoryData<HttpRequestMessage, Dictionary<string, string>>
    {
        private Dictionary<string, string> noContentValue = null;
        private Dictionary<string, string> stringValue = new Dictionary<string, string>() { { "Content-Type", "application/json; charset=utf-8" } };
        private Dictionary<string, string> multiPartFormValue = new Dictionary<string, string>() { { "Content-Type", "multipart/form-data; boundary=\"MadeUpBoundary\"" } };
        private Dictionary<string, string> byteArrayValue = new Dictionary<string, string>();
        private Dictionary<string, string> formUrlEncodedValue = new Dictionary<string, string>() { { "Content-Type", "application/x-www-form-urlencoded" } }; 

        public TestDataForGetContentHeaders()
        {
            var testRequests = new BuildTestRequests();

            Add(testRequests.BuildMessageWithNoContent(), noContentValue);
            Add(testRequests.BuildMessageWithStringContent("Some made up string content"), stringValue);
            Add(testRequests.BuildMessageWithMultiPartFormContent(), multiPartFormValue);
            Add(testRequests.BuildMessageWithByteArrayContent(), byteArrayValue);
            Add(testRequests.BuildMessageWithFormUrlEncodedContent(), formUrlEncodedValue);
        }
    }

    public class TestDataForGetFormPostParamsFromContent : TheoryData<HttpRequestMessage, Dictionary<string, string>>
    {
        private Dictionary<string, string> noContentValue = null;
        private Dictionary<string, string> stringValue = null;
        private Dictionary<string, string> multiPartFormValue = null;
        private Dictionary<string, string> byteArrayValue = null;
        private Dictionary<string, string> formUrlEncodedValue = new Dictionary<string, string>() 
        { 
            { "Key1", "Value1" }, 
            { "Key2", "Value2" } 
        };

        public TestDataForGetFormPostParamsFromContent()
        {
            var testRequests = new BuildTestRequests();

            Add(testRequests.BuildMessageWithNoContent(), noContentValue);
            Add(testRequests.BuildMessageWithStringContent("Some made up string content"), stringValue);
            Add(testRequests.BuildMessageWithMultiPartFormContent(), multiPartFormValue);
            Add(testRequests.BuildMessageWithByteArrayContent(), byteArrayValue);
            Add(testRequests.BuildMessageWithFormUrlEncodedContent(), formUrlEncodedValue);
        }
    }

    public class BuildTestRequests
    {
        public HttpRequestMessage BuildMessageWithNoContent()
        {
            HttpRequestMessage messageWithNoContent = new HttpRequestMessage(HttpMethod.Get, "http://localhost");
            return messageWithNoContent;
        }

        public HttpRequestMessage BuildMessageWithStringContent(string stringValue)
        {
            HttpRequestMessage messageWithStringContent = new HttpRequestMessage(HttpMethod.Get, "http://localhost");
            messageWithStringContent.Content = new StringContent(stringValue, Encoding.UTF8, "application/json");
            return messageWithStringContent;
        }

        public HttpRequestMessage BuildMessageWithMultiPartFormContent()
        {
            HttpRequestMessage messageWithMultipartFormContent = new HttpRequestMessage(HttpMethod.Get, "http://localhost");

            // NOTE: Sionce we have not implemented this feature in the extension, we are
            // not really creating a valid content set. We just need enough to cause
            // the extension to fall into the right part of the switch statement.
            var multiPartFormContent = new MultipartFormDataContent("MadeUpBoundary");
            messageWithMultipartFormContent.Content = multiPartFormContent;
            return messageWithMultipartFormContent;
        }

        public HttpRequestMessage BuildMessageWithByteArrayContent()
        {
            HttpRequestMessage messageWithByteArrayContent = new HttpRequestMessage(HttpMethod.Get, "http://localhost");
            byte[] data = new byte[] { 49, 50, 51, 52, 53 };
            var byteContent = new ByteArrayContent(data);
            messageWithByteArrayContent.Content = byteContent;
            return messageWithByteArrayContent;
        }

        public HttpRequestMessage BuildMessageWithFormUrlEncodedContent()
        {
            HttpRequestMessage messageWithFormUrlEncodedContent = new HttpRequestMessage(HttpMethod.Get, "http://localhost");
            var formUrlEncodedContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("Key1", "Value1"),
                new KeyValuePair<string, string>("Key2", "Value2")
            });
            messageWithFormUrlEncodedContent.Content = formUrlEncodedContent;
            return messageWithFormUrlEncodedContent;
        }
    }
    #endregion
}
