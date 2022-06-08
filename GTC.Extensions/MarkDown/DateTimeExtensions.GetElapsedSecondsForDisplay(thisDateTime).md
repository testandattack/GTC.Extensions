#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[DateTimeExtensions](DateTimeExtensions.md 'GTC.Extensions.DateTimeExtensions')

## DateTimeExtensions.GetElapsedSecondsForDisplay(this DateTime) Method

Calculates the number of seconds between the object's creation time and [System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'), formatting it as  
a string using the [https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString 'https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString')  
string formatter.

```csharp
public static string GetElapsedSecondsForDisplay(this System.DateTime dateTime);
```
#### Parameters

<a name='GTC.Extensions.DateTimeExtensions.GetElapsedSecondsForDisplay(thisSystem.DateTime).dateTime'></a>

`dateTime` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime') to which this method is exposed.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
a string.