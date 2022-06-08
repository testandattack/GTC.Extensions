using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace GTC.Extensions
{
    /// <summary>
    /// This class contains a series of methods to perform various operations on strings.
    /// </summary>
    public static class StringExtensions
    {
        static int MAX_LEN = 10485759;  // 10 Mb - 1 byte. If length is 10MB or larger, then string was truncated.

        #region -- FindSubString -----
        /// <summary>
        /// Looks for, and returns (if found) a string that resides in between the given <paramref name="startsAfter"/> and <paramref name="endsWith"/>
        /// strings. If the given start anbd ends strings are noit found, the method returns <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="startsAfter">the string that immediately preceeds the substring to locate.</param>
        /// <param name="endsWith">the string that comes immediately after the substring to locate.</param>
        /// <returns></returns>
        public static string FindSubString(this string source, string startsAfter, string endsWith)
        {
            int x = 0;
            return FindSubString(source, startsAfter, endsWith, 1, StringComparison.InvariantCulture, ref x, false);
        }

        /// <summary>
        /// Looks for, and returns (if found) a string that resides in between the given <paramref name="startsAfter"/> and <paramref name="endsWith"/>
        /// strings. If the given start anbd ends strings are noit found, the method returns <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="startsAfter">the string that immediately preceeds the substring to locate.</param>
        /// <param name="endsWith">the string that comes immediately after the substring to locate.</param>
        /// <param name="doNotFailOnMissingEndsWith">If true (and if there is no <paramref name="endsWith"/> located), the routine will return everything after the located starting point of the string</param>
        /// <returns></returns>
        public static string FindSubString(this string source, string startsAfter, string endsWith, bool doNotFailOnMissingEndsWith)
        {
            int x = 0;
            return FindSubString(source, startsAfter, endsWith, 1, StringComparison.InvariantCulture, ref x, doNotFailOnMissingEndsWith);
        }

        /// <summary>
        /// Looks for, and returns (if found) a string that resides in between the given <paramref name="startsAfter"/> and <paramref name="endsWith"/>
        /// strings. If the given start anbd ends strings are noit found, the method returns <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="startsAfter">the string that immediately preceeds the substring to locate.</param>
        /// <param name="endsWith">the string that comes immediately after the substring to locate.</param>
        /// <param name="iIndex">the zero-based index indicating which instance of <paramref name="startsAfter"/> should be used.</param>
        /// <returns></returns>
        public static string FindSubString(this string source, string startsAfter, string endsWith, int iIndex)
        {
            int x = 0;
            return FindSubString(source, startsAfter, endsWith, iIndex, StringComparison.InvariantCulture, ref x, false);
        }

        /// <summary>
        /// Looks for, and returns (if found) a string that resides in between the given <paramref name="startsAfter"/> and <paramref name="endsWith"/>
        /// strings. If the given start anbd ends strings are noit found, the method returns <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="startsAfter">the string that immediately preceeds the substring to locate.</param>
        /// <param name="endsWith">the string that comes immediately after the substring to locate.</param>
        /// <param name="iIndex">the zero-based index indicating which instance of <paramref name="startsAfter"/> should be used.</param>
        /// <param name="comp">a <see cref="StringComparison"/> object that is applied to the searching.</param>
        /// <returns></returns>
        public static string FindSubString(this string source, string startsAfter, string endsWith, int iIndex, StringComparison comp)
        {
            int x = 0;
            return FindSubString(source, startsAfter, endsWith, iIndex, StringComparison.InvariantCulture, ref x, false);
        }

        /// <summary>
        /// Looks for, and returns (if found) a string that resides in between the given <paramref name="startsAfter"/> and <paramref name="endsWith"/>
        /// strings. If the given start anbd ends strings are noit found, the method returns <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="startsAfter">the string that immediately preceeds the substring to locate.</param>
        /// <param name="endsWith">the string that comes immediately after the substring to locate.</param>
        /// <param name="iIndex">the zero-based index indicating which instance of <paramref name="startsAfter"/> should be used.</param>
        /// <param name="subStringFoundAtLocation">an integer that stores the index of the first character of the returned substring.</param>
        /// <returns></returns>
        public static string FindSubString(this string source, string startsAfter, string endsWith, int iIndex, ref int subStringFoundAtLocation)
        {
            return FindSubString(source, startsAfter, endsWith, iIndex, StringComparison.InvariantCulture, ref subStringFoundAtLocation, false);
        }

        /// <summary>
        /// Looks for, and returns (if found) a string that resides in between the given <paramref name="startsAfter"/> and <paramref name="endsWith"/>
        /// strings. If the given start anbd ends strings are noit found, the method returns <see cref="String.Empty"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="startsAfter">the string that immediately preceeds the substring to locate.</param>
        /// <param name="endsWith">the string that comes immediately after the substring to locate.</param>
        /// <param name="iIndex">the zero-based index indicating which instance of <paramref name="startsAfter"/> should be used.</param>
        /// <param name="comp">a <see cref="StringComparison"/> object that is applied to the searching.</param>
        /// <param name="subStringFoundAtLocation">an integer that stores the index of the first character of the returned substring.</param>
        /// <param name="doNotFailOnMissingEndsWith">If true (and if there is no <paramref name="endsWith"/> located), the routine will return everything after the located starting point of the string</param>
        /// <returns></returns>
        /// <remarks>
        /// </remarks>
        public static string FindSubString(this string source, string startsAfter, string endsWith, int iIndex, StringComparison comp, ref int subStringFoundAtLocation, bool doNotFailOnMissingEndsWith)
        {
            subStringFoundAtLocation = -1;
            if (string.IsNullOrEmpty(source))
                return string.Empty;

            int iStart = -1;
            int iCurrent = 0;
            int iLoopCounter = 0;

            for (iLoopCounter = 0; iLoopCounter < iIndex; iLoopCounter++)
            {
                iStart = source.IndexOf(startsAfter, iCurrent, comp);
                if (iStart == -1)
                    return String.Empty;
                iCurrent = iStart + startsAfter.Length;
            }

            int iEnd = source.IndexOf(endsWith, iCurrent, comp);
            if (iEnd == -1 && doNotFailOnMissingEndsWith == false)
                return String.Empty;

            subStringFoundAtLocation = iCurrent;
            if (iEnd == -1)
            {
                return source.Substring(iCurrent);
            }
            return source.Substring(iCurrent, iEnd - iCurrent);
        }

        /// <summary>
        /// Searches a string for all instances of a substring, using the <see cref="FindSubString(string, string, string)"/>
        /// method, adding every found instance to a list.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="startsAfter">the string that immediately preceeds the substring to locate.</param>
        /// <param name="endsWith">the string that comes immediately after the substring to locate.</param>
        public static List<string> FindSubStrings(this string source, string startsAfter, string endsWith)
        {
            int x = 0;
            int loopCounter = 1;
            string item = "";
            List<string> items = new List<string>();

            item = FindSubString(source, startsAfter, endsWith, loopCounter, StringComparison.InvariantCulture, ref x, false);

            while (item != string.Empty)
            {
                items.Add(item);
                loopCounter++;
                item = FindSubString(source, startsAfter, endsWith, loopCounter, StringComparison.InvariantCulture, ref x, false);
            }
            return items;
        }
        #endregion

        #region -- Misc -----
        /// <summary>
        /// Checks the value of the string to see if it represents a boolean value.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <returns></returns>
        public static bool IsBoolean(this string source)
        {
            if (source.Length > 5)
                return false;
            if (source.ToUpper() == "TRUE" || source.ToUpper() == "FALSE")
                return true;
            return false;
        }

        /// <summary>
        /// Checks the value of the string to see if it represents an 
        /// <see href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types">
        /// integral or numeric</see> value.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <returns></returns>
        public static Type IsNumeric(this string source)
        {
            if (Int32.TryParse(source, System.Globalization.NumberStyles.Number, CultureInfo.InvariantCulture, out _) == true)
                return typeof(System.Int32);
            else if (double.TryParse(source, out _) == true)
                return typeof(System.Double);
            else
                return typeof(System.String);
        }

        /// <summary>
        /// Gets the URL portion of a string, removing any query parameter text that might
        /// be part of the string. 
        /// </summary>
        /// <remarks>
        /// This extension method acts the same way that <see cref="System.Uri.GetLeftPart(UriPartial)"/> works, but
        /// performs the operation on a string.
        /// </remarks>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <returns>A string representing the left portion of the source string, up to but not including the <c>?</c> delimiter</returns>
        public static string GetUrlWithoutQuery(this String source)
        {
            string decoded = source.UrlDecode();
            int x = decoded.IndexOf("?");
            if (x == -1)
                return decoded;
            else
                return decoded.Substring(0, x);
        }

        /// <summary>
        /// Gets the left side [beginning] of a given string, up to, but not including the <paramref name="delimiter"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="delimiter">The string representing the text that marks the beginning of the text to truncate.</param>
        /// <param name="returnEmptyIfDelimiterNotFound">If true, the method returns an empty string if the delimiter is not found.</param>
        public static string GetLeftPart(this string source, string delimiter, bool returnEmptyIfDelimiterNotFound = true)
        {
            int iEnd = source.IndexOf(delimiter);

            if (iEnd == -1)
            {
                if (returnEmptyIfDelimiterNotFound == true)
                {
                    return string.Empty;
                }
                else
                {
                    return source;
                }
            }

            return source.Substring(0, iEnd);
        }

        /// <summary>
        /// Gets the right side [end] of a given string, starting with the text AFTER the <paramref name="delimiter"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="delimiter">The string representing the text that should appear JUST BEFORE the text to return.</param>
        /// <returns></returns>
        public static string GetRightPart(this string source, string delimiter)
        {
            int iStart = source.IndexOf(delimiter);

            if (iStart == -1)
            {
                return string.Empty;
            }

            return source.Substring(iStart + delimiter.Length);
        }

        /// <summary>
        /// Returns a shortened version of the <paramref name="source"/> string, with the
        /// word "**TRUNCATED**" added to the end.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="maxLen">the maximum length to return, including the "**TRUNCATED**" keyword.</param>
        public static string Shortened(this String source, int maxLen)
        {
            if (source.Length >= maxLen && maxLen > 13)
                return source.Substring(0, maxLen - 13) + "**TRUNCATED**";
            else if (maxLen <= 13)
                return source.Substring(0, maxLen);
            else
                return source;
        }

        /// <summary>
        /// returns a new string with all carriage returns and line feeds removed.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="maxLen">the maximum length to return.</param>
        public static string Flattened(this String source, int maxLen)
        {
            string newStr = source.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
            return newStr.Shortened(maxLen);
        }

        /// <summary>
        /// This method uses the <see cref="String.CompareTo(string)"/> to get the
        /// sorted order of the two strings, then returns <c>True</c> if <paramref name="source"/>
        /// comes before <paramref name="secondString"/> or <c>False</c> if they are equal or <paramref name="secondString"/>
        /// comes before <paramref name="source"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="secondString">the string to compare to <paramref name="source"/>.</param>
        /// <param name="comp">a <see cref="StringComparison"/> enum defining how to perform the comparison.</param>
        public static bool IsGreaterThan(this string source, string secondString, StringComparison comp = StringComparison.CurrentCultureIgnoreCase)
        {
            return String.Compare(source, secondString, comp) > 0;
        }

        /// <summary>
        /// This method uses the <see cref="String.CompareTo(string)"/> to get the
        /// sorted order of the two strings, then returns <c>True</c> if <paramref name="source"/>
        /// comes after <paramref name="secondString"/> or <c>False</c> if they are equal or <paramref name="secondString"/>
        /// comes after <paramref name="source"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="secondString">the string to compare to <paramref name="source"/>.</param>
        /// <param name="comp">a <see cref="StringComparison"/> enum defining how to perform the comparison.</param>
        public static bool IsLessThan(this string source, string secondString, StringComparison comp = StringComparison.CurrentCultureIgnoreCase)
        {
            return String.Compare(source, secondString, comp) < 0;
        }

        /// <summary>
        /// Gets the name of a file from a fully qualified fileName, dropping any path info present.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        public static string FileNameWithoutPath(this string source)
        {
            int iStart = source.LastIndexOf("\\");

            if (iStart == -1 || iStart + 1 >= source.Length)
                return source;
            else
                return source.Substring(iStart + 1);
        }
        #endregion

        #region -- Returns lists etc -----
        /// <summary>
        /// Converts a string that has numbers separated by a defined delimiter into an
        /// array of integers.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="delimiter">the string that delimits the values.</param>
        public static int[] DelimitedStringToIntArray(this string source, string delimiter)
        {
            try
            {
                string cleanedSource = source.Replace("[", "").Replace("]", "");
                List<string> list = new List<string>();
                foreach (string subStr in cleanedSource.Split(new string[] { delimiter }, StringSplitOptions.RemoveEmptyEntries))
                {
                    list.Add(subStr);
                }

                int[] intArray = new int[list.Count];

                for (int x = 0; x < list.Count; x++)
                {
                    intArray[x] = Int32.Parse(list[x]);
                }
                return intArray;
            }

            catch
            {
            }

            return new int[0];
        }

        /// <summary>
        /// Converts a string to a Memory Stream.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <returns></returns>
        public static MemoryStream ToStream(this string source)
        {
            return ToStream(source, false);
        }

        /// <summary>
        /// Converts a string to a Memory Stream.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="leaveStreamOpen">If <c>True</c>, the StreamWriter is left open and must be closed by the calling method.</param>
        public static MemoryStream ToStream(this string source, bool leaveStreamOpen)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.ASCII, source.Length, leaveStreamOpen);
            writer.Write(source);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
        #endregion

        #region -- CSV Stuff -----
        /// <summary>
        /// Returns a list of strings from a single string that is CSV formatted. For more information, see
        /// <see href="https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings">
        /// this article</see>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        public static List<string> CsvStrToList(this string source)
        {
            return source.CsvStrToStringArray().ToList();
        }

        /// <summary>
        /// Returns a list of strings from a single string that is CSV formatted. For more information, see
        /// <see href="https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings">
        /// this article</see>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="escapeSingleQuotes">If <c>True</c>, single quotes are converted to T-SQL escaped quotes.</param>
        public static List<string> CsvStrToList(this string source, bool escapeSingleQuotes = false)
        {
            return source.CsvStrToStringArray(escapeSingleQuotes).ToList();
        }

        /// <summary>
        /// Returns an array of strings from a single string that is CSV formatted. For more information, see
        /// <see href="https://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings">
        /// this article</see>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="escapeSingleQuotes"></param>
        public static string[] CsvStrToStringArray(this string source, bool escapeSingleQuotes = false)
        {
            List<string> result = new List<string>();
            StringBuilder currentStr = new StringBuilder("");
            bool inQuotes = false;
            for (int i = 0; i < source.Length; i++) // For each character
            {
                if (source[i] == '\"') // Quotes are closing or opening
                    inQuotes = !inQuotes;
                else if (source[i] == ',') // Comma
                {
                    if (!inQuotes) // If not in quotes, end of current string, add it to result
                    {
                        if (currentStr.Length == 0)
                        {
                            result.Add("null");
                        }
                        else
                        {
                            result.Add(currentStr.ToString());
                        }
                        currentStr.Clear();
                    }
                    else
                        currentStr.Append(source[i]); // If in quotes, just add it 
                }
                else if (source[i] == '\'' && escapeSingleQuotes) // If we need to escape single quotes, do it here
                {
                    currentStr.Append("''");
                }
                else // Add any other character to current string
                    currentStr.Append(source[i]);
            }
            result.Add(currentStr.ToString());
            return result.ToArray(); // Return array of all strings
        }

        /// <summary>
        /// <c>OBSOLETE</c> This method is maintained for backward compatibility. 
        /// Call <see cref="CsvStrToStringArray(string, bool)"/> instead.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="escapeSingleQuotes">If <c>True</c>, single quotes are converted to T-SQL escaped quotes.</param>
        public static string[] SplitCsvRowToArray(this string source, bool escapeSingleQuotes = false)
        {
            return source.CsvStrToStringArray(escapeSingleQuotes);
        }

        /// <summary>
        /// <c>OBSOLETE</c> This method is maintained for backward compatibility. 
        /// Call <see cref="CsvStrToList(string, bool)"/> instead.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <param name="escapeSingleQuotes">If <c>True</c>, single quotes are converted to T-SQL escaped quotes.</param>
        public static List<string> SplitCsvRowToList(this string source, bool escapeSingleQuotes = false)
        {
            return source.CsvStrToList(escapeSingleQuotes);
        }
        #endregion

        #region -- modifiers -----
        /// <summary>
        /// Returns a new string without any "escaped Quotes" from the <paramref name="source"/>. 
        /// This is useful when a string is copied
        /// from a system that requires quotes to be escaped.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        public static string RemoveQuoteEscapes(this String source)
        {
            return source.Replace("\\\"", "\"");
        }

        /// <summary>
        /// If the string has quotes at the beginning and end locations, this method returns a 
        /// new string without those quotes.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        public static string RemoveEncapsulatingQuotes(this String source)
        {
            if (source.StartsWith("\"") && source.EndsWith("\""))
                return source.Substring(1, source.Length - 2);
            return source.Replace("\\\"", "\"");
        }

        /// <summary>
        /// Returns a new string that contains the <paramref name="source"/> string
        /// surrounded by double curly braces. This is used for defining context
        /// parameters in some test engines.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        public static string AddBraces(this string source)
        {
            return "{{" + source + "}}";
        }

        /// <summary>
        /// This method takes a string representing a namespace or object name, and creates
        /// a new string where all leading characters are converted to lower case.
        /// </summary>
        /// <remarks>
        /// This method is useful for converting entries in an OpenApi document so that 
        /// they respect camelCase validation. For instance, the value <c>GTC.Extensions.ToCamelCase</c>
        /// would be returned as <c>gTC.extensions.toCamelCase</c>.
        /// </remarks>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        public static string ToCamelCase(this string source)
        {
            if (string.IsNullOrEmpty(source)) return source;

            var camelCasedParts = source.Split('.').Select(part => char.ToLowerInvariant(part[0]) + part.Substring(1));

            return string.Join(".", camelCasedParts);
        }
        #endregion

        #region -- Encoders -----
        /// <summary>
        /// Returns a new string that has been processed by a call to <see cref="HttpUtility.UrlDecode(string)"/>.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        public static string UrlDecode(this String source)
        {
            return HttpUtility.UrlDecode(source);
        }

        /// <summary>
        /// Returns a new string that has been converted to a Base64 Encoded string format.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        public static string Base64Encode(this string source)
        {
            if (source.Length < MAX_LEN)
            {
                int i = 0;
                byte[] _byte = new byte[(source.Length)];
                foreach (char c in source.ToCharArray())
                {
                    _byte[i++] = (byte)c;
                }
                return Convert.ToBase64String(_byte);
            }
            else
                return source;
        }

        /// <summary>
        /// Returns a new string that has been converted from a Base64 Encoded string format
        /// into its original format.
        /// </summary>
        /// <param name="source">The <c>string</c> to which this method is exposed.</param>
        /// <returns></returns>
        public static string Base64Decode(this string source)
        {
            if (source.Length < MAX_LEN)
            {
                byte[] _byte = new byte[(source.Length)];
                _byte = Convert.FromBase64String(source);

                StringBuilder s = new StringBuilder();
                foreach (char c in _byte)
                {
                    // Quick hack to deal with unicode. Needs to be fixed
                    if (c != 0)
                        s.Append(c);
                }
                return s.ToString();
            }
            else
                return source;
        }
        #endregion

    }
}
