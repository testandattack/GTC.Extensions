using Microsoft.OpenApi.Models;
using Serilog;

namespace GTC.OpenApiUtilities
{
    /// <summary>
    /// A set of extension methods to work on the Microsoft.OpenApi.Models.OpenApiSchema class
    /// </summary>
    public static class OpenApiSchemaExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source">The <c>IOpenApiSchema</c> to which this method is exposed.</param>
        /// <param name="depthPrecursor"></param>
        /// <param name="currentDepth"></param>
        /// <returns></returns>
        public static string GetSchemaItemType(this OpenApiSchema source, string depthPrecursor = "", int currentDepth = 0)
        {
            if (currentDepth > 2)
            {
                return "parsed too depp";
            }

            if (source.Type != null)
            {
                string itemType = source.Type;

                if (itemType == "array")
                {
                    // Recursive call
                    string newDepthPrecursor = $"List_{depthPrecursor}";
                    if (source.Items != null)
                    {
                        return $"{GetSchemaItemType(source.Items, newDepthPrecursor, currentDepth + 1)}";
                    }
                    else
                    {
                        Log.ForContext("SourceContext", "SchemaExtensions").Error("[{method}]: Failed to find items in an array. {@value}", "GetSchemaItemType", source);
                        return $"{newDepthPrecursor}{ParseTokens.PARAM_MissingInfo}";
                    }
                }
                else
                {
                    return $"{depthPrecursor}{itemType}";
                }
            }
            else
            {
                Log.ForContext("SourceContext", "SchemaExtensions").Error("[{method}]: Failed to find Item Type. {@value}", "GetSchemaItemType", source);
                return $"{depthPrecursor}{ParseTokens.PARAM_MissingInfo}";
            }
        }
    }
}
