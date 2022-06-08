#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions')

## DateTimeExtensions Class

A set of extension methods for [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime') objects.

```csharp
public static class DateTimeExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DateTimeExtensions

| Methods | |
| :--- | :--- |
| [DaysSince2000(this DateTime)](DateTimeExtensions.DaysSince2000(thisDateTime).md 'GTC.Extensions.DateTimeExtensions.DaysSince2000(this System.DateTime)') | Calculates the number of days since January 1, 2000. |
| [GetElapsedSeconds(this DateTime, bool)](DateTimeExtensions.GetElapsedSeconds(thisDateTime,bool).md 'GTC.Extensions.DateTimeExtensions.GetElapsedSeconds(this System.DateTime, bool)') | Calculates the number of seconds between the object's creation time and [System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'). |
| [GetElapsedSecondsForDisplay(this DateTime)](DateTimeExtensions.GetElapsedSecondsForDisplay(thisDateTime).md 'GTC.Extensions.DateTimeExtensions.GetElapsedSecondsForDisplay(this System.DateTime)') | Calculates the number of seconds between the object's creation time and [System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow'), formatting it as<br/>a string using the [https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString 'https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString')<br/>string formatter. |
