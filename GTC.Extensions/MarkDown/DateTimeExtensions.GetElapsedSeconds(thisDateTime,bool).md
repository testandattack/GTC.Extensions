#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[DateTimeExtensions](GTC.Extensions.md#GTC.Extensions.DateTimeExtensions 'GTC.Extensions.DateTimeExtensions')

## DateTimeExtensions.GetElapsedSeconds(this DateTime, bool) Method

Calculates the number of seconds between the object's creation time and [System.DateTime.UtcNow](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.UtcNow 'System.DateTime.UtcNow').

```csharp
public static double GetElapsedSeconds(this System.DateTime dateTime, bool useMathFloor=true);
```
#### Parameters

<a name='GTC.Extensions.DateTimeExtensions.GetElapsedSeconds(thisSystem.DateTime,bool).dateTime'></a>

`dateTime` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime') to which this method is exposed.

<a name='GTC.Extensions.DateTimeExtensions.GetElapsedSeconds(thisSystem.DateTime,bool).useMathFloor'></a>

`useMathFloor` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, the returned value is rounded DOWN to the nearest integer number, if False, the   
           returned value is rounded UP to the next nearest integer value.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
a double.