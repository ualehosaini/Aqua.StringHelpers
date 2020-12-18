using System.Collections.Generic;
using Xunit;

namespace Aqua.StringHelpers.Tests
{
    public class StringHelpersTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData(null, true)]
        [InlineData("lorem ipsum dolor", false)]
        public void InNullOrEmpty_Valid(string input,
                                        bool expected) => Assert.Equal(expected, input.IsNullOrEmpty());

        [Theory]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData(null, true)]
        [InlineData("lorem ipsum dolor", false)]
        public void InNullOrWhiteSpace_Valid(string input,
                                             bool expected) => Assert.Equal(expected, input.IsNullOrWhiteSpace());

        [Theory]
        [InlineData("ABC123", true)]
        [InlineData("abcDEF1234", true)]
        [InlineData("jdshj+03-98>22", false)]
        [InlineData("43434bdcd333 ", false)]
        public void IsAlphaNumeric_Valid(string input,
                                         bool expected) => Assert.Equal(expected, input.IsAlphaNumeric());

        [Theory]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("http://testtest.com", true)]
        [InlineData("https://testtest.com/test", true)]
        public void IsValidURL_Valid(
            string input,
            bool expected) => Assert.Equal(expected, input.IsValidURL());

        [Theory]
        [InlineData("1.5", true)]
        [InlineData("rr", false)]
        [InlineData(null, false)]
        [InlineData("22se2", false)]
        public void InNumber_Valid(string input,
                                   bool expected) => Assert.Equal(expected, input.IsNumber());

        [Theory]
        [InlineData("1", true)]
        [InlineData("rr", false)]
        [InlineData(null, false)]
        [InlineData("22se2", false)]
        public void InInteger_Valid(
            string input,
            bool expected) => Assert.Equal(expected, input.IsInteger());

        [Theory]
        [InlineData(' ', false)]
        [InlineData('5', true)]
        [InlineData('B', false)]
        public void IsDigit_Valid(char input,
                                  bool expected) => Assert.Equal(expected, input.IsDigit());

        [Theory]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("ABC123", "321CBA")]
        [InlineData("12345+", "+54321")]
        public void Reverse_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.Reverse());

        [Theory]
        [InlineData("ABC123", "ABC123")]
        [InlineData("12345+", "11+54321")]
        public void Reverse_InValid(string input,
                                    string expected) => Assert.NotEqual(expected, input.Reverse());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem     ipsum dolor    ", "lorem ipsum dolor")]
        [InlineData("  lorem     ipsum   dolor", "lorem ipsum dolor")]
        public void RemoveExtraSpaces_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.RemoveExtraSpaces());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem      ipsum dolor ", "lorem ipsum dolor")]
        [InlineData("       lorem       ipsum       dolor", "lorem ipsum dolor")]
        public void ReplaceTabsWithSpaces_Valid(string input,
                                                string expected) => Assert.Equal(expected, input.RemoveExtraSpaces());

        [Theory]
        [InlineData("lorem      ipsum   dolor", "lorem      ipsum   dolor")]
        [InlineData("   lorem      ipsum   dolor", "abcd lorem      ipsum   dolor")]
        public void ReplaceTabsWithSpaces_InValid(
            string input,
            string expected) => Assert.NotEqual(expected, input.RemoveExtraSpaces());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem\nipsum dolor", "lorem ipsum dolor")]
        [InlineData("lorem\nipsum dolor\n", "lorem ipsum dolor")]
        public void ReplaceNewLinesWithSpaces_Valid(string input,
                                                    string expected) => Assert.Equal(expected, input.RemoveExtraSpaces());

        [Theory]
        [InlineData("lorem\nipsum dolor\n", "lorem\ripsum dolor\r")]
        public void ReplaceNewLinesWithSpaces_InValid(
            string input,
            string expected) => Assert.NotEqual(expected, input.RemoveExtraSpaces());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("   lorem\nipsum  dolor\n  ", "lorem ipsum dolor")]
        [InlineData("\tlorem\nipsum    dolor\n     ", "lorem ipsum dolor")]
        public void ToCleanString_Valid(string input,
                                        string expected) => Assert.Equal(expected, input.RemoveExtraSpaces());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("http://testte333333st.com", "httptestte333333stcom")]
        public void ToAlphaNumericString_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.ToAlphaNumericString());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum. dolor lorem", "LID")]
        [InlineData("\tlorem\nipsum.    dolor\n     ", "LID")]
        public void ToNcharAbbreviation_Valid(string input,
                                              string expected) => Assert.Equal(expected, input.ToNcharAbbreviation(3));

        [Theory]
        [MemberData(nameof(ToDistinctListOfWordsData))]
        public void ToDistinctListOfWords_Valid(
            string input,
            List<string> expected) => Assert.Equal(expected, input.ToDistinctListOfWords());

        /// <summary>
        /// Data for ToNcharAbbreviation_Valid  
        /// </summary>
        public static IEnumerable<object[]> ToDistinctListOfWordsData =>
            new List<object[]>
                {
                    new object[]{"", new List<string>()},
                    new object[]{" ", new List<string>()},
                    new object[]{null, new List<string>()},
                    new object[]{ "lorem ipsum dolor lorem", new List<string> { "dolor", "ipsum", "lorem" } }
                };

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("https://testest.com", "<a href=\"https://testest.com\" target=\"_blank\">https://testest.com</a>")]
        [InlineData("http://testest.com/test/test", "<a href=\"http://testest.com/test/test\" target=\"_blank\">http://testest.com/test/test</a>")]
        public void ToHyperlink_Valid(string input,
                                      string expected) => Assert.Equal(expected, input.ToHyperlink());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum. dolor lorem", "LIDL")]
        [InlineData("\tlorem\nipsum.    dolor\n     ", "LID")]
        public void ToAbbreviation_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.ToAbbreviation());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum. dolor", "Lorem ipsum. Dolor.")]
        [InlineData("\tlorem\nipsum.    dolor\n     ", "Lorem ipsum. Dolor.")]
        public void ToSentenceCase_Valid(string input,
                                         string expected) => Assert.Equal(expected, input.ToSentenceCase('.'));

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("12345", "MTIzNDU=")]
        public void ToBase64_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.ToBase64());

        [Theory]
        [InlineData("07777777777", "07777 777777")]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        public void ToUkTelephoneFormat_Valid(string input,
                                              string expected) => Assert.Equal(expected, input.ToUkTelephoneFormat());

        [Theory]
        [InlineData(null, 6, true, null)]
        [InlineData("", 6, true, "")]
        [InlineData("qwertyuiop[asdfghjkkll", 6, true, "qwerty...")]
        public void ToSummarisedText_Valid(
            string input,
            int length,
            bool dots,
            string expected) => Assert.Equal(expected, input.ToSummarisedText(length, dots));

        [Theory]
        [InlineData(null, 6, null)]
        [InlineData("", 6, "")]
        [InlineData("qwertyuiop[asdfghjkkll", 6, "hjkkll")]
        public void ToSummarisedTextRight_Valid(string input,
                                                int length,
                                                string expected) => Assert.Equal(expected, input.ToSummarisedTextRight(length));

        [Theory]
        [InlineData("1dfdfdfd^^^$$f5", "\"1dfdfdfd^^^$$f5\"")]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        public void ToDoubleQuotedString_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.ToDoubleQuotedString());

        [Theory]
        [MemberData(nameof(ToStringArrayFromDelimitedStringData))]
        public void ToStringArrayFromDelimitedString_Valid(string input, string[] expected) => Assert.Equal(expected, input.ToStringArrayFromDelimitedString(','));

        /// <summary>
        /// Data for ToStringArrayFromDelimitedString_Valid
        /// </summary>
        public static IEnumerable<object[]> ToStringArrayFromDelimitedStringData =>
            new List<object[]>
                {
                    new object[]{"", new string[0]},
                    new object[]{" ", new string[0]},
                    new object[]{null, new string[0]},
                    new object[]{ "lorem, ipsum, dolor, lorem", new string[] { "lorem", " ipsum", " dolor", " lorem" } }
                };

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("c:\\abcq\\abcd.txt", "cabcqabcdtxt")]
        [InlineData("http://testte333333st.com/test.pdf", "httptestte333333stcomtestpdf")]
        public void ToUrlFriendly_Valid(string input,
                                        string expected) => Assert.Equal(expected, input.ToUrlFriendly());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum dolor", "Lorem Ipsum Dolor")]
        [InlineData("\tlorem\nipsum    dolor\n     ", "\tLorem\nIpsum    Dolor\n     ")]
        public void CapitaliseEachWord_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.CapitaliseEachWord());

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        [InlineData(null, 0)]
        [InlineData("lorem ipsum. dolor", 18)]
        [InlineData("\tlorem\nipsum.    dolor\n     ", 28)]
        public void GetTotalNumberOfCharachters_Valid(
            string input,
            int expected) => Assert.Equal(expected, input.GetTotalNumberOfCharachters());

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        [InlineData("lorem ipsum. dolor", 3)]
        [InlineData("\tlorem\nipsum.    dolor\n     ", 3)]
        public void GetTotalNumberOfWords_Valid(
            string input,
            int expected) => Assert.Equal(expected, input.GetTotalNumberOfWords());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum. dolor lorem", "ipsum.")]
        [InlineData("\tlorem\nipsum    dolor\n     ", "lorem")]
        public void GetFirstLongestWord_Valid(string input,
            string expected) => Assert.Equal(expected, input.GetFirstLongestWord());

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        [InlineData("lorem ipsum. dolor", 1)]
        [InlineData("\tlorem\nipsum.    dolor\n     ", 3)]
        public void GetTotalNumberOfLines_Valid(
            string input,
            int expected) => Assert.Equal(expected, input.GetTotalNumberOfLines());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lor ipsum. dol lorem", "lor")]
        [InlineData("\tlorem\nipsum    dol\n     ", "dol")]
        public void GetFirstShortestWord_Valid(string input,
            string expected) => Assert.Equal(expected, input.GetFirstShortestWord());

        [Theory]
        [InlineData("", "lorem", true, 0)]
        [InlineData(" ", "lorem", true, 0)]
        [InlineData(null, "lorem", true, 0)]
        [InlineData("lorem ipsum. dolor lorem", "lorem", true, 2)]
        [InlineData("loREM ipsum. dolor loREm", "LOrem", false, 2)]
        [InlineData("\tlorem\nipsum    dolor\n   lorem lorem  ", "lorem lorem", true, 1)]
        public void CountStringOccurrences_Valid(
            string input,
            string pattern,
            bool isCaseSensitive,
            int expected) => Assert.Equal(expected, input.CountStringOccurrences(pattern, isCaseSensitive));

        [Theory]
        [InlineData(null, 3, null)]
        [InlineData("", 3, "")]
        [InlineData("abcdefgh", 3, "defgh")]
        public void RemoveNumberOfCharsAtBegining_Valid(string input,
            int n,
            string expected) => Assert.Equal(expected, input.RemoveNumberOfCharsAtBegining(n));

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("abcd\nefgh\n", "abcdefgh")]
        public void RemoveAllLineBreaks_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.RemoveAllLineBreaks());

        [Theory]
        [InlineData(null, "")]
        public void IfNullReturnEmptyString_Valid(string input,
            string expected) => Assert.Equal(expected, input.IfNullReturnEmptyString());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("http://testtest.com", "http://testtest.com")]
        [InlineData("https://testtest.com/test", "https://testtest.com")]
        public void GetUrlDomain_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.GetUrlDomain());

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("c:\\abcq\\abcd.txt", "txt")]
        [InlineData("http://testte333333st.com/test.pdf", "pdf")]
        public void GetFileExtension_Valid(string input,
            string expected) => Assert.Equal(expected, input.GetFileExtension());

        [Theory]
        [InlineData(null, '.', 0)]
        [InlineData("", '.', 0)]
        [InlineData(" ", '.', 0)]
        [InlineData("1.5", '.', 1)]
        [InlineData("rr", 'r', 2)]
        [InlineData("22se2", '2', 3)]
        public void HowManyOccurrences_Char_Valid(
            string input,
            char c,
            int expected) => Assert.Equal(expected, input.HowManyOccurrences(c));

        [Theory]
        [InlineData(null, ".", 0)]
        [InlineData("", ".", 0)]
        [InlineData(" ", ".", 0)]
        [InlineData("1.5", ".", 1)]
        [InlineData("rr", "r", 2)]
        [InlineData("22se2", "22", 1)]
        public void HowManyOccurrences_String_Valid(string input,
            string c,
            int expected) => Assert.Equal(expected, input.HowManyOccurrences(c));

        [Theory]
        [InlineData(null, "..", "..")]
        [InlineData("", "--", "--")]
        [InlineData("abcd", "..", "..abcd")]
        public void AddToBeginingIfMissed_Valid(
            string input,
            string value,
            string expected) => Assert.Equal(expected, input.AddToBeginingIfMissed(value));

        [Theory]
        [InlineData("1.5", "15")]
        [InlineData("rr", "")]
        [InlineData(null, null)]
        [InlineData("22se2", "222")]
        public void FindAllDigits_Valid(string input,
            string expected) => Assert.Equal(expected, input.FindAllDigits());

        [Theory]
        [InlineData("1dfdfdfd^^^$$f5", "15")]
        [InlineData("rr222", "222")]
        [InlineData(null, null)]
        [InlineData("22se2", "222")]
        public void CleanNonNumericChars_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.CleanNonNumericChars());

        [Theory]
        [InlineData("1.5", 2)]
        [InlineData("rr", 0)]
        [InlineData(null, 0)]
        [InlineData("22se2", 3)]
        public void FindNumberOfDigits_Valid(string input,
            int expected) => Assert.Equal(expected, input.FindNumberOfDigits());

        [Theory]
        [InlineData(null, 1, null)]
        [InlineData("", 1, "")]
        [InlineData(" ", 1, " ")]
        [InlineData("abcd", 20, "        abcd        ")]
        [InlineData("abcd", 3, "abcd")]
        public void CenterAligned_Valid(
            string input,
            int length,
            string expected) => Assert.Equal(expected, input.CenterAligned(length));

        [Theory]
        [InlineData("abcdभारतxyz", 'G', "abcdGGGGxyz")]
        [InlineData(null, 'a', null)]
        [InlineData("", 'a', "")]
        public void ReplaceNonASCIICharsWith_Valid(string input,
            char c,
            string expected) => Assert.Equal(expected, input.ReplaceNonASCIICharsWith(c));

        [Theory]
        [InlineData("abcdeefghijklmnopq", "ghijk", "AAAA", "abcdeefAAAAlmnopq")]
        [InlineData(null, "dd", "cc", null)]
        [InlineData("", "aa", "dd", "")]
        public void ReplaceFirstOccurrence_Valid(
            string input,
            string search,
            string replace,
            string expected) => Assert.Equal(expected, input.ReplaceFirstOccurrence(search, replace));

        [Theory]
        [InlineData("abcd", 20, "                abcd")]
        [InlineData("abcd", 19, "               abcd")]
        [InlineData("abcd", 3, "abcd")]
        public void RightAligned_Valid(string input,
            int length,
            string expected) => Assert.Equal(expected, input.RightAligned(length));

        [Theory]
        [InlineData("abcdभारतxyz", "abcdxyz")]
        [InlineData(null, null)]
        [InlineData("", "")]
        public void RemoveNonASCIIChars_Valid(
            string input,
            string expected) => Assert.Equal(expected, input.RemoveNonASCIIChars());

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("qwertyuiop\"\"[asdfghjkkll", "qwertyuiop''[asdfghjkkll")]
        public void ReplaceDoubleQuotesWithSingle_Valid(string input,
            string expected) => Assert.Equal(expected, input.ReplaceDoubleQuotesWithSingle());

        [Theory]
        [InlineData(null, null, null)]
        [InlineData("", "", null)]
        [InlineData("abcd", "abcd", null)]
        public void NullIfEqualTo_Valid(string input, string search, string expected) => Assert.Equal(expected, input.NullIfEqualTo(search));

        [Theory]
        [InlineData(null, "..", "..")]
        [InlineData("", "--", "--")]
        [InlineData("abcd", "..", "abcd..")]
        public void AddToEndIfMissed_Valid(string input, string value, string expected) => Assert.Equal(expected, input.AddToEndIfMissed(value));

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("qwertyuiop''[asdfghjkkll", "qwertyuiop\"\"[asdfghjkkll")]
        public void ReplaceSingleQuotesWithDouble_Valid(string input, string expected) => Assert.Equal(expected, input.ReplaceSingleQuotesWithDouble());

        [Theory]
        [InlineData(null, 3, null)]
        [InlineData("", 3, "")]
        [InlineData("abcdefgh", 3, "abcde")]
        public void RemoveNumberOfCharsAtEnd_Valid(string input, int n, string expected) => Assert.Equal(expected, input.RemoveNumberOfCharsAtEnd(n));

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("MTIzNDU=", "12345")]
        public void DecodeBase64_Valid(string input, string expected) => Assert.Equal(expected, input.DecodeBase64());
    }
}
