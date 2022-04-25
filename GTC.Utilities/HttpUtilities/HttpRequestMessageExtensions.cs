using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using GTC.Extensions;

namespace GTC.Utilities.HttpUtilities
{
    public static class HttpRequestMessageExtensions
    {
        public static string GetRequestBody(this HttpRequestMessage source)
        {
            if (source.Content == null)
                return "No request content found";

            else if (source.Content is StringContent)
            {
                return source.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
            else if (source.Content is MultipartFormDataContent)
            {
                throw new NotImplementedException();
            }
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
            else if (source.Content is FormUrlEncodedContent)
            {
                string content = source.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                return content;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static Dictionary<string, string> GetContentHeaders(this HttpRequestMessage source)
        {
            if (source.Content == null)
                return null;

            return GetContentHeaders(source.Content);
        }

        public static Dictionary<string, string> GetContentHeaders(this HttpContent source)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            foreach(var header in source.Headers)
            {
                headers.Add(header.Key, header.Value.ToString(";"));
            }
            //headers.Add("Content-Type", source.Headers.ContentType.CharSet);
            //headers.Add("", source.Headers.ContentType.MediaType);
            return headers;
        }

        public static Dictionary<string, string> GetFormPostParamsFromContent(this HttpRequestMessage source)
        {
            if (source.Content == null)
                return null;

            return GetFormPostParamsFromContent(source.Content);
        }

        public static Dictionary<string, string> GetFormPostParamsFromContent(this HttpContent source)
        {
            if (source is FormUrlEncodedContent)
                return GetFormPostParamsFromContent(source as FormUrlEncodedContent);
                
            return null;
        }

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
