namespace Aqua.StringHelpers
{
    public static class StringHelpers
    {
        /// <summary>
        /// Is Null Or Empty String?
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>true/false</returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        /// <summary>
        /// Is Null Or White Space String?
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>true/false</returns>
        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

    }
}
