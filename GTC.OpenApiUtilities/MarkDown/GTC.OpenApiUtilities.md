#### [GTC.OpenApiUtilities](GTC.HttpUtilities.md 'GTC.HttpUtilities')

## GTC.OpenApiUtilities Assembly
### Namespaces

<a name='GTC.OpenApiUtilities'></a>

## GTC.OpenApiUtilities Namespace
### Classes

<a name='GTC.OpenApiUtilities.OpenApiAnyExtensions'></a>

## OpenApiAnyExtensions Class

A set of extension methods to work on the Microsoft.OpenApi.Models.OpenApiAny class

```csharp
public static class OpenApiAnyExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; OpenApiAnyExtensions

| Methods | |
| :--- | :--- |
| [GetPrimitiveValue(this IOpenApiAny)](OpenApiAnyExtensions.GetPrimitiveValue(thisIOpenApiAny).md 'GTC.OpenApiUtilities.OpenApiAnyExtensions.GetPrimitiveValue(this Microsoft.OpenApi.Any.IOpenApiAny)') | Reads the passed in [Microsoft.OpenApi.Any.IOpenApiAny](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.OpenApi.Any.IOpenApiAny 'Microsoft.OpenApi.Any.IOpenApiAny') object and returns the value<br/>it contains in a predefined format |

<a name='GTC.OpenApiUtilities.OpenApiArrayExtensions'></a>

## OpenApiArrayExtensions Class

A set of extension methods to work on the Microsoft.OpenApi.Models.OpenApiArray class

```csharp
public static class OpenApiArrayExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; OpenApiArrayExtensions

| Methods | |
| :--- | :--- |
| [ToString(this OpenApiArray)](OpenApiArrayExtensions.ToString(thisOpenApiArray).md 'GTC.OpenApiUtilities.OpenApiArrayExtensions.ToString(this Microsoft.OpenApi.Any.OpenApiArray)') | walks an array of items, retrieving the value from the [GetPrimitiveValue(this IOpenApiAny)](OpenApiAnyExtensions.GetPrimitiveValue(thisIOpenApiAny).md 'GTC.OpenApiUtilities.OpenApiAnyExtensions.GetPrimitiveValue(this Microsoft.OpenApi.Any.IOpenApiAny)') method |

<a name='GTC.OpenApiUtilities.OpenApiSchemaExtensions'></a>

## OpenApiSchemaExtensions Class

A set of extension methods to work on the Microsoft.OpenApi.Models.OpenApiSchema class

```csharp
public static class OpenApiSchemaExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; OpenApiSchemaExtensions

| Methods | |
| :--- | :--- |
| [GetSchemaItemType(this OpenApiSchema, string, int)](OpenApiSchemaExtensions.GetSchemaItemType(thisOpenApiSchema,string,int).md 'GTC.OpenApiUtilities.OpenApiSchemaExtensions.GetSchemaItemType(this Microsoft.OpenApi.Models.OpenApiSchema, string, int)') | |

<a name='GTC.OpenApiUtilities.ParseTokens'></a>

## ParseTokens Class

This class contains constant string values that are used for parsing OAS documents.

```csharp
public class ParseTokens
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ParseTokens

| Fields | |
| :--- | :--- |
| [OAS_FormDataContentType](ParseTokens.OAS_FormDataContentType.md 'GTC.OpenApiUtilities.ParseTokens.OAS_FormDataContentType') | the string to search for in the content-type that indicates the response is a binary or form data object |
| [OAS_JsonContentType](ParseTokens.OAS_JsonContentType.md 'GTC.OpenApiUtilities.ParseTokens.OAS_JsonContentType') | the string to search for in the content-type that indicates the response is a JSON object |
| [OAS_NoContentFound](ParseTokens.OAS_NoContentFound.md 'GTC.OpenApiUtilities.ParseTokens.OAS_NoContentFound') | the string to search for in the content-type that indicates there was no response object. |
| [PARAM_MissingInfo](ParseTokens.PARAM_MissingInfo.md 'GTC.OpenApiUtilities.ParseTokens.PARAM_MissingInfo') | this string represents an item in the OAS schema that has missing info. |
| [PARAM_MissingTypeField](ParseTokens.PARAM_MissingTypeField.md 'GTC.OpenApiUtilities.ParseTokens.PARAM_MissingTypeField') | this string represents an item in the OAS schema that has a missing field type. |
### Enums

<a name='GTC.OpenApiUtilities.ObjectTypeEnum'></a>

## ObjectTypeEnum Enum

Enumerates the types of data objects that can be found in  
an [Microsoft.OpenApi.Models.OpenApiSchema](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.OpenApi.Models.OpenApiSchema 'Microsoft.OpenApi.Models.OpenApiSchema') object.

```csharp
public enum ObjectTypeEnum
```
### Fields

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.BinaryString'></a>

`BinaryString` 4

A binary string (usually a downloadable file, etc)

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.Boolean'></a>

`Boolean` 7

A [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.Byte'></a>

`Byte` 12

A [Byte](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Byte 'GTC.OpenApiUtilities.ObjectTypeEnum.Byte')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.Date'></a>

`Date` 10

The Date portion of a [DateTime](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.DateTime 'GTC.OpenApiUtilities.ObjectTypeEnum.DateTime')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.DateTime'></a>

`DateTime` 9

A [DateTime](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.DateTime 'GTC.OpenApiUtilities.ObjectTypeEnum.DateTime')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.Double'></a>

`Double` 8

A [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.FailedToParse'></a>

`FailedToParse` 33

The ApiSet parser was not able to determine the response object type.

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.Integer'></a>

`Integer` 6

A plain old [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List'></a>

`List` 0

A [List](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.List 'GTC.OpenApiUtilities.ObjectTypeEnum.List') of items, referred to as arrays in the openApi spec

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_BinaryString'></a>

`List_BinaryString` 14

A list of [BinaryString](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.BinaryString 'GTC.OpenApiUtilities.ObjectTypeEnum.BinaryString') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_Boolean'></a>

`List_Boolean` 17

A list of[Boolean](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Boolean 'GTC.OpenApiUtilities.ObjectTypeEnum.Boolean') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_Byte'></a>

`List_Byte` 22

A list of [Byte](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Byte 'GTC.OpenApiUtilities.ObjectTypeEnum.Byte')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_Date'></a>

`List_Date` 20

A list of The Date portion of a [DateTime](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.DateTime 'GTC.OpenApiUtilities.ObjectTypeEnum.DateTime')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_DateTime'></a>

`List_DateTime` 19

A list of [DateTime](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.DateTime 'GTC.OpenApiUtilities.ObjectTypeEnum.DateTime')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_Double'></a>

`List_Double` 18

A list of [Double](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Double 'GTC.OpenApiUtilities.ObjectTypeEnum.Double') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_Integer'></a>

`List_Integer` 16

A list of [Integer](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Integer 'GTC.OpenApiUtilities.ObjectTypeEnum.Integer') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List'></a>

`List_List` 1

A list of [List](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.List 'GTC.OpenApiUtilities.ObjectTypeEnum.List') of items, referred to as arrays in the openApi spec

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_BinaryString'></a>

`List_List_BinaryString` 24

A list of lists of [BinaryString](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.BinaryString 'GTC.OpenApiUtilities.ObjectTypeEnum.BinaryString') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_Boolean'></a>

`List_List_Boolean` 27

A list of lists of [Boolean](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Boolean 'GTC.OpenApiUtilities.ObjectTypeEnum.Boolean') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_Byte'></a>

`List_List_Byte` 32

A list of lists of [Byte](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Byte 'GTC.OpenApiUtilities.ObjectTypeEnum.Byte')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_Date'></a>

`List_List_Date` 30

A list of lists of The Date portion of a [DateTime](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.DateTime 'GTC.OpenApiUtilities.ObjectTypeEnum.DateTime')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_DateTime'></a>

`List_List_DateTime` 29

A list of lists of [DateTime](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.DateTime 'GTC.OpenApiUtilities.ObjectTypeEnum.DateTime')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_Double'></a>

`List_List_Double` 28

A list of lists of [Double](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Double 'GTC.OpenApiUtilities.ObjectTypeEnum.Double') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_Integer'></a>

`List_List_Integer` 26

A list of lists of [Integer](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Integer 'GTC.OpenApiUtilities.ObjectTypeEnum.Integer') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_Long'></a>

`List_List_Long` 31

A list of lists of [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_Object'></a>

`List_List_Object` 23

A list of lists of [Object](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Object 'GTC.OpenApiUtilities.ObjectTypeEnum.Object') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_List_String'></a>

`List_List_String` 25

A list of lists of [String](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.String 'GTC.OpenApiUtilities.ObjectTypeEnum.String') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_Long'></a>

`List_Long` 21

A list of [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_Objecgt'></a>

`List_Objecgt` 13

A list of [Object](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.Object 'GTC.OpenApiUtilities.ObjectTypeEnum.Object') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.List_String'></a>

`List_String` 15

A list of [String](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.String 'GTC.OpenApiUtilities.ObjectTypeEnum.String') items

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.Long'></a>

`Long` 11

An [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.none'></a>

`none` 2

The endpoint does not return any data.

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.Object'></a>

`Object` 3

A class-based response object

<a name='GTC.OpenApiUtilities.ObjectTypeEnum.String'></a>

`String` 5

A plain old [String](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ObjectTypeEnum.String 'GTC.OpenApiUtilities.ObjectTypeEnum.String').

<a name='GTC.OpenApiUtilities.RequestBodyContentTypeEnum'></a>

## RequestBodyContentTypeEnum Enum

Enumerates the types of request body content types   
that can be found in a RequestBody object.

```csharp
public enum RequestBodyContentTypeEnum
```
### Fields

<a name='GTC.OpenApiUtilities.RequestBodyContentTypeEnum.OAS_FormDataContentType'></a>

`OAS_FormDataContentType` 1

[OAS_FormDataContentType](ParseTokens.OAS_FormDataContentType.md 'GTC.OpenApiUtilities.ParseTokens.OAS_FormDataContentType')

<a name='GTC.OpenApiUtilities.RequestBodyContentTypeEnum.OAS_JsonContentType'></a>

`OAS_JsonContentType` 0

[OAS_JsonContentType](ParseTokens.OAS_JsonContentType.md 'GTC.OpenApiUtilities.ParseTokens.OAS_JsonContentType')

<a name='GTC.OpenApiUtilities.RequestBodyContentTypeEnum.OAS_NoContentFound'></a>

`OAS_NoContentFound` 2

[OAS_NoContentFound](ParseTokens.OAS_NoContentFound.md 'GTC.OpenApiUtilities.ParseTokens.OAS_NoContentFound')

<a name='GTC.OpenApiUtilities.RequestBodyContentTypeEnum.OAS_Other'></a>

`OAS_Other` 3

A requestBody type not yet handled by the parser.

<a name='GTC.OpenApiUtilities.ResponseTypeEnum'></a>

## ResponseTypeEnum Enum

Describes the type of object returned from the API.

```csharp
public enum ResponseTypeEnum
```
### Fields

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.BinaryString'></a>

`BinaryString` 2

A binary string (usually a downloadable file, etc)

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.FailedToParse'></a>

`FailedToParse` 10

The ApiSet parser was not able to determine the response object type.

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.Integer'></a>

`Integer` 4

A plain old [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.List_BinaryString'></a>

`List_BinaryString` 6

A list of [BinaryString](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ResponseTypeEnum.BinaryString 'GTC.OpenApiUtilities.ResponseTypeEnum.BinaryString') items

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.List_Integer'></a>

`List_Integer` 8

A list of [Integer](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ResponseTypeEnum.Integer 'GTC.OpenApiUtilities.ResponseTypeEnum.Integer') items

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.List_Object'></a>

`List_Object` 5

A list of [Object](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ResponseTypeEnum.Object 'GTC.OpenApiUtilities.ResponseTypeEnum.Object') items

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.List_String'></a>

`List_String` 7

A list of [String](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ResponseTypeEnum.String 'GTC.OpenApiUtilities.ResponseTypeEnum.String') items

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.none'></a>

`none` 9

The endpoint does not return any data.

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.Object'></a>

`Object` 1

A class-based response object

<a name='GTC.OpenApiUtilities.ResponseTypeEnum.String'></a>

`String` 3

A plain old [String](GTC.HttpUtilities.md#GTC.OpenApiUtilities.ResponseTypeEnum.String 'GTC.OpenApiUtilities.ResponseTypeEnum.String').

### Remarks
This is used by the test generation software to   
determine what extraction and validation rule types   
can be used with the response.
