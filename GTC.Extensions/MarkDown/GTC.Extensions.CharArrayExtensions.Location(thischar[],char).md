### [GTC.Extensions](GTC.Extensions.md 'GTC.Extensions').[CharArrayExtensions](GTC.Extensions.CharArrayExtensions.md 'GTC.Extensions.CharArrayExtensions')

## CharArrayExtensions.Location(this char[], char) Method

Searches the array for the specified character, getting the index of the first instance of the character.

```csharp
public static int Location(this char[] array, char charToLookFor);
```
#### Parameters

<a name='GTC.Extensions.CharArrayExtensions.Location(thischar[],char).array'></a>

`array` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The character array to which the method is exposed.

<a name='GTC.Extensions.CharArrayExtensions.Location(thischar[],char).charToLookFor'></a>

`charToLookFor` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The character to locate in the array.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the zero-based index of the character's location in the array, or -1 if the character is not found.