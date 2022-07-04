#### [GTC.HttpUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')
### [GTC.HttpUtilities](GTC.HttpUtilities.md#GTC.HttpUtilities 'GTC.HttpUtilities').[HttpRequestHelpers](GTC.HttpUtilities.md#GTC.HttpUtilities.HttpRequestHelpers 'GTC.HttpUtilities.HttpRequestHelpers')

## HttpRequestHelpers.GetMethodTypeFromString(string) Method

This helper is handy when trying to set the method type in a request being  
programatically built if you have the string equivalent, like the value  
in an Http Archive file.

```csharp
public static System.Net.Http.HttpMethod GetMethodTypeFromString(string methodString);
```
#### Parameters

<a name='GTC.HttpUtilities.HttpRequestHelpers.GetMethodTypeFromString(string).methodString'></a>

`methodString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

one of the allowed HTTP method types, such as GET, DELETE, etc.  
            Note: The value is NOT case sensitive.

#### Returns
[System.Net.Http.HttpMethod](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod')  
returns the equivalent [System.Net.Http.HttpMethod](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') value.