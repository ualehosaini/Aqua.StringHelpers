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
        public void InNullOrEmpty_Valid(string input, bool expected)
        {
            Assert.Equal(expected, input.IsNullOrEmpty());
        }

        [Theory]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData(null, true)]
        [InlineData("lorem ipsum dolor", false)]
        public void InNullOrWhiteSpace_Valid(string input, bool expected)
        {
            Assert.Equal(expected, input.IsNullOrWhiteSpace());
        }

        [Theory]
        [InlineData("ABC123", true)]
        [InlineData("abcDEF1234", true)]
        [InlineData("jdshj+03-98>22", false)]
        [InlineData("43434bdcd333 ", false)]
        public void IsAlphaNumeric_Valid(string input, bool expected)
        {
            Assert.Equal(expected, input.IsAlphaNumeric());
        }

        [Theory]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        [InlineData("http://testtest.com", true)]
        [InlineData("https://testtest.com/test", true)]
        public void IsValidURL_Valid(string input, bool expected)
        {
            Assert.Equal(expected, input.IsValidURL());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("ABC123", "321CBA")]
        [InlineData("12345+", "+54321")]
        public void Reverse_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.Reverse());
        }

        [Theory]
        [InlineData("ABC123", "ABC123")]
        [InlineData("12345+", "11+54321")]
        public void Reverse_InValid(string input, string expected)
        {
            Assert.NotEqual(expected, input.Reverse());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem     ipsum dolor    ", "lorem ipsum dolor")]
        [InlineData("  lorem     ipsum   dolor", "lorem ipsum dolor")]
        public void RemoveExtraSpaces_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.RemoveExtraSpaces());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem      ipsum dolor ", "lorem ipsum dolor")]
        [InlineData("       lorem       ipsum       dolor", "lorem ipsum dolor")]
        public void ReplaceTabsWithSpaces_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.RemoveExtraSpaces());
        }

        [Theory]
        [InlineData("lorem      ipsum   dolor", "lorem      ipsum   dolor")]
        [InlineData("   lorem      ipsum   dolor", "abcd lorem      ipsum   dolor")]
        public void ReplaceTabsWithSpaces_InValid(string input, string expected)
        {
            Assert.NotEqual(expected, input.RemoveExtraSpaces());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem\nipsum dolor", "lorem ipsum dolor")]
        [InlineData("lorem\nipsum dolor\n", "lorem ipsum dolor")]
        public void ReplaceNewLinesWithSpaces_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.RemoveExtraSpaces());
        }

        [Theory]
        [InlineData("lorem\nipsum dolor\n", "lorem\ripsum dolor\r")]
        public void ReplaceNewLinesWithSpaces_InValid(string input, string expected)
        {
            Assert.NotEqual(expected, input.RemoveExtraSpaces());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("   lorem\nipsum  dolor\n  ", "lorem ipsum dolor")]
        [InlineData("\tlorem\nipsum    dolor\n     ", "lorem ipsum dolor")]
        public void ToCleanString_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.RemoveExtraSpaces());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("http://testte333333st.com", "httptestte333333stcom")]
        public void ToAlphaNumericString_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.ToAlphaNumericString());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum. dolor lorem", "LID")]
        [InlineData("\tlorem\nipsum.    dolor\n     ", "LID")]
        public void ToNcharAbbreviation_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.ToNcharAbbreviation(3));
        }

        [Theory]
        [MemberData(nameof(ToDistinctListOfWordsData))]
        public void ToDistinctListOfWords_Valid(string input, List<string> expected)
        {
            Assert.Equal(expected, input.ToDistinctListOfWords());
        }

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
        public void ToHyperlink_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.ToHyperlink());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum. dolor lorem", "LIDL")]
        [InlineData("\tlorem\nipsum.    dolor\n     ", "LID")]
        public void ToAbbreviation_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.ToAbbreviation());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum. dolor", "Lorem ipsum. Dolor.")]
        [InlineData("\tlorem\nipsum.    dolor\n     ", "Lorem ipsum. Dolor.")]
        public void ToSentenceCase_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.ToSentenceCase('.'));
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum dolor", "Lorem Ipsum Dolor")]
        [InlineData("\tlorem\nipsum    dolor\n     ", "\tLorem\nIpsum    Dolor\n     ")]
        public void CapitaliseEachWord_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.CapitaliseEachWord());
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        [InlineData(null, 0)]
        [InlineData("lorem ipsum. dolor", 18)]
        [InlineData("\tlorem\nipsum.    dolor\n     ", 28)]
        public void GetTotalNumberOfCharachters_Valid(string input, int expected)
        {
            Assert.Equal(expected, input.GetTotalNumberOfCharachters());
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        [InlineData("lorem ipsum. dolor", 3)]
        [InlineData("\tlorem\nipsum.    dolor\n     ", 3)]
        public void GetTotalNumberOfWords_Valid(string input, int expected)
        {
            Assert.Equal(expected, input.GetTotalNumberOfWords());
        }


        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lorem ipsum. dolor lorem", "ipsum.")]
        [InlineData("\tlorem\nipsum    dolor\n     ", "lorem")]
        public void GetFirstLongestWord_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.GetFirstLongestWord());
        }




        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        [InlineData("lorem ipsum. dolor", 1)]
        [InlineData("\tlorem\nipsum.    dolor\n     ", 3)]
        public void GetTotalNumberOfLines_Valid(string input, int expected)
        {
            Assert.Equal(expected, input.GetTotalNumberOfLines());
        }



        [Theory]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        [InlineData("lor ipsum. dol lorem", "lor")]
        [InlineData("\tlorem\nipsum    dol\n     ", "dol")]
        public void GetFirstShortestWord_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.GetFirstShortestWord());
        }

        [Theory]
        [InlineData("", "lorem", 0)]
        [InlineData(" ", "lorem", 0)]
        [InlineData(null, "lorem", 0)]
        [InlineData("lorem ipsum. dolor lorem", "lorem", 2)]
        [InlineData("\tlorem\nipsum    dolor\n   lorem lorem  ", "lorem lorem", 1)]
        public void CountStringOccurrences_Valid(string input, string pattern, int expected)
        {
            Assert.Equal(expected, input.CountStringOccurrences(pattern));
        }

        [Theory]
        [InlineData(null, 3, null)]
        [InlineData("", 3, "")]
        [InlineData("abcdefgh", 3, "defgh")]
        public void RemoveNumberOfCharsAtBegining_Valid(string input, int n, string expected)
        {
            Assert.Equal(expected, input.RemoveNumberOfCharsAtBegining(n));
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("abcd\nefgh\n", "abcdefgh")]
        public void RemoveAllLineBreaks_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.RemoveAllLineBreaks());
        }

        [Theory]
        [InlineData(null, "")]
        public void IfNullReturnEmptyString_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.IfNullReturnEmptyString());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("http://testtest.com", "http://testtest.com")]
        [InlineData("https://testtest.com/test", "https://testtest.com")]
        public void GetUrlDomain_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.GetUrlDomain());
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData(null, null)]
        [InlineData("c:\\abcq\\abcd.txt", "txt")]
        [InlineData("http://testte333333st.com/test.pdf", "pdf")]
        public void GetFileExtension_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.GetFileExtension());
        }

        [Theory]
        [MemberData(nameof(ToStringArrayFromDelimitedStringData))]
        public void ToStringArrayFromDelimitedString_Valid(string input, string[] expected)
        {
            Assert.Equal(expected, input.ToStringArrayFromDelimitedString(','));
        }

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
        public void ToUrlFriendly_Valid(string input, string expected)
        {
            Assert.Equal(expected, input.ToUrlFriendly());
        }

        [Theory]
        [InlineData(' ', false)]
        [InlineData('5', true)]
        [InlineData('B', false)]
        public void IsDigit_Valid(char input, bool expected)
        {
            Assert.Equal(expected, input.IsDigit());
        }

        [Theory]
        [InlineData("1.5", '.', 1)]
        [InlineData("rr", 'r', 2)]
        [InlineData("22se2", '2', 3)]
        public void HowManyOccurrences_Valid(string input, char c, int expected)
        {
            Assert.Equal(expected, input.HowManyOccurrences(c));
        }

        [Theory]
        [InlineData("1", true)]
        [InlineData("rr", false)]
        [InlineData(null, false)]
        [InlineData("22se2", false)]
        public void InInteger_Valid(string input, bool expected)
        {
            Assert.Equal(expected, input.IsInteger());
        }

        [Theory]
        [InlineData(null, "..", "..")]
        [InlineData("", "--", "--")]
        [InlineData("abcd", "..", "..abcd")]
        public void AddToBeginingIfMissed_Valid(string input, string value, string expected)
        {
            Assert.Equal(expected, input.AddToBeginingIfMissed(value));
        }

        [Theory]
        [InlineData("1.5", true)]
        [InlineData("rr", false)]
        [InlineData(null, false)]
        [InlineData("22se2", false)]
        public void InNumber_Valid(string input, bool expected)
        {
            Assert.Equal(expected, input.IsNumber());
        }
    }
}
