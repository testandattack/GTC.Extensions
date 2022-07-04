#### [GTC.HttpUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')
### [GTC.HttpUtilities](GTC.HttpUtilities.md#GTC.HttpUtilities 'GTC.HttpUtilities').[HttpResponseCodeGroups](GTC.HttpUtilities.md#GTC.HttpUtilities.HttpResponseCodeGroups 'GTC.HttpUtilities.HttpResponseCodeGroups')

## HttpResponseCodeGroups.Five_xx() Method

A List containing all of the 5xx (or Server Error) response codes.

```csharp
public static System.Collections.Generic.List<int> Five_xx();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

### Remarks
- Internal_Server_Error = 500  
- Not_Implemented = 501  
- Bad_Gateway = 502  
- Service_Unavailable = 503  
- Gateway_Timeout = 504  
- HTTP_Version_Not_Supported = 505  
- Variant_Also_Negotiates = 506  
- Insufficient_Storage = 507  
- Loop_Detected = 508  
- Not_Extended = 510  
- Network_Authentication_Required = 511