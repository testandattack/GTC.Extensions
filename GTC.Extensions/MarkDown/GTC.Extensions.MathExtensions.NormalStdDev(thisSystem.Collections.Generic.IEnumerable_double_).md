### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[MathExtensions](GTC.Extensions.MathExtensions.md 'GTC.Extensions.MathExtensions')

## MathExtensions.NormalStdDev(this IEnumerable<double>) Method

NORMAL Std Dev  
https://stackoverflow.com/questions/2253874/standard-deviation-in-linq    
Divide by n instead of divide by n-1

```csharp
public static double NormalStdDev(this System.Collections.Generic.IEnumerable<double> values);
```
#### Parameters

<a name='GTC.Extensions.MathExtensions.NormalStdDev(thisSystem.Collections.Generic.IEnumerable_double_).values'></a>

`values` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') list to which the method is exposed.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
A [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') that contains the standard deviation.

### Remarks
If a data distribution is approximately normal then about 68 percent of the data values are   
within one standard deviation of the mean (mathematically, μ ± σ, where μ is the arithmetic mean),   
about 95 percent are within two standard deviations (μ ± 2σ), and about 99.7 percent lie within   
three standard deviations (μ ± 3σ). This is known as the 68-95-99.7 rule, or the empirical rule.  
See this link for more information: http://warrenseen.com/blog/2006/03/13/how-to-calculate-standard-deviation/