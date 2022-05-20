using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTC.Extensions
{
    /// <summary>
    /// Extension class for <see cref="IEnumerable{T}"/> objects that exposes methods for modifying data and retrieving subsets of data.
    /// </summary>
    public static class ListExtensions
    {
        #region -- String-List to String methods -----
        /// <summary>
        /// Creates a single string from a list of strings, using the defined separator
        /// </summary>
        /// <param name="source">The <see cref="List{String}"/> to which this method is exposed.</param>
        /// <param name="separator">The character or string to place between each entry.</param>
        /// <returns>a string.</returns>
        public static string ToString(this List<string> source, string separator)
        {
            return String.Join($"{separator}", source.ToArray());
        }

        /// <summary>
        /// Creates a single string from a list of strings, using the defined separator
        /// </summary>
        /// <param name="source">The <see cref="List{String}"/> to which this method is exposed.</param>
        /// <param name="separator">The character or string to place between each entry.</param>
        /// <param name="AddSpace">If true, then a space is added after each separator. This makes the final string more human readable.</param>
        /// <returns>a string.</returns>
        public static string ToString(this List<string> source, string separator, bool AddSpace)
        {
            if(AddSpace)
                return String.Join($"{separator} ", source.ToArray());
            else
                return String.Join($"{separator}", source.ToArray());
        }
        #endregion

        #region -- int-List to String methods -----
        /// <summary>
        /// Creates a single string from a list of integers, using the defined separator
        /// </summary>
        /// <param name="source">The <see cref="List{Int32}"/> to which this method is exposed.</param>
        /// <param name="separator">The character or string to place between each entry.</param>
        /// <returns>a string.</returns>
        public static string ToString(this List<int> source, string separator)
        {
            return String.Join($"{separator}", source.ToArray());
        }

        /// <summary>
        /// Creates a single string from a list of integers, using the defined separator
        /// </summary>
        /// <param name="source">The <see cref="List{Int32}"/> to which this method is exposed.</param>
        /// <param name="separator">The character or string to place between each entry.</param>
        /// <param name="AddSpace">If true, then a space is added after each separator. This makes the final string more human readable.</param>
        /// <returns>a string.</returns>
        public static string ToString(this List<int> source, string separator, bool AddSpace)
        {
            if (AddSpace)
                return String.Join($"{separator} ", source.ToArray());
            else
                return String.Join($"{separator}", source.ToArray());
        }
        #endregion

        #region -- string-IEnumerable to String methods -----
        /// <summary>
        /// Creates a single string from a list of strings, using the defined separator
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{String}"/> to which this method is exposed.</param>
        /// <param name="separator">The character or string to place between each entry.</param>
        /// <returns>a string.</returns>
        public static string ToString(this IEnumerable<string> source, string separator)
        {
            return String.Join($"{separator}", source.ToArray());
        }

        /// <summary>
        /// Creates a single string from a list of strings, using the defined separator
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{String}"/> to which this method is exposed.</param>
        /// <param name="separator">The character or string to place between each entry.</param>
        /// <param name="AddSpace">If true, then a space is added after each separator. This makes the final string more human readable.</param>
        /// <returns>a string.</returns>
        public static string ToString(this IEnumerable<string> source, string separator, bool AddSpace)
        {
            if (AddSpace)
                return String.Join($"{separator} ", source.ToArray());
            else
                return String.Join($"{separator}", source.ToArray());
        }
        #endregion

        #region -- int-IEnumerable to String methods -----
        /// <summary>
        /// Creates a single string from a list of integers, using the defined separator
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{Int32}"/> to which this method is exposed.</param>
        /// <param name="separator">The character or string to place between each entry.</param>
        /// <returns>a string.</returns>
        public static string ToString(this IEnumerable<int> source, string separator)
        {
            return String.Join($"{separator}", source.ToArray());
        }

        /// <summary>
        /// Creates a single string from a list of integers, using the defined separator
        /// </summary>
        /// <param name="source">The <see cref="IEnumerable{Int32}"/> to which this method is exposed.</param>
        /// <param name="separator">The character or string to place between each entry.</param>
        /// <param name="AddSpace">If true, then a space is added after each separator. This makes the final string more human readable.</param>
        /// <returns>a string.</returns>
        public static string ToString(this IEnumerable<int> source, string separator, bool AddSpace)
        {
            if (AddSpace)
                return String.Join($"{separator} ", source.ToArray());
            else
                return String.Join($"{separator}", source.ToArray());
        }
        #endregion


        #region -- CSV Stuff -----
        /// <summary>
        /// This method reads an array of string items and converts them into a single string.
        /// </summary>
        /// <param name="items">The <c>string[]</c> array to which this method is exposed.</param>
        /// <returns>a string</returns>
        /// <remarks>
        /// This method accounts for strings that have commas within the string by surrounding the string with
        /// quotes, thus making the final CSV output accurate per standard parsing techniques.
        /// </remarks>
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

        /// <summary>
        /// This method reads a list of string items and converts them into a single string.
        /// </summary>
        /// <param name="items">The <see cref="List{String}"/> to which this method is exposed.</param>
        /// <returns>a string</returns>
        /// <remarks>
        /// This method accounts for strings that have commas within the string by surrounding the string with
        /// quotes, thus making the final CSV output accurate per standard parsing techniques.
        /// </remarks>
        public static string JoinAsCsv(this List<string> items)
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < items.Count; x++)
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
        #endregion

        /// <summary>
        /// This method provides a simple way to add items to a string list without having any
        /// duplicate values. 
        /// </summary>
        /// <param name="source">The <see cref="List{String}"/> to which this method is exposed.</param>
        /// <param name="itemToAdd">The item to be added to the <paramref name="source"/> if it is not already in that list.</param>
        /// <returns>True if the item was added, False if the item was already present and therefore not added.</returns>
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

        /// <summary>
        /// This method performs an "Exclusive OR" operation on two lists, returning only those items
        /// that show up in a single list.
        /// </summary>
        /// <param name="source">The <see cref="List{String}"/> to which this method is exposed.</param>
        /// <param name="secondList">The second <see cref="List{String}"/> that will be compared against the <paramref name="source"/> list.</param>
        /// <returns>a new <see cref="List{String}"/> with the rtesults.</returns>
        /// <remarks>
        /// If list1 contains <c>"one", "two", "three", "four"</c> and list2 contains <c>"two", "four", "six"</c>
        /// then the returned list will contain <c>"one", "three", "six"</c>.
        /// </remarks>
        public static List<string> XOR(this List<string> source, List<string> secondList)
        {
            return source.Except(secondList).Concat(secondList.Except(source)).ToList();
        }
    }
}
