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
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        [InlineData("lorem ipsum. dolor", 3)]
        [InlineData("\tlorem\nipsum.    dolor\n     ", 3)]
        public void GetTotalNumberOfWords_Valid(string input, int expected)
        {
            Assert.Equal(expected, input.GetTotalNumberOfWords());
        }
    }
}
