#### [GTC.Utilities](GTC.Utilities.md 'GTC.Utilities')
### [GTC.Utilities](GTC.Utilities.md#GTC.Utilities 'GTC.Utilities').[Property](GTC.Utilities.md#GTC.Utilities.Property 'GTC.Utilities.Property')

## Property.ShouldSerializeValue() Method

Implements the Newtonsoft JSON conditional serializer setting to   
ensure that any value that shpould be obfuscated will not be  
serialized by NewtonSoft. See [
            this article](https://www.newtonsoft.com/json/help/html/ConditionalProperties.htm 'https://www.newtonsoft.com/json/help/html/ConditionalProperties.htm') for more information.

```csharp
public bool ShouldSerializeValue();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')