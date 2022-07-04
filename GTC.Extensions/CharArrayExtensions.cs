using System.Text;

namespace GTC.Extensions
{
    public static class CharArrayExtensions
    {
        /// <summary>
        /// Looks through the array to see if the <paramref name="charToLookFor"/> character
        /// exists within the array.
        /// </summary>
        /// <param name="array">the char array to which this extension method is exposed. </param>
        /// <param name="charToLookFor"></param>
        /// <returns><b>True</b> if the character is found, <b>False</b> if not.</returns>
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
        /// Creates a string that contains the ASCII representations of all the characters in the <paramref name="array"/>.
        /// </summary>
        /// <param name="array">the char array to which this extension method is exposed. </param>
        /// <returns>a string representation of the characters in the array.</returns>
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
