using System;
using System.Text;

namespace GTC.Extensions
{
    /// <summary>
    /// Extension class for <c>char[]</c> objects that exposes extra methods.
    /// </summary>
    public static class CharArrayExtensions
    {
        /// <summary>
        /// Searches the array for the specified character.
        /// </summary>
        /// <param name="array">The character array to which the method is exposed.</param>
        /// <param name="charToLookFor">The character to locate in the array.</param>
        /// <returns>True if the character is found, False if not.</returns>
        public static bool Contains(this char[] array, char charToLookFor)
        {
            for(int x = 0; x < array.Length; x++)
            {
                if(array[x] == charToLookFor)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Searches the array for the specified character, getting the index of the first instance of the character.
        /// </summary>
        /// <param name="array">The character array to which the method is exposed.</param>
        /// <param name="charToLookFor">The character to locate in the array.</param>
        /// <returns>the zero-based index of the character's location in the array, or -1 if the character is not found.</returns>
        public static int Location(this char[] array, char charToLookFor)
        {
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] == charToLookFor)
                {
                    return x;
                }
            }
            return -1;
        }

        /// <summary>
        /// Creates a string object from the character array. 
        /// </summary>
        /// <param name="array">The character array to which the method is exposed.</param>
        /// <returns>The created <see cref="String"/>.</returns>
        public static string AsString(this char[] array)
        {
            StringBuilder sb = new StringBuilder();
            for(int x = 0; x < array.Length; x++)
            {
                sb.Append(array[x]);
            }
            return sb.ToString();
        }
    }
}
