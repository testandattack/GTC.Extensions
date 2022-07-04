using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;

namespace GTC.HttpUtilities
{
    /// <summary>
    /// A set of extension methods for use with the <see cref="HttpRequestMessage"/> object.
    /// </summary>
    public static class HttpRequestMessageExtensions
    {
        /// <summary>
        /// Allows you to synchronously retrieve the content body from an HttpRequestMessage as a string. 
        /// </summary>
        /// <param name="source">The HttpRequestMessage to which this method is exposed.</param>
        /// <remarks>
        /// Currently this method detects and converts the following content:
        /// <list type="bullet">
        /// <item><see cref="StringContent"/></item>
        /// <item><see cref="ByteArrayContent"/></item>
        /// <item><see cref="FormUrlEncodedContent"/></item>
        /// </list>
        /// The method also detects <see cref="MultipartFormDataContent"/> data, but does not convert it to a string. Instead it throws
        /// a <see cref="NotImplementedException"/>. NOTE, to retrieve FormUrlEncodedContent as a dictionary of Key-Value-Pairs, please
        /// use <see cref="GetContentHeaders"/>.
        /// </remarks>
        /// <returns></returns>
        public static string GetRequestContentBody(this HttpRequestMessage source)
        {
            if (source.Content == null)
                return "No request content found";

            // StringContent
            else if (source.Content is StringContent)
            {
                return source.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }

            // MultipartFormDataContent
            else if (source.Content is MultipartFormDataContent)
            {
                throw new NotImplementedException();
            }

            // ByteArrayContent
            else if (source.Content is ByteArrayContent)
            {
                byte[] content = source.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
                StringBuilder sb = new StringBuilder();
                for (int x = 0; x < content.Length; x++)
                {
                    sb.Append(Convert.ToChar(content[x]));
                }
                return sb.ToString();
            }

            // FormUrlEncodedContent
            else if (source.Content is FormUrlEncodedContent)
            {
                string content = source.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                return content;
            }

            // unknown
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Retrieves the headers associated with an HttpRequestMessage's <see cref="HttpContent"/>.
        /// </summary>
        /// <param name="source">The HttpRequestMessage to which this method is exposed.</param>
        public static Dictionary<string, string> GetContentHeaders(this HttpRequestMessage source)
        {
            if (source.Content == null)
                return null;

            return GetContentHeaders(source.Content);
        }

        /// <summary>
        /// Retrieves the headers associated with a <see cref="HttpContent"/> object.
        /// </summary>
        /// <param name="source">The HttpContent to which this method is exposed.</param>
        public static Dictionary<string, string> GetContentHeaders(this HttpContent source)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            foreach(var header in source.Headers)
            {
                headers.Add(header.Key, header.Value.ToString(";"));
            }
            return headers;
        }

        /// <summary>
        /// If the request has a <see cref="FormUrlEncodedContent"/> body, this method will read it and
        /// return a dictionary of Key-Value-Pairs representing all of the items in the body.
        /// </summary>
        /// <remarks>
        /// This method differs from <see cref="GetRequestContentBody"/> in that it formats the values and 
        /// inserts them into a Dictionary.
        /// </remarks>
        /// <param name="source">The HttpRequestMessage to which this method is exposed.</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetFormPostParamsFromContent(this HttpRequestMessage source)
        {
            if (source.Content == null)
                return null;

            return GetFormPostParamsFromContent(source.Content);
        }

        /// <summary>
        /// If the request has a <see cref="FormUrlEncodedContent"/> body, this method will read it and
        /// return a dictionary of Key-Value-Pairs representing all of the items in the body.
        /// </summary>
        /// <remarks>
        /// This method differs from <see cref="GetRequestContentBody"/> in that it formats the values and 
        /// inserts them into a Dictionary.
        /// </remarks>
        /// <param name="source">The HttpContent to which this method is exposed.</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetFormPostParamsFromContent(this HttpContent source)
        {
            if (source is FormUrlEncodedContent)
                return GetFormPostParamsFromContent(source as FormUrlEncodedContent);
                
            return null;
        }

        /// <summary>
        /// If the request has a <see cref="FormUrlEncodedContent"/> body, this method will read it and
        /// return a dictionary of Key-Value-Pairs representing all of the items in the body.
        /// </summary>
        /// <remarks>
        /// This method differs from <see cref="GetRequestContentBody"/> in that it formats the values and 
        /// inserts them into a Dictionary.
        /// </remarks>
        /// <param name="source">The FormUrlEncodedContent to which this method is exposed.</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetFormPostParamsFromContent(this FormUrlEncodedContent source)
        {
            string content = source.ReadAsStringAsync().GetAwaiter().GetResult();
            Dictionary<string, string> parms = new Dictionary<string, string>();
            foreach (string str in content.UrlDecode().Split("&", StringSplitOptions.RemoveEmptyEntries))
            {
                int x = str.IndexOf("=");
                if ((x + 1) >= str.Length)
                    parms.Add(str.Substring(0, x), "");
                else
                    parms.Add(str.Substring(0, x), str.Substring(x + 1));
            }
            return parms;
        }
    }
}
