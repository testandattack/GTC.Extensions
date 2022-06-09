using System;
using System.Collections.Generic;
using System.Text;

namespace GTC.HttpUtilities
{

    public static class HttpResponseCodeGroups
    {
        public static List<int> One_xx()
        {
            return new List<int>(new int[] {
                100 ,
                101 ,
                102 ,
                103
            });
        }

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
        Misdirected_Request = 421,
        Unprocessable_Entity = 422,
        Locked = 423,
        Failed_Dependency = 424,
        Too_Early = 425,
        Upgrade_Required = 426,
        Precondition_Required = 428,
        Too_Many_Requests = 429,
        Request_Header_Fields_Too_Large = 431,
        
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
