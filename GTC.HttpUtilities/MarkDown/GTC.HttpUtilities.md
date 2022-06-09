#### [GTC.HttpUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')

## GTC.HttpUtilities Assembly
### Namespaces

<a name='GTC.HttpUtilities'></a>

## GTC.HttpUtilities Namespace
### Classes

<a name='GTC.HttpUtilities.HttpRequestHelpers'></a>

## HttpRequestHelpers Class

A class of methods designed to simplify the calling of HTTP Requests, and validation of  
HTTP Responses.

```csharp
public static class HttpRequestHelpers
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HttpRequestHelpers

| Methods | |
| :--- | :--- |
| [GetMethodTypeFromString(string)](HttpRequestHelpers.GetMethodTypeFromString(string).md 'GTC.HttpUtilities.HttpRequestHelpers.GetMethodTypeFromString(string)') | This helper is handy when trying to set the method type in a request being<br/>programatically built if you have the string equivalent, like the value<br/>in an Http Archive file. |

<a name='GTC.HttpUtilities.HttpRequestMessageExtensions'></a>

## HttpRequestMessageExtensions Class

A set of extension methods for use with the [System.Net.Http.HttpRequestMessage](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage') object.

```csharp
public static class HttpRequestMessageExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HttpRequestMessageExtensions

| Methods | |
| :--- | :--- |
| [GetContentHeaders(this HttpContent)](HttpRequestMessageExtensions.GetContentHeaders(thisHttpContent).md 'GTC.HttpUtilities.HttpRequestMessageExtensions.GetContentHeaders(this System.Net.Http.HttpContent)') | Retrieves the headers associated with a [System.Net.Http.HttpContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpContent 'System.Net.Http.HttpContent') object. |
| [GetContentHeaders(this HttpRequestMessage)](HttpRequestMessageExtensions.GetContentHeaders(thisHttpRequestMessage).md 'GTC.HttpUtilities.HttpRequestMessageExtensions.GetContentHeaders(this System.Net.Http.HttpRequestMessage)') | Retrieves the headers associated with an HttpRequestMessage's [System.Net.Http.HttpContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpContent 'System.Net.Http.HttpContent'). |
| [GetFormPostParamsFromContent(this FormUrlEncodedContent)](HttpRequestMessageExtensions.GetFormPostParamsFromContent(thisFormUrlEncodedContent).md 'GTC.HttpUtilities.HttpRequestMessageExtensions.GetFormPostParamsFromContent(this System.Net.Http.FormUrlEncodedContent)') | If the request has a [System.Net.Http.FormUrlEncodedContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.FormUrlEncodedContent 'System.Net.Http.FormUrlEncodedContent') body, this method will read it and<br/>return a dictionary of Key-Value-Pairs representing all of the items in the body. |
| [GetFormPostParamsFromContent(this HttpContent)](HttpRequestMessageExtensions.GetFormPostParamsFromContent(thisHttpContent).md 'GTC.HttpUtilities.HttpRequestMessageExtensions.GetFormPostParamsFromContent(this System.Net.Http.HttpContent)') | If the request has a [System.Net.Http.FormUrlEncodedContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.FormUrlEncodedContent 'System.Net.Http.FormUrlEncodedContent') body, this method will read it and<br/>return a dictionary of Key-Value-Pairs representing all of the items in the body. |
| [GetFormPostParamsFromContent(this HttpRequestMessage)](HttpRequestMessageExtensions.GetFormPostParamsFromContent(thisHttpRequestMessage).md 'GTC.HttpUtilities.HttpRequestMessageExtensions.GetFormPostParamsFromContent(this System.Net.Http.HttpRequestMessage)') | If the request has a [System.Net.Http.FormUrlEncodedContent](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.FormUrlEncodedContent 'System.Net.Http.FormUrlEncodedContent') body, this method will read it and<br/>return a dictionary of Key-Value-Pairs representing all of the items in the body. |
| [GetRequestContentBody(this HttpRequestMessage)](HttpRequestMessageExtensions.GetRequestContentBody(thisHttpRequestMessage).md 'GTC.HttpUtilities.HttpRequestMessageExtensions.GetRequestContentBody(this System.Net.Http.HttpRequestMessage)') | Allows you to synchronously retrieve the content body from an HttpRequestMessage as a string. |

<a name='GTC.HttpUtilities.HttpResponseCodeGroups'></a>

## HttpResponseCodeGroups Class

This class defines lists of Http Status code, broken down by the group that  
each code falls into.   
<remarks>  
The categories are as follows:  
<list type="bullet"><item><c>1xx</c>: Informational</item><item><c>2xx</c>: Success</item><item><c>3xx</c>: Redirection</item><item><c>4xx</c>: Client Error</item><item><c>5xx</c>: Server Error</item></list></remarks>

```csharp
public static class HttpResponseCodeGroups
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HttpResponseCodeGroups

| Methods | |
| :--- | :--- |
| [Five_xx()](HttpResponseCodeGroups.Five_xx().md 'GTC.HttpUtilities.HttpResponseCodeGroups.Five_xx()') | A List containing all of the 5xx (or Server Error) response codes. |
| [Four_xx()](HttpResponseCodeGroups.Four_xx().md 'GTC.HttpUtilities.HttpResponseCodeGroups.Four_xx()') | A List containing all of the 4xx (or Client Error) response codes. |
| [GetGroupCodes(int)](HttpResponseCodeGroups.GetGroupCodes(int).md 'GTC.HttpUtilities.HttpResponseCodeGroups.GetGroupCodes(int)') | returns the list of codes associated with the group passed in |
| [IsValidResponseCode(int)](HttpResponseCodeGroups.IsValidResponseCode(int).md 'GTC.HttpUtilities.HttpResponseCodeGroups.IsValidResponseCode(int)') | Checks a given integer value to see if that value represents any HttpStatus Code |
| [One_xx()](HttpResponseCodeGroups.One_xx().md 'GTC.HttpUtilities.HttpResponseCodeGroups.One_xx()') | A List containing all of the 1xx (or Informational) response codes. |
| [Three_xx()](HttpResponseCodeGroups.Three_xx().md 'GTC.HttpUtilities.HttpResponseCodeGroups.Three_xx()') | A List containing all of the 3xx (or Redirection) response codes. |
| [Two_xx()](HttpResponseCodeGroups.Two_xx().md 'GTC.HttpUtilities.HttpResponseCodeGroups.Two_xx()') | A List containing all of the 2xx (or Success) response codes. |
### Enums

<a name='GTC.HttpUtilities.StatusCodes'></a>

## StatusCodes Enum

This enum defines every recognized status code available for reporting  
the response status of an HTTP web request. There are more codes listed   
[here](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes 'https://en.wikipedia.org/wiki/List_of_HTTP_status_codes'), but  
they are listed as unofficial.

```csharp
public enum StatusCodes
```