using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace GTC.HttpUtilities
{
    public static class HttpRequestHelpers
    {
        /// <summary>
        /// This helper is handy when trying to set the method type in a request being
        /// programatically built if you have the string equivalent, like the value
        /// in an Http Archive file.
        /// </summary>
        /// <param name="methodString">one of the allowed HTTP method types, such as GET, DELETE, etc.
        /// Note: The value is NOT case sensitive.</param>
        /// <returns>returns the equivalent <see cref="HttpMethod"/> value.</returns>
        public static HttpMethod GetMethodTypeFromString(string methodString)
        {
            switch (methodString.ToUpper())
            {
                case "DELETE":
                    return HttpMethod.Delete;
                case "GET":
                    return HttpMethod.Get;
                case "HEAD":
                    return HttpMethod.Head;
                case "OPTIONS":
                    return HttpMethod.Options;
                case "PATCH":
                    return HttpMethod.Patch;
                case "POST":
                    return HttpMethod.Post;
                case "PUT":
                    return HttpMethod.Put;
                case "TRACE":
                    return HttpMethod.Trace;
                default:
                    return HttpMethod.Get;
            }
        }
    }
}
