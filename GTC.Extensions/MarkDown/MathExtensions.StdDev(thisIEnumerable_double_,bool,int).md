#### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions')
### [GTC.Extensions](GTC.Extensions.md#GTC.Extensions 'GTC.Extensions').[MathExtensions](GTC.Extensions.md#GTC.Extensions.MathExtensions 'GTC.Extensions.MathExtensions')

## MathExtensions.StdDev(this IEnumerable<double>, bool, int) Method

Allows you to call either Sample based or Normal Std Dev methods that are based on this article:  
https://stackoverflow.com/questions/2253874/standard-deviation-in-linq

```csharp
public static System.Nullable<double> StdDev(this System.Collections.Generic.IEnumerable<double> values, bool useNormalStdDev, int minNumberOfEntries=10);
```
#### Parameters

<a name='GTC.Extensions.MathExtensions.StdDev(thisSystem.Collections.Generic.IEnumerable_double_,bool,int).values'></a>

`values` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') list to which the method is exposed.

<a name='GTC.Extensions.MathExtensions.StdDev(thisSystem.Collections.Generic.IEnumerable_double_,bool,int).useNormalStdDev'></a>

`useNormalStdDev` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='GTC.Extensions.MathExtensions.StdDev(thisSystem.Collections.Generic.IEnumerable_double_,bool,int).minNumberOfEntries'></a>

`minNumberOfEntries` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
A [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') that contains the standard deviation.