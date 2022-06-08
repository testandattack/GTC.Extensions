#### [GTC.Extensions](GTCExtensions.md 'GTC Extensions')
### [GTC.Extensions](GTCExtensions.md#GTC.Extensions 'GTC.Extensions')

## MathExtensions Class

Extension class for [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1') objects that exposes Statistical mathematics methods.

```csharp
public static class MathExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MathExtensions

| Methods | |
| :--- | :--- |
| [NormalStdDev(this IEnumerable&lt;double&gt;)](MathExtensions.NormalStdDev(thisIEnumerable_double_).md 'GTC.Extensions.MathExtensions.NormalStdDev(this System.Collections.Generic.IEnumerable<double>)') | NORMAL Std Dev<br/>https://stackoverflow.com/questions/2253874/standard-deviation-in-linq  <br/>Divide by n instead of divide by n-1 |
| [PercentileValue(this IEnumerable&lt;double&gt;, double, int)](MathExtensions.PercentileValue(thisIEnumerable_double_,double,int).md 'GTC.Extensions.MathExtensions.PercentileValue(this System.Collections.Generic.IEnumerable<double>, double, int)') | Returns the value from the list that is the largest value<br/>within the subset of percentile values sorted by<br/>smallest to largest. |
| [SampleStdDev(this IEnumerable&lt;double&gt;)](MathExtensions.SampleStdDev(thisIEnumerable_double_).md 'GTC.Extensions.MathExtensions.SampleStdDev(this System.Collections.Generic.IEnumerable<double>)') | SAMPLE Std Dev<br/>https://stackoverflow.com/questions/2253874/standard-deviation-in-linq |
| [StdDev(this IEnumerable&lt;double&gt;, bool, int)](MathExtensions.StdDev(thisIEnumerable_double_,bool,int).md 'GTC.Extensions.MathExtensions.StdDev(this System.Collections.Generic.IEnumerable<double>, bool, int)') | Allows you to call either Sample based or Normal Std Dev methods that are based on this article:<br/>https://stackoverflow.com/questions/2253874/standard-deviation-in-linq |
