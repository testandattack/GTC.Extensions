#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions').[MathExtensions](MathExtensions.md 'GTC.Extensions.MathExtensions')

## MathExtensions.PercentileValue(this IEnumerable<double>, double, int) Method

Returns the value from the list that is the largest value  
within the subset of percentile values sorted by  
smallest to largest.

```csharp
public static System.Nullable<int> PercentileValue(this System.Collections.Generic.IEnumerable<double> values, double percentile, int minNumberOfEntries=10);
```
#### Parameters

<a name='GTC.Extensions.MathExtensions.PercentileValue(thisSystem.Collections.Generic.IEnumerable_double_,double,int).values'></a>

`values` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') list to which the method is exposed.

<a name='GTC.Extensions.MathExtensions.PercentileValue(thisSystem.Collections.Generic.IEnumerable_double_,double,int).percentile'></a>

`percentile` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') numeric between 0 and 1.

<a name='GTC.Extensions.MathExtensions.PercentileValue(thisSystem.Collections.Generic.IEnumerable_double_,double,int).minNumberOfEntries'></a>

`minNumberOfEntries` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

### Remarks
To get the value   
1. The list is sorted from smallest to largest.  
2. The index for the value is calculated by multiplying the list's count by the [percentile](MathExtensions.PercentileValue(thisIEnumerable_double_,double,int).md#GTC.Extensions.MathExtensions.PercentileValue(thisSystem.Collections.Generic.IEnumerable_double_,double,int).percentile 'GTC.Extensions.MathExtensions.PercentileValue(this System.Collections.Generic.IEnumerable<double>, double, int).percentile').  
3. The value at the calculated index is returned.`Math.Floor(values.Count() * percentile);`  
calculated and the and the value just before that one is returned.