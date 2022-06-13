#### [GTC.Utilities](GTC.Utilities.md 'GTC.Utilities')
### [GTC.Utilities](GTC.Utilities.md#GTC.Utilities 'GTC.Utilities').[Property](GTC.Utilities.md#GTC.Utilities.Property 'GTC.Utilities.Property')

## Property.Value Property

The value stored in the property.

```csharp
public object Value { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

### Remarks
This item is stored in its native form, but if the [IsObfuscated](Property.IsObfuscated.md 'GTC.Utilities.Property.IsObfuscated') value  
is set to "True", then retrieving this property will only return a string  
of asterisks: "********". To retrieve the actual value, you must call the  
[GetPwdValue()](Property.GetPwdValue().md 'GTC.Utilities.Property.GetPwdValue()') method.