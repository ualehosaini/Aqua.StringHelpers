using System;
using System.Text.RegularExpressions;
using System.Threading;

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

        /// <summary>
        /// Is the string alphanumeric?
        /// </summary>
        /// <param name="s">text</param>
        /// <returns>true/false</returns>
        public static bool IsAlphaNumeric(this string s)
        {
            if (s.IsNullOrEmpty())
                return false;

            Regex reg_exp = new Regex("[^a-zA-Z0-9]", RegexOptions.Compiled);

            return !reg_exp.IsMatch(s); ;
        }

        /// <summary>
        /// Reverse the input string
        /// </summary>
        /// <param name="s">text</param>
        /// <returns>reversed text</returns>
        public static string Reverse(this string s)
        {
            if (s.IsNullOrEmpty())
            {
                return s;
            }

            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Remove Extra Spaces from the text
        /// </summary>
        /// <param name="s">text</param>
        /// <returns>clean text</returns>
        public static string RemoveExtraSpaces(this string s)
        {
            if (s.IsNullOrEmpty())
            {
                return s;
            }

            string pattern = "\\s+";
            string replacement = " ";

            Regex rx = new Regex(pattern);

            return rx.Replace(s, replacement).Trim();
        }

        /// <summary>
        /// Replace the Tabs with Spaces and remove the extra spaces
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReplaceTabsWithSpaces(this string s)
        {
            if (s.IsNullOrEmpty())
            {
                return s;
            }

            return s.Replace("\t", " ").RemoveExtraSpaces();
        }

        /// <summary>
        /// Replace the New Line Chars with Spaces and remove the extra spaces
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReplaceNewLinesWithSpaces(this string s)
        {
            if (s.IsNullOrEmpty())
            {
                return s;
            }

            return s.Replace("\n", " ").RemoveExtraSpaces();
        }

        /// <summary>
        /// Clean the text from the tabs, New Line Chars, and Extra Spaces
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToCleanString(this string s)
        {
            if (s.IsNullOrEmpty())
            {
                return s;
            }

            return s.Replace("\n", " ").Replace("\t", " ").RemoveExtraSpaces();
        }

        /// <summary>
        /// Capitalise Each Word
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string CapitaliseEachWord(this string s)
        {
            if (s.IsNullOrEmpty())
            {
                return s;
            }

            var x = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());

            return x;
        }

    }
}
