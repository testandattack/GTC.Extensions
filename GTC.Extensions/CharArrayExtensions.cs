using System.Text;

namespace GTC.Extensions
{
    public static class CharArrayExtensions
    {
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
