using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        /// Is the URL string is valid?
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValidURL(this string s)
        {
            if (s.IsNullOrEmpty())
                return false;

            if (s.IsNullOrWhiteSpace())
                return false;

            return Uri.TryCreate(s, UriKind.RelativeOrAbsolute, out Uri uriResult);
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
        /// Remove all charachters rather than letters and numbers
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToAlphaNumericString(this string s)
        {
            if (s.IsNullOrEmpty())
                return s;

            // Use regular expressions to replace characters
            // that are not letters or numbers with spaces.
            Regex reg_exp = new Regex("[^a-zA-Z0-9]");
            return reg_exp.Replace(s, string.Empty).ToCleanString();

        }

        /// <summary>
        /// Convert string to HTML format (Replacing \n with equivelent HTML Tag)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToHtml(this string s)
        {
            if (s.IsNullOrEmpty())
                return s;

            s = Regex.Replace(s, @"\n\r?", "<br/>");

            return s.ToHyperlink();
        }

        /// <summary>
        /// To N Number of Charachters Abbreviation
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string ToNcharAbbreviation(this string s, int n)
        {
            if (s.IsNullOrWhiteSpace())
            {
                return s;
            }

            int numberOfWords = s.GetTotalNumberOfWords();

            int abbreviationLength = numberOfWords >= n ? n : numberOfWords;

            string result = string.Empty;

            string[] words = s.ToCleanString().Split(' ');

            for (int i = 0; i < abbreviationLength; i++)
            {
                result += char.ToUpper(words[i][0]);
            }

            return result;
        }


        /// <summary>
        /// Return List of distinct words of a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static List<string> ToDistinctListOfWords(this string s)
        {
            if (s.IsNullOrWhiteSpace())
                return new List<string>();

            // Use regular expressions to replace characters
            // that are not letters or numbers with spaces.
            Regex reg_exp = new Regex("[^a-zA-Z0-9]");
            s = reg_exp.Replace(s, " ");

            // Split the text into words.
            string[] words = s.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var word_query =
                (from string word in words
                 orderby word
                 select word).Distinct();

            return word_query.ToList();

        }

        /// <summary>
        /// Convert string to Hyperlink
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToHyperlink(this string s)
        {
            if (s.IsNullOrEmpty())
                return s;

            if (s.IsNullOrWhiteSpace())
                return string.Empty;

            Regex r = new Regex("(https?://[^ ]+)");

            return r.Replace(s, "<a href=\"$1\" target=\"_blank\">$1</a>");
        }

        /// <summary>
        /// To Abbreviation
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToAbbreviation(this string s)
        {
            if (s.IsNullOrWhiteSpace())
            {
                return s;
            }

            string result = string.Empty;

            string[] words = s.ToCleanString().Split(' ');

            foreach (string word in words)
            {
                result += char.ToUpper(word[0]);
            }

            return result;
        }

        /// <summary>
        /// Returns Sentence Case of a text
        /// </summary>
        /// <param name="s"></param>
        /// <param name="seperator"></param>
        /// <returns></returns>
        public static string ToSentenceCase(this string s, char seperator)
        {
            if (s.IsNullOrEmpty())
                return s;

            s = s.Trim().ToCleanString();
            if (s.IsNullOrEmpty())
                return s;

            // Only 1 seperator
            if (s.IndexOf(seperator) < 0)
            {
                s = s.ToLower();
                s = s[0].ToString().ToUpper() + s.Substring(1);
                return s;
            }

            if (s.Trim().Last() == seperator)
            {
                s.Trim().Remove(s.Length - 1, 1);
            }

            // More than 1 seperator.
            string[] sentences = s.Split(seperator);
            StringBuilder buffer = new StringBuilder();

            foreach (string sentence in sentences)
            {
                string currentSentence = sentence.ToLower().Trim();
                if (!string.IsNullOrWhiteSpace(currentSentence))
                {
                    currentSentence = currentSentence[0].ToString().ToUpper() + currentSentence.Substring(1);
                    buffer.Append(currentSentence + seperator + ' ');
                }
            }

            s = buffer.ToString();
            return s.Trim();
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

        /// <summary>
        /// Finds the number of charachters in a string - include/exclude extra spaces, tabs and new line characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetTotalNumberOfCharachters(this string s, bool clean = false)
        {
            if (s.IsNullOrEmpty())
                return 0;

            return clean != true ? s.Length : s.ToCleanString().Length;
        }


        /// <summary>
        /// Finds the number of words in a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetTotalNumberOfWords(this string s)
        {
            if (s.IsNullOrWhiteSpace())
                return 0;

            int result = 1;

            s = s.ToCleanString();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == ' ')
                {
                    result++;
                }
            }

            return result;
        }



        /// <summary>
        /// Get The Longest Word in a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetFirstLongestWord(this string s)
        {
            if (s.IsNullOrWhiteSpace())
                return s;

            return s.ToCleanString()
                    .Split(' ')
                    .OrderByDescending(word => word.Length)
                    .First();
        }




        /// <summary>
        /// Finds the number of lines in a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetTotalNumberOfLines(this string s)
        {
            if (s.IsNullOrWhiteSpace())
                return 0;

            int result = 1;

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == '\n')
                {
                    result++;
                }
            }

            return result;
        }



        /// <summary>
        /// Get The Shortest Word in a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetFirstShortestWord(this string s)
        {
            if (s.IsNullOrWhiteSpace())
                return s;

            return s.ToCleanString()
                    .Split(' ')
                    .OrderBy(word => word.Length)
                    .First();
        }




        /// <summary>
        /// Counts the Occurrences of a pattern in a text, The default is Case Sensitive search
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="isCaseSensitive"></param>
        /// <returns></returns>
        public static int CountStringOccurrences(this string s, string pattern, bool isCaseSensitive = true)
        {
            if (s.IsNullOrEmpty())
                return 0;

            if (pattern.IsNullOrEmpty())
                return 0;

            if (isCaseSensitive != true)
            {
                s.ToLower();
                pattern.ToLower();
            }

            int count = 0;
            int i = 0;
            while ((i = s.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Remove specific number of chars from at the begining of text
        /// </summary>
        /// <param name="s">the text</param>
        /// <param name="n">the number of characters</param>
        /// <returns>resulted text</returns>
        public static string RemoveNumberOfCharsAtBegining(this string s, int n)
        {
            if (s.IsNullOrEmpty())
                return s;

            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            return s.Length < n ? string.Empty : s.Substring(n);
        }

        /// <summary>
        /// Remove All Line Breaks in a text
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveAllLineBreaks(this string s)
        {
            if (s.IsNullOrEmpty())
                return s;

            return s.Replace("\n", string.Empty).Replace("\r", string.Empty);
        }

        /// <summary>
        /// If the string is null convert it to empty
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string IfNullReturnEmptyString(this string s)
        {
            return s ?? string.Empty;
        }

        /// <summary>
        /// Get Domain Part of a valid URL string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetUrlDomain(this string s)
        {
            if (s.IsNullOrEmpty())
                return s;

            if (s.IsNullOrWhiteSpace())
                return string.Empty;

            var match = Regex.Match(s, @"^http[s]?[:/]+[^/]+");

            return match.Success ? match.Captures[0].Value : s;
        }

        /// <summary>
        /// Extract the file extension from a valid path string or returns empty string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetFileExtension(this string s)
        {
            if (s.IsNullOrEmpty())
                return s;

            int pos = s.LastIndexOf('.');

            if (pos < 0)
                return string.Empty;

            return s.Substring(pos + 1).Trim();
        }

        /// <summary>
        /// Get Domain Part of a valid URL
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static string GetUrlDomain(this Uri uri)
        {
            if (uri.ToString().IsNullOrEmpty())
                return uri.ToString();

            return uri.ToString().GetUrlDomain();
        }

        /// <summary>
        /// Extract String Array from Delimited String
        /// </summary>
        /// <param name="s"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string[] ToStringArrayFromDelimitedString(this string s, char delimiter)
        {
            if (s.IsNullOrEmpty())
                return new string[0];

            if (s.IsNullOrWhiteSpace())
                return new string[0];

            return s.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
