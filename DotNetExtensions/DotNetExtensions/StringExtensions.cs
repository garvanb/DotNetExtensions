using System.Linq;

namespace DotNetExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Just syntactic sugar for the string.IsNullOrEmpty method
        /// </summary>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Sets first character in a string to lowercase
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string LowerFirstChar(this string value)
        {
            if (value.IsNullOrEmpty()) { return value; }
            value = char.ToLowerInvariant(value[0]) + value.GetSafeSubstring(1);
            return value;
        }

        /// <summary>
        /// Returns a substring from the specified index.
        /// If the index does not exist it returns an empty string.
        /// </summary>
        public static string GetSafeSubstring(this string value, int index)
        {
            return new string((value ?? string.Empty).Skip(index).ToArray());
        }
    }
}
