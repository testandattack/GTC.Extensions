using System.Collections.Generic;

namespace GTC.Extensions
{
    public static class DictionaryExtensions
    {
        public static void AddSafely(this Dictionary<string, string> source, string sKey, string sValue)
        {
            if (source.ContainsKey(sKey))
                return;
            source.Add(sKey, sValue);
        }

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


        // Useful when generating nested lists and objects where the keys are based on sequential ids
        #region -- Get Dictionary Keys and Values by index -----
        // Need to test and validate
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

        // Need to test and validate
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

        // Need to test and validate
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

        // Need to test and validate
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
