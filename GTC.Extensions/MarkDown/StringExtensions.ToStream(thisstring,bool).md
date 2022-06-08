#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[StringExtensions](StringExtensions.md 'GTC.Extensions.StringExtensions')

## StringExtensions.ToStream(this string, bool) Method

Converts a string to a Memory Stream.

```csharp
public static System.IO.MemoryStream ToStream(this string source, bool leaveStreamOpen);
```
#### Parameters

<a name='GTC.Extensions.StringExtensions.ToStream(thisstring,bool).source'></a>

`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `string` to which this method is exposed.

<a name='GTC.Extensions.StringExtensions.ToStream(thisstring,bool).leaveStreamOpen'></a>

`leaveStreamOpen` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If `True`, the StreamWriter is left open and must be closed by the calling method.

#### Returns
[System.IO.MemoryStream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.MemoryStream 'System.IO.MemoryStream')