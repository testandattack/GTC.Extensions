#### [GTC.Utilities](GTC.Utilities.md 'GTC.Utilities')

## GTC.Utilities Assembly
### Namespaces

<a name='GTC.Utilities'></a>

## GTC.Utilities Namespace
### Classes

<a name='GTC.Utilities.BaseCollection_T_'></a>

## BaseCollection<T> Class

Provides an abstract class that extends the `Collection{T}` built in class

```csharp
public abstract class BaseCollection<T> : System.Collections.ObjectModel.Collection<T>
```
#### Type parameters

<a name='GTC.Utilities.BaseCollection_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Collections.ObjectModel.Collection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.Collection-1 'System.Collections.ObjectModel.Collection`1')[T](GTC.Utilities.md#GTC.Utilities.BaseCollection_T_.T 'GTC.Utilities.BaseCollection<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.Collection-1 'System.Collections.ObjectModel.Collection`1') &#129106; BaseCollection<T>

| Constructors | |
| :--- | :--- |
| [BaseCollection()](BaseCollection_T_.BaseCollection().md 'GTC.Utilities.BaseCollection<T>.BaseCollection()') | Default Constructor |

| Methods | |
| :--- | :--- |
| [AddRange(IEnumerable&lt;T&gt;)](BaseCollection_T_.AddRange(IEnumerable_T_).md 'GTC.Utilities.BaseCollection<T>.AddRange(System.Collections.Generic.IEnumerable<T>)') | Adds a collection of items to this collection |

<a name='GTC.Utilities.Property'></a>

## Property Class

Provides a class for holding a C# property that can be obfuscated as needed,   
to prevent storing sensitive data, such as passwords.

```csharp
public class Property :
System.ICloneable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Property

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable')

| Constructors | |
| :--- | :--- |
| [Property()](Property.Property().md 'GTC.Utilities.Property.Property()') | Creates a new instance of this class |
| [Property(string, object)](Property.Property(string,object).md 'GTC.Utilities.Property.Property(string, object)') | Creates a new instance of this class |
| [Property(string, string)](Property.Property(string,string).md 'GTC.Utilities.Property.Property(string, string)') | Creates a new instance of this class |
| [Property(string, string, bool)](Property.Property(string,string,bool).md 'GTC.Utilities.Property.Property(string, string, bool)') | Creates a new instance of this class |
| [Property(string, string, Type)](Property.Property(string,string,Type).md 'GTC.Utilities.Property.Property(string, string, System.Type)') | Creates a new instance of this class |
| [Property(string, string, Type, bool)](Property.Property(string,string,Type,bool).md 'GTC.Utilities.Property.Property(string, string, System.Type, bool)') | Creates a new instance of this class |

| Properties | |
| :--- | :--- |
| [IsObfuscated](Property.IsObfuscated.md 'GTC.Utilities.Property.IsObfuscated') | A boolean indicating whether the value should be treated as sensitive, or<br/>can be treated as a normal property value. |
| [Name](Property.Name.md 'GTC.Utilities.Property.Name') | The name of the property |
| [Type](Property.Type.md 'GTC.Utilities.Property.Type') | The Type of the stored property value. |
| [Value](Property.Value.md 'GTC.Utilities.Property.Value') | The value stored in the property. |

| Methods | |
| :--- | :--- |
| [Clone()](Property.Clone().md 'GTC.Utilities.Property.Clone()') | Creates a new instance of the class, containing all of the same values. |
| [GetPwdValue()](Property.GetPwdValue().md 'GTC.Utilities.Property.GetPwdValue()') | This method retrieves the actual value of an obfuscated string stored<br/>in the [Value](Property.Value.md 'GTC.Utilities.Property.Value') property. If the property is not obfuscated,<br/>this method returns an empty string. |
| [ShouldSerializeValue()](Property.ShouldSerializeValue().md 'GTC.Utilities.Property.ShouldSerializeValue()') | Implements the Newtonsoft JSON conditional serializer setting to <br/>ensure that any value that shpould be obfuscated will not be<br/>serialized by NewtonSoft. See [
            this article](https://www.newtonsoft.com/json/help/html/ConditionalProperties.htm 'https://www.newtonsoft.com/json/help/html/ConditionalProperties.htm') for more information. |
