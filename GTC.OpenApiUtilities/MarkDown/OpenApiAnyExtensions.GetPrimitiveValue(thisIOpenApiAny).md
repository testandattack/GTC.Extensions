#### [GTC.OpenApiUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')
### [GTC.OpenApiUtilities](GTC.HttpUtilities.md#GTC.OpenApiUtilities 'GTC.OpenApiUtilities').[OpenApiAnyExtensions](GTC.HttpUtilities.md#GTC.OpenApiUtilities.OpenApiAnyExtensions 'GTC.OpenApiUtilities.OpenApiAnyExtensions')

## OpenApiAnyExtensions.GetPrimitiveValue(this IOpenApiAny) Method

Reads the passed in [Microsoft.OpenApi.Any.IOpenApiAny](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.OpenApi.Any.IOpenApiAny 'Microsoft.OpenApi.Any.IOpenApiAny') object and returns the value  
it contains in a predefined format

```csharp
public static string GetPrimitiveValue(this Microsoft.OpenApi.Any.IOpenApiAny source);
```
#### Parameters

<a name='GTC.OpenApiUtilities.OpenApiAnyExtensions.GetPrimitiveValue(thisMicrosoft.OpenApi.Any.IOpenApiAny).source'></a>

`source` [Microsoft.OpenApi.Any.IOpenApiAny](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.OpenApi.Any.IOpenApiAny 'Microsoft.OpenApi.Any.IOpenApiAny')

The `IOpenApiAny` to which this method is exposed.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
a string representation of the contained primitive value.