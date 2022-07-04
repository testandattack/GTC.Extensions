#### [GTC.HttpUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')
### [GTC.HttpUtilities](GTC.HttpUtilities.md#GTC.HttpUtilities 'GTC.HttpUtilities').[HttpResponseCodeGroups](GTC.HttpUtilities.md#GTC.HttpUtilities.HttpResponseCodeGroups 'GTC.HttpUtilities.HttpResponseCodeGroups')

## HttpResponseCodeGroups.Four_xx() Method

A List containing all of the 4xx (or Client Error) response codes.

```csharp
public static System.Collections.Generic.List<int> Four_xx();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

### Remarks
- Bad_Request = 400  
- Unauthorized = 401  
- Payment_Required = 402  
- Forbidden = 403  
- Not_Found = 404  
- Method_Not_Allowed = 405  
- Not_Acceptable = 406  
- Proxy_Authentication_Required = 407  
- Request_Timeout = 408  
- Conflict = 409  
- Gone = 410  
- Length_Required = 411  
- Precondition_Failed = 412  
- Payload_Too_Large = 413  
- URI_Too_Long = 414  
- Unsupported_Media_Type = 415  
- Range_Not_Satisfiable = 416  
- Expectation_Failed = 417  
- Im_A_Teapot = 418 (RFC 2324, RFC 7168 - April Fools or Easter Egg response)  
- Misdirected_Request = 421  
- Unprocessable_Entity = 422  
- Locked = 423  
- Failed_Dependency = 424  
- Too_Early = 425  
- Upgrade_Required = 426  
- Precondition_Required = 428  
- Too_Many_Requests = 429  
- Request_Header_Fields_Too_Large = 431  
- Unavailable_For_Legal_Reasons = 451