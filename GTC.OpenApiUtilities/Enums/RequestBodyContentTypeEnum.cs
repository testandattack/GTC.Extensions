﻿using Microsoft.OpenApi.Models;
using System;

namespace GTC.OpenApiUtilities
{
    /// <summary>
    /// Enumerates the types of request body content types 
    /// that can be found in a RequestBody object.
    /// </summary>
    public enum RequestBodyContentTypeEnum
    {
        /// <summary>
        /// <see cref="ParseTokens.OAS_JsonContentType"/>
        /// </summary>
        OAS_JsonContentType,

        /// <summary>
        /// <see cref="ParseTokens.OAS_FormDataContentType"/>
        /// </summary>
        OAS_FormDataContentType,

        /// <summary>
        /// <see cref="ParseTokens.OAS_NoContentFound"/>
        /// </summary>
        OAS_NoContentFound,

        /// <summary>
        /// A requestBody type not yet handled by the parser.
        /// </summary>
        OAS_Other
    }

}
