using System.Collections.Generic;
using System.Text;

namespace GTC.Extensions
{
    /// <summary>
    /// A collection of extension methods for certain Dictionary objects.
    /// </summary>
    /// <remarks>
    /// These extension methods are designed only for a few combinations of dictionaries and will not work on
    /// many combinations. Please refer to the information provided in each method's documentation to determine
    /// if it will work for you.
    /// </remarks>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// This method checks for the existence of the given key. If the key is NOT present
        /// in the dictionary, then the Key-Value-Pair is added. If the key IS present, then no action
        /// is taken.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, string}</c> to which this method is exposed.</param>
        /// <param name="sKey">The key of the Key-Value-Pair to add if not already present.</param>
        /// <param name="sValue">The value of the Key-Value-Pair to add if the key is not already present.</param>
        public static void AddSafely(this Dictionary<string, string> source, string sKey, string sValue)
        {
            if (source.ContainsKey(sKey))
                return;
            source.Add(sKey, sValue);
        }

        /// <summary>
        /// This method checks for the existence of <paramref name="sKey"/> in the dictionary. If present, the
        /// current value is replaced with the new <paramref name="sValue"/>. Otherwise, the key and value are added
        /// to the Dictionary.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, string}</c> to which this method is exposed.</param>
        /// <param name="sKey">The key of the Key-Value-Pair to add if not already present.</param>
        /// <param name="sValue">The value of the Key-Value-Pair to add, or update if the kley is already present.</param>
        public static void AddOrUpdate(this Dictionary<string, string> source, string sKey, string sValue)
        {
            if (source.ContainsKey(sKey))
            {
                source[sKey] = sValue;
            }
            else
            {
                source.Add(sKey, sValue);
            }
        }

        /// <summary>
        /// This method allows you to manage a list of values for each specified key in a Dictionary.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, List{string}}</c> to which this method is exposed.</param>
        /// <param name="item">The key to update if present, or to add if not present.</param>
        /// <param name="value">the value to add.</param>
        /// <remarks>
        /// This is useful if you want to maintain a collection of one or more string values for each unique string key in the Dictionary.
        /// For instance, you may want to maintain a list of Make and Model for cars. The Keys would be the Make (such as Ford, Chrysler, GM)
        /// and the Values would be lists of models, such as F150, Mustang, Explorer, etc. for the Ford key.
        /// NOTE: This routine does NOT check for duplicate entries in the values list.
        /// </remarks>
        public static void AddOrUpdateItems(this Dictionary<string, List<string>> source, string item, string value)
        {
            if (source.ContainsKey(item))
            {
                source[item].Add(value);
            }
            else
            {
                source.Add(item, new List<string>());
                source[item].Add(value);
            }
        }

        /// <summary>
        /// This method allows you to manage a <c>Dictionary{string,int}</c> that stores a list of strings and a quantity that 
        /// indicates how many times each string has been found, counted, added, etc.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, int}</c> to which this method is exposed.</param>
        /// <param name="item">The string to either add or update the count.</param>
        public static void AddOrUpdateCount(this Dictionary<string, int> source, string item)
        {
            if (source.ContainsKey(item))
            {
                source[item]++;
            }
            else
            {
                source.Add(item, 1);
            }
        }

        /// <summary>
        /// This method converts all of the Key-Value-Pair entries into a single string,
        /// using the provided separators between the entries.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, string}</c> to which this method is exposed.</param>
        /// <param name="entrySeparator">the separator value to use between each KVP entry.
        /// The default value is '\r\n'</param>
        /// <param name="kvpSeparator">the separator value to use between the key and value of each entry.
        /// The default value is '='</param>
        /// <returns></returns>
        public static string AsString(this Dictionary<string, string> source, string entrySeparator = "\r\n", string kvpSeparator = "=")
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in source)
            {
                sb.Append($"{item.Key}{kvpSeparator}{item.Value}{entrySeparator}");
            }
            sb.Remove((sb.Length - entrySeparator.Length), entrySeparator.Length);
            return sb.ToString();
        }

        #region -- Get Dictionary Keys and Values by index -----
        /// <summary>
        /// Retrieves the string value for the Key from the dictionary which is stored at the specified <paramref name="iIndex"/>.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, IEnumerable{string}}</c> to which this method is exposed.</param>
        /// <param name="iIndex">The zero-based integer representing the index of the entry to use.</param>
        /// <returns>A string representing the KEY for the item.</returns>
        /// <remarks>
        /// Useful when generating nested lists and objects where the keys are based on sequential ids.
        /// For instance, parsing Tree View items via 'SelectedItemChanged' and getting the associated 
        /// property name and value. Consider the following code snippet:
        /// <code>
        ///     WTI_Request parent = GetParentRequest(tvi);
        ///     int x = Int32.Parse(tvi.Name.Substring(TVI_Name_Headers.Length));
        ///     Dictionary{string, object} props = new Dictionary{string, object}();
        ///     props.Add("Header Name", parent.Headers.GetKey(x));
        ///     props.Add("Header Value", parent.Headers.GetValue(x));
        /// </code>
        /// <list type="bullet">
        /// <item>Line 1 gets a WTI_Request object. That object contains a dictionary of request headers.</item>
        /// <item>When adding items to the treeview, they are named by using a constant value with an index appended to the end (in this case <c>TVI_Name_Headers</c>). Line 2 retrieves the appended index and converts it to an integer.</item>
        /// <item>Line 3 Creates a new Dictionary that will hold the Key and Value from the request's selected header.</item>
        /// <item>Line 4 gets the key by calling <c>parent.Headers.GetKey(x)</c>.</item>
        /// <item>Line 5 gets the value by calling <c>parent.Headers.GetValue(x)</c>.</item>
        /// </list>
        /// </remarks>
        public static string GetKey(this Dictionary<string, IEnumerable<string>> source, int iIndex)
        {
            int x = 0;
            if (source.Count <= iIndex)
                return string.Empty;

            foreach (var item in source)
            {
                if (iIndex == x)
                    return item.Key;
                x++;
            }
            return string.Empty;
        }

        /// <summary>
        /// Retrieves the IEnumerable value from the dictionary which is stored at the specified <paramref name="iIndex"/>.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, IEnumerable{string}}</c> to which this method is exposed.</param>
        /// <param name="iIndex">The zero-based integer representing the index of the entry to use.</param>
        /// <returns>A string representing the concatenated values for the item, using a semicolon as the separator.</returns>
        public static string GetValue(this Dictionary<string, IEnumerable<string>> source, int iIndex)
        {
            int x = 0;
            if (source.Count <= iIndex)
                return string.Empty;

            foreach (var item in source)
            {
                if (iIndex == x)
                    return item.Value.ToString(";");
                x++;
            }
            return string.Empty;
        }

        /// <summary>
        /// Retrieves the string value for the Key from the dictionary which is stored at the specified <paramref name="iIndex"/>.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, string}</c> to which this method is exposed.</param>
        /// <param name="iIndex">The zero-based integer representing the index of the entry to use.</param>
        /// <returns>A string representing the KEY for the item.</returns>
        public static string GetKey(this Dictionary<string, string> source, int iIndex)
        {
            int x = 0;
            if (source.Count <= iIndex)
                return string.Empty;

            foreach (var item in source)
            {
                if (iIndex == x)
                    return item.Key;
                x++;
            }
            return string.Empty;
        }

        /// <summary>
        /// Retrieves the string value from the dictionary which is stored at the specified <paramref name="iIndex"/>.
        /// </summary>
        /// <param name="source">The <c>Dictionary{string, string}</c> to which this method is exposed.</param>
        /// <param name="iIndex">The zero-based integer representing the index of the entry to use.</param>
        /// <returns>An IEnumerable representing the VALUE for the item.</returns>
        public static string GetValue(this Dictionary<string, string> source, int iIndex)
        {
            int x = 0;
            if (source.Count <= iIndex)
                return string.Empty;

            foreach (var item in source)
            {
                if (iIndex == x)
                    return item.Value;
                x++;
            }
            return string.Empty;
        }
        #endregion
    }
}
