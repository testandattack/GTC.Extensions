using System;
using System.Collections.Generic;
using System.Text;

namespace GTC.OpenApiUtilities
{
    /// <summary>
    /// This class contains constant string values that are used for parsing OAS documents.
    /// </summary>
    public class ParseTokens
    {
        /// <summary>
        /// the string to search for in the content-type that indicates the response is a JSON object
        /// </summary>
        public const string OAS_JsonContentType = "application/json";

        /// <summary>
        /// the string to search for in the content-type that indicates the response is a binary or form data object
        /// </summary>
        public const string OAS_FormDataContentType = "multipart/form-data";

        /// <summary>
        /// the string to search for in the content-type that indicates there was no response object.
        /// </summary>
        public const string OAS_NoContentFound = "No content object found";

        /// <summary>
        /// this string represents an item in the OAS schema that has missing info.
        /// </summary>
        public const string PARAM_MissingInfo = "MissingInfo";

        /// <summary>
        /// this string represents an item in the OAS schema that has a missing field type.
        /// </summary>
        public const string PARAM_MissingTypeField = "Type Not Found";
    }
}
