#### [GTC.Utilities](GTC.Utilities.md 'GTC.Utilities')
### [GTC.Utilities](GTC.Utilities.md#GTC.Utilities 'GTC.Utilities').[Property](GTC.Utilities.md#GTC.Utilities.Property 'GTC.Utilities.Property')

## Property.IsObfuscated Property

A boolean indicating whether the value should be treated as sensitive, or  
can be treated as a normal property value.

```csharp
public bool IsObfuscated { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
If this is "True", then any call directly to the [Value](Property.Value.md 'GTC.Utilities.Property.Value') will  
result in a string of asterisks being returned. Further, there is  
a method called [ShouldSerializeValue()](Property.ShouldSerializeValue().md 'GTC.Utilities.Property.ShouldSerializeValue()') that is a  
NewtonSoft JSON event hook that tells the serilizer whether the  
value should be serialized for transmission or saving.