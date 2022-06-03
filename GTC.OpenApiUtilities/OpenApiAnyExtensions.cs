using Microsoft.OpenApi.Any;
using Serilog;
using System;
using System.Text;

namespace GTC.OpenApiUtilities
{
    public static class OpenApiAnyExtensions
    {

        /// <summary>
        /// Reads the passed in <see cref="IOpenApiAny"/> object and returns the value
        /// it contains in a predefined format
        /// </summary>
        /// <param name="value"></param>
        /// <returns>a string representation of the contained primitive value.</returns>
        public static string GetPrimitiveValue(this IOpenApiAny value)
        {
            Type exampleType = value.GetType();
            try
            {
                if (exampleType == typeof(OpenApiDateTime))
                {
                    return ((OpenApiDateTime)(value)).Value.ToString("yyyy-MM-dd h:mm:ss tt");
                }
                else if (exampleType == typeof(OpenApiDate))
                {
                    return ((OpenApiDate)(value)).Value.ToString("yyyy-MM-dd");
                }
                else if (exampleType == typeof(OpenApiInteger))
                {
                    return ((OpenApiInteger)(value)).Value.ToString();
                }
                else if (exampleType == typeof(OpenApiString))
                {
                    return ((OpenApiString)(value)).Value;
                }
                else if (exampleType == typeof(OpenApiBoolean))
                {
                    return ((OpenApiBoolean)(value)).Value.ToString();
                }
                else if (exampleType == typeof(OpenApiDouble))
                {
                    return ((OpenApiDouble)(value)).Value.ToString();
                }
                else if (exampleType == typeof(OpenApiFloat))
                {
                    return ((OpenApiFloat)(value)).Value.ToString();
                }
                else if (exampleType == typeof(OpenApiLong))
                {
                    return ((OpenApiLong)(value)).Value.ToString();
                }
                else if (exampleType == typeof(OpenApiByte))
                {
                    return ((OpenApiByte)(value)).Value[0].ToString();
                }
                else if (exampleType == typeof(OpenApiBinary))
                {
                    return ByteArrayToString(((OpenApiBinary)(value)).Value);
                }
                Log.ForContext("SourceContext", "ParameterExtensions").Error("[{method}]: Failed to find a recognized type. {@value}", "GetPrimitiveValue", value);
            }
            catch (Exception ex)
            {
                Log.ForContext("SourceContext", "ParameterExtensions").Error(ex, "[{method}]: Exception parsing {@value}", "GetPrimitiveValue", value);
            }
            return "";
        }

        private static string ByteArrayToString(byte[] array)
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < array.Length; x++)
            {
                sb.Append(array[x].ToString());
            }
            return sb.ToString();
        }
    }
}
