using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTC.Extensions
{
    public static class ListExtensions
    {
        #region -- String-List to String methods -----
        public static string ToString(this List<string> source, string separator)
        {
            return String.Join($"{separator}", source.ToArray());
        }

        public static string ToString(this List<string> source, string separator, bool AddSpace)
        {
            if(AddSpace)
                return String.Join($"{separator} ", source.ToArray());
            else
                return String.Join($"{separator}", source.ToArray());
        }
        #endregion

        #region -- int-List to String methods -----
        public static string ToString(this List<int> source, string separator)
        {
            return String.Join($"{separator}", source.ToArray());
        }

        public static string ToString(this List<int> source, string separator, bool AddSpace)
        {
            if (AddSpace)
                return String.Join($"{separator} ", source.ToArray());
            else
                return String.Join($"{separator}", source.ToArray());
        }
        #endregion

        #region -- string-IEnumerable to String methods -----
        public static string ToString(this IEnumerable<string> source, string separator)
        {
            return String.Join($"{separator}", source.ToArray());
        }

        public static string ToString(this IEnumerable<string> source, string separator, bool AddSpace)
        {
            if (AddSpace)
                return String.Join($"{separator} ", source.ToArray());
            else
                return String.Join($"{separator}", source.ToArray());
        }
        #endregion

        #region -- int-IEnumerable to String methods -----
        public static string ToString(this IEnumerable<int> source, string separator)
        {
            return String.Join($"{separator}", source.ToArray());
        }

        public static string ToString(this IEnumerable<int> source, string separator, bool AddSpace)
        {
            if (AddSpace)
                return String.Join($"{separator} ", source.ToArray());
            else
                return String.Join($"{separator}", source.ToArray());
        }
        #endregion

        public static string JoinAsCsv(this string[] items)
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < items.Length; x++)
            {
                if (items[x].Contains(","))
                {
                    sb.Append($"\"{items[x]}\",");
                }
                else
                {
                    sb.Append($"{items[x]},");
                }
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public static bool AddUnique(this List<string> source, string itemToAdd)
        {
            if(source.Contains(itemToAdd))
            {
                return false;
            }
            else
            {
                source.Add(itemToAdd);
                return true;
            }
        }
       
        public static List<string> XOR(this List<string> source, List<string> secondList)
        {
            return source.Except(secondList).Concat(secondList.Except(source)).ToList();
        }
    }
}
