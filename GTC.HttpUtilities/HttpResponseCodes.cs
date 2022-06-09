using System;
using System.Collections.Generic;
using System.Text;

namespace GTC.HttpUtilities
{
    /// <summary>
    /// This class defines lists of Http Status code, broken down by the group that
    /// each code falls into. 
    /// <remarks>
    /// The categories are as follows:
    /// <list type="bullet">
    /// <item><c>1xx</c>: Informational</item>
    /// <item><c>2xx</c>: Success</item>
    /// <item><c>3xx</c>: Redirection</item>
    /// <item><c>4xx</c>: Client Error</item>
    /// <item><c>5xx</c>: Server Error</item>
    /// </list>
    /// </remarks>
    /// </summary>
    public static class HttpResponseCodeGroups
    {
        /// <summary>
        /// A List containing all of the 1xx (or Informational) response codes.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
		/// <item>Continue = 100</item>
		/// <item>Switching_Protocols = 101</item>
		/// <item>Processing = 102</item>
		/// <item>Early_Hints = 103</item>
        /// </list>
        /// </remarks>
        public static List<int> One_xx()
        {
            return new List<int>(new int[] {
                100 ,
                101 ,
                102 ,
                103
            });
        }

        /// <summary>
        /// A List containing all of the 2xx (or Success) response codes.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
		/// <item>OK = 200</item>
		/// <item>Created = 201</item>
		/// <item>Accepted = 202</item>
		/// <item>Non_Authoritative_Information = 203</item>
		/// <item>No_Content = 204</item>
		/// <item>Reset_Content = 205</item>
		/// <item>Partial_Content = 206</item>
		/// <item>Multi_Status = 207</item>
		/// <item>Already_Reported = 208</item>
		/// <item>IM_Used = 226</item>
        /// </list>
        /// </remarks>
        public static List<int> Two_xx()
        {
            return new List<int>(new int[] {
                200 ,
                201 ,
                202 ,
                203 ,
                204 ,
                205 ,
                206 ,
                207 ,
                208 ,
                226
            });
        }

        /// <summary>
        /// A List containing all of the 3xx (or Redirection) response codes.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
		/// <item>Multiple_Choices = 300</item>
		/// <item>Moved_Permanently = 301</item>
		/// <item>Found = 302</item>
		/// <item>See_Other = 303</item>
		/// <item>Not_Modified = 304</item>
		/// <item>Use_Proxy = 305</item>
		/// <item>Temporary_Redirect = 307</item>
		/// <item>Permanent_Redirect = 308</item>
        /// </list>
        /// </remarks>
        public static List<int> Three_xx()
        {
            return new List<int>(new int[] {
                300 ,
                301 ,
                302 ,
                303 ,
                304 ,
                305 ,
                307 ,
                308
            });
        }

        /// <summary>
        /// A List containing all of the 4xx (or Client Error) response codes.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
		/// <item>Bad_Request = 400</item>
		/// <item>Unauthorized = 401</item>
		/// <item>Payment_Required = 402</item>
		/// <item>Forbidden = 403</item>
		/// <item>Not_Found = 404</item>
		/// <item>Method_Not_Allowed = 405</item>
		/// <item>Not_Acceptable = 406</item>
		/// <item>Proxy_Authentication_Required = 407</item>
		/// <item>Request_Timeout = 408</item>
		/// <item>Conflict = 409</item>
		/// <item>Gone = 410</item>
		/// <item>Length_Required = 411</item>
		/// <item>Precondition_Failed = 412</item>
		/// <item>Payload_Too_Large = 413</item>
		/// <item>URI_Too_Long = 414</item>
		/// <item>Unsupported_Media_Type = 415</item>
		/// <item>Range_Not_Satisfiable = 416</item>
		/// <item>Expectation_Failed = 417</item>
		/// <item>Im_A_Teapot = 418</item> // RFC 2324</item> RFC 7168 - April Fools or Easter Egg response
		/// <item>Misdirected_Request = 421</item>
		/// <item>Unprocessable_Entity = 422</item>
		/// <item>Locked = 423</item>
		/// <item>Failed_Dependency = 424</item>
		/// <item>Too_Early = 425</item>
		/// <item>Upgrade_Required = 426</item>
		/// <item>Precondition_Required = 428</item>
		/// <item>Too_Many_Requests = 429</item>
		/// <item>Request_Header_Fields_Too_Large = 431</item>
		/// <item>Unavailable_For_Legal_Reasons = 451</item>
        /// </list>
        /// </remarks>
        public static List<int> Four_xx()
        {
            return new List<int>(new int[] {
                400 ,
                401 ,
                402 ,
                403 ,
                404 ,
                405 ,
                406 ,
                407 ,
                408 ,
                409 ,
                410 ,
                411 ,
                412 ,
                413 ,
                414 ,
                415 ,
                416 ,
                417 ,
                421 ,
                422 ,
                423 ,
                424 ,
                425 ,
                426 ,
                428 ,
                429 ,
                431
            });
        }

        /// <summary>
        /// A List containing all of the 5xx (or Server Error) response codes.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
		/// <item>Internal_Server_Error = 500</item>
		/// <item>Not_Implemented = 501</item>
		/// <item>Bad_Gateway = 502</item>
		/// <item>Service_Unavailable = 503</item>
		/// <item>Gateway_Timeout = 504</item>
		/// <item>HTTP_Version_Not_Supported = 505</item>
		/// <item>Variant_Also_Negotiates = 506</item>
		/// <item>Insufficient_Storage = 507</item>
		/// <item>Loop_Detected = 508</item>
		/// <item>Not_Extended = 510</item>
		/// <item>Network_Authentication_Required = 511</item>
        /// </list>
        /// </remarks>
        public static List<int> Five_xx()
        {
            return new List<int>(new int[] {
                500 ,
                501 ,
                502 ,
                503 ,
                504 ,
                505 ,
                506 ,
                507 ,
                508 ,
                510 ,
                511
            });
        }

        /// <summary>
        /// returns the list of codes associated with the group passed in
        /// </summary>
        /// <param name="group">1, 2, 3, 4 or 5</param>
        /// <returns></returns>
        public static List<int> GetGroupCodes(int group)
        {
            switch(group)
            {
                case 1:
                    return One_xx();
                case 2:
                    return Two_xx();
                case 3:
                    return Three_xx();
                case 4:
                    return Four_xx();
                case 5:
                    return Five_xx();
                default:
                    return new List<int>();
            }
        }

        /// <summary>
        /// Checks a given integer value to see if that value represents any HttpStatus Code
        /// </summary>
        /// <param name="code">the three digit code to check foir validity.</param>
        public static bool IsValidResponseCode(int code)
        {
            if (One_xx().Contains(code))
                return true;

            if (Two_xx().Contains(code))
                return true;

            if (Three_xx().Contains(code))
                return true;

            if (Four_xx().Contains(code))
                return true;

            if (Five_xx().Contains(code))
                return true;

            return false;
        }
    }

    /// <summary>
    /// This enum defines every recognized status code available for reporting
    /// the response status of an HTTP web request. There are more codes listed 
    /// <see href="https://en.wikipedia.org/wiki/List_of_HTTP_status_codes">here</see>, but
    /// they are listed as unofficial.
    /// </summary>
    public enum StatusCodes
    {
        Continue = 100,
        Switching_Protocols = 101,
        Processing = 102,
        Early_Hints = 103,
        
        OK = 200,
        Created = 201,
        Accepted = 202,
        Non_Authoritative_Information = 203,
        No_Content = 204,
        Reset_Content = 205,
        Partial_Content = 206,
        Multi_Status = 207,
        Already_Reported = 208,
        IM_Used = 226,
        
        Multiple_Choices = 300,
        Moved_Permanently = 301,
        Found = 302,
        See_Other = 303,
        Not_Modified = 304,
        Use_Proxy = 305,
        Temporary_Redirect = 307,
        Permanent_Redirect = 308,
        
        Bad_Request = 400,
        Unauthorized = 401,
        Payment_Required = 402,
        Forbidden = 403,
        Not_Found = 404,
        Method_Not_Allowed = 405,
        Not_Acceptable = 406,
        Proxy_Authentication_Required = 407,
        Request_Timeout = 408,
        Conflict = 409,
        Gone = 410,
        Length_Required = 411,
        Precondition_Failed = 412,
        Payload_Too_Large = 413,
        URI_Too_Long = 414,
        Unsupported_Media_Type = 415,
        Range_Not_Satisfiable = 416,
        Expectation_Failed = 417,
        Im_A_Teapot = 418, // RFC 2324, RFC 7168 - April Fools or Easter Egg response
        Misdirected_Request = 421,
        Unprocessable_Entity = 422,
        Locked = 423,
        Failed_Dependency = 424,
        Too_Early = 425,
        Upgrade_Required = 426,
        Precondition_Required = 428,
        Too_Many_Requests = 429,
        Request_Header_Fields_Too_Large = 431,
        Unavailable_For_Legal_Reasons = 451,
        
        Internal_Server_Error = 500,
        Not_Implemented = 501,
        Bad_Gateway = 502,
        Service_Unavailable = 503,
        Gateway_Timeout = 504,
        HTTP_Version_Not_Supported = 505,
        Variant_Also_Negotiates = 506,
        Insufficient_Storage = 507,
        Loop_Detected = 508,
        Not_Extended = 510,
        Network_Authentication_Required = 511
    }
}
