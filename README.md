# About Aqua String Helpers:

Aqua String Helpers is an Open Source and Free Software package consists of a set of utilities that facilitate the job of the developer and save his time while dealing with a string. Every developer could be a beneficiary of this library; however, those who deal with database and integration applications are likely the most potential beneficiaries.


# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# List of Features and Methods
1. [IsNullOrEmpty](#IsNullOrEmpty)
2. [IsNullOrWhiteSpace](#IsNullOrWhiteSpace)
3. [IsDigit](#IsDigit)
4. [IsInteger](#IsInteger)
5. [IsNumber](#IsNumber)
6. [IsAlphaNumeric](#IsAlphaNumeric)
7. [IsValidURL](#IsValidURL)
8. [IfNullReturnEmptyString](#IfNullReturnEmptyString)
9. [Reverse](#Reverse)
10. [RemoveExtraSpaces](#RemoveExtraSpaces)
11. [RemoveAllLineBreaks](#RemoveAllLineBreaks)
12. [RemoveNonASCIIChars](#RemoveNonASCIIChars)
13. [RemoveNumberOfCharsAtBegining](#RemoveNumberOfCharsAtBegining)
14. [RemoveNumberOfCharsAtEnd](#RemoveNumberOfCharsAtEnd)
15. [ReplaceTabsWithSpaces](#ReplaceTabsWithSpaces)
16. [ReplaceNewLinesWithSpaces](#ReplaceNewLinesWithSpaces)
17. [ReplaceDoubleQuotesWithSingle](#ReplaceDoubleQuotesWithSingle)
18. [ReplaceSingleQuotesWithDouble](#ReplaceSingleQuotesWithDouble)
19. [ReplaceNonASCIICharsWith](#ReplaceNonASCIICharsWith)
20. [ReplaceFirstOccurrence](#ReplaceFirstOccurrence)
21. [ToCleanString](#ToCleanString)
22. [ToAlphaNumericString](#ToAlphaNumericString)
23. [ToHtml](#ToHtml)
24. [ToAbbreviation](#ToAbbreviation)
25. [ToNcharAbbreviation](#ToNcharAbbreviation)
26. [ToHyperlink](#ToHyperlink)
27. [ToSentenceCase](#ToSentenceCase)
28. [ToBase64](#ToBase64)
29. [ToSummarisedText](#ToSummarisedText)
30. [ToSummarisedTextRight](#ToSummarisedTextRight)
31. [ToCsvCompatible](#ToCsvCompatible)
32. [ToUkTelephoneFormat](#ToUkTelephoneFormat)
33. [ToUpperCaseCanonicalGuid](#ToUpperCaseCanonicalGuid)
34. [ToDoubleQuotedString](#ToDoubleQuotedString)
35. [ToStringArrayFromDelimitedString](#ToStringArrayFromDelimitedString)
36. [ToUrlFriendly](#ToUrlFriendly)
37. [ToCanonicalGuid](#ToCanonicalGuid)
38. [ToDistinctListOfWords](#ToDistinctListOfWords)
39. [To16ByteSaltedHash](#To16ByteSaltedHash)
40. [CapitaliseEachWord](#CapitaliseEachWord)
41. [AddToBeginingIfMissed](#AddToBeginingIfMissed)
42. [DecodeBase64](#DecodeBase64)
43. [CountStringOccurrences](#CountStringOccurrences)
44. [FindAllDigits](#FindAllDigits)
45. [FindNumberOfDigits](#FindNumberOfDigits)
46. [CorrectPathSlashes](#CorrectPathSlashes)
47. [CenterAligned](#CenterAligned)
48. [HowManyOccurrences](#HowManyOccurrences)
49. [CleanNonNumericChars](#CleanNonNumericChars)
50. [NullIfEqualTo](#NullIfEqualTo)
51. [GetTotalNumberOfWords](#GetTotalNumberOfWords)
52. [GetTotalNumberOfCharachters](#GetTotalNumberOfCharachters)
53. [GetFirstLongestWord](#GetFirstLongestWord)
54. [GetFirstShortestWord](#GetFirstShortestWord)
55. [GetTotalNumberOfLines](#GetTotalNumberOfLines)
56. [GetUrlDomain](#GetUrlDomain)
57. [GetFileExtension](#GetFileExtension)
58. [AddToEndIfMissed](#AddToEndIfMissed)
59. [GenerateLoremIpsumString](#GenerateLoremIpsumString)
60. [GenerateLoremIpsumHtmlSafe](#GenerateLoremIpsumHtmlSafe)
61. [Coalesce](#Coalesce)
62. [GetFirstNullOrEmpty](#GetFirstNullOrEmpty)

# Features and Methods
### IsNullOrEmpty
IsNullOrEmpty is an extension method, equivalent for the traditional ``` string.IsNullOrEmpty() ``` static method. Returns true if the string examined is null or empty, otherwise returns false.

```C#
//using Aqua.StringHelpers;

string input;
bool output;

input = null;
output = input.IsNullOrEmpty();  // output = true

input = "";
output = input.IsNullOrEmpty();  // output = true

input = " ";
output = input.IsNullOrEmpty();  // output = false

input = "lorem ipsum dolor";
output = input.IsNullOrEmpty();  // output = false

```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### IsNullOrWhiteSpace
IsNullOrEmpty is an extension method, equivalent for the traditional ``` string.IsNullOrWhiteSpace() ``` static method. Returns true if the string examined is null or empty, otherwise returns false.

```C#
//using Aqua.StringHelpers;

string input;
bool output;

input = null;
output = input.IsNullOrWhiteSpace();  // output = true

input = "";
output = input.IsNullOrWhiteSpace();  // output = true

input = " ";
output = input.IsNullOrWhiteSpace();  // output = false

input = "lorem ipsum dolor";
output = input.IsNullOrWhiteSpace();  // output = false

```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### IsDigit

```C#
//using Aqua.StringHelpers;

char input;
bool output;

input = '0';
output = input.IsDigit();  // output = true

input = '9';
output = input.IsDigit();  // output = true

input = 'A';
output = input.IsDigit();  // output = false

```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### IsInteger
```C#
//using Aqua.StringHelpers;

string input;
bool output;

input = null;
output = input.IsInteger();  // output = false

input = "";
output = input.IsInteger();  // output = false

input = " ";
output = input.IsInteger();  // output = false

input = "5";
output = input.IsInteger();  // output = true

input = "555";
output = input.IsInteger();  // output = true

input = "555.50";
output = input.IsInteger();  // output = false

input = "lorem ipsum dolor";
output = input.IsInteger();  // output = false

```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### IsNumber
```C#
//using Aqua.StringHelpers;

string input;
bool output;

input = null;
output = input.IsNumber();  // output = false

input = "";
output = input.IsNumber();  // output = false

input = " ";
output = input.IsNumber();  // output = false

input = "5";
output = input.IsNumber();  // output = true

input = "555";
output = input.IsNumber();  // output = true

input = "555.50";
output = input.IsNumber();  // output = true

input = "lorem ipsum dolor";
output = input.IsNumber();  // output = false

```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### IsAlphaNumeric
```C#
//using Aqua.StringHelpers;

string input;
bool output;

input = null;
output = input.IsAlphaNumeric();  // output = false

input = "";
output = input.IsAlphaNumeric();  // output = false

input = " ";
output = input.IsAlphaNumeric();  // output = false

input = "5";
output = input.IsAlphaNumeric();  // output = true

input = "5A";
output = input.IsAlphaNumeric();  // output = true

input = "A5";
output = input.IsAlphaNumeric();  // output = true

input = "lorem ipsum dolor";
output = input.IsAlphaNumeric();  // output = false

input = "loremipsumdolor";
output = input.IsAlphaNumeric();  // output = true

input = "$loremips((umdolor";
output = input.IsAlphaNumeric();  // output = false

```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### IsValidURL
```C#
using Aqua.StringHelpers;

string input;
bool output;

input = null;
output = input.IsValidURL();  // output = false

input = "";
output = input.IsValidURL();  // output = false

input = " ";
output = input.IsValidURL();  // output = false

input = "http://wideitsolutions.co.uk";
output = input.IsValidURL();  // output = true

input = "https://wideitsolutions.co.uk";
output = input.IsValidURL();  // output = true

input = "http://dev.wideitsolutions.co.uk";
output = input.IsValidURL();  // output = true

input = "http://wideitsolutions.co.uk/dev";
output = input.IsValidURL();  // output = true

```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### IfNullReturnEmptyString

```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.IfNullReturnEmptyString();  // output = ""

input = "";
output = input.IfNullReturnEmptyString();  // output = ""

input = " ";
output = input.IfNullReturnEmptyString();  // output = " "

input = "lorem ipsum";
output = input.IfNullReturnEmptyString();  // output = "lorem ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### Reverse
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.Reverse();  // output = null

input = "";
output = input.Reverse();  // output = ""

input = " ";
output = input.Reverse();  // output = " "

input = "lorem ipsum";
output = input.Reverse();  // output = "muspi merol"

input = "A12345";
output = input.Reverse();  // output = "54321A"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### RemoveExtraSpaces
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.RemoveExtraSpaces();  // output = null

input = "";
output = input.RemoveExtraSpaces();  // output = ""

input = " ";
output = input.RemoveExtraSpaces();  // output = ""

input = "lorem ipsum";
output = input.RemoveExtraSpaces();  // output = "lorem ipsum"

input = "  lorem ipsum      lorem ipsum  ";
output = input.RemoveExtraSpaces();  // output = "lorem ipsum lorem ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### RemoveAllLineBreaks
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.RemoveAllLineBreaks();  // output = null

input = "";
output = input.RemoveAllLineBreaks();  // output = ""

input = " ";
output = input.RemoveAllLineBreaks();  // output = " "

input = "lorem\n ipsum";
output = input.RemoveAllLineBreaks();  // output = "lorem ipsum"

input = "  lorem \nipsum      lorem\n ipsum  ";
output = input.RemoveAllLineBreaks();  // output = "  lorem ipsum      lorem ipsum  "
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### RemoveNonASCIIChars
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.RemoveNonASCIIChars();  // output = null

input = "";
output = input.RemoveNonASCIIChars();  // output = ""

input = " ";
output = input.RemoveNonASCIIChars();  // output = " "

input = "lorem ipsum";
output = input.RemoveNonASCIIChars();  // output = "lorem ipsum"

input = "lorem भारत ipsum";
output = input.RemoveNonASCIIChars();  // output = "lorem  ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### RemoveNumberOfCharsAtBegining
```C#
//using Aqua.StringHelpers;

string input;
int n; //number of characters
string output;

input = null;
n = 3;
output = input.RemoveNumberOfCharsAtBegining(n);  // output = null

input = "";
n = 3;
output = input.RemoveNumberOfCharsAtBegining(n);  // output = ""

input = " ";
n = 3;
output = input.RemoveNumberOfCharsAtBegining(n);  // output = ""

input = "lorem ipsum";
n = 3;
output = input.RemoveNumberOfCharsAtBegining(n);  // output = "em ipsum"

input = "  lorem ipsum";
n = 3;
output = input.RemoveNumberOfCharsAtBegining(n);  // output = "orem  ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### RemoveNumberOfCharsAtEnd
```C#
//using Aqua.StringHelpers;

string input;
int n; //number of characters
string output;

input = null;
n = 3;
output = input.RemoveNumberOfCharsAtEnd(n);  // output = null

input = "";
n = 3;
output = input.RemoveNumberOfCharsAtEnd(n);  // output = ""

input = " ";
n = 3;
output = input.RemoveNumberOfCharsAtEnd(n);  // output = ""

input = "lorem ipsum";
n = 3;
output = input.RemoveNumberOfCharsAtEnd(n);  // output = "lorem ip"

input = "lorem ipsum  ";
n = 3;
output = input.RemoveNumberOfCharsAtEnd(n);  // output = "lorem  ipsu"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ReplaceTabsWithSpaces
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ReplaceTabsWithSpaces();  // output = null

input = "";
output = input.ReplaceTabsWithSpaces();  // output = ""

input = " ";
output = input.ReplaceTabsWithSpaces();  // output = ""

input = "lorem              ipsum";      //4 tabs were here
output = input.ReplaceTabsWithSpaces();  // output = "lorem ipsum"

input = "   lorem               ipsum "; //6 tabs were here
output = input.ReplaceTabsWithSpaces();  // output = "lorem ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ReplaceNewLinesWithSpaces
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ReplaceNewLinesWithSpaces();  // output = null

input = "";
output = input.ReplaceNewLinesWithSpaces();  // output = ""

input = " ";
output = input.ReplaceNewLinesWithSpaces();  // output = ""

input = "lorem\nipsum";
output = input.ReplaceNewLinesWithSpaces();  // output = "lorem ipsum"

input = "\nlorem\n\n      ipsum\ndolor";
output = input.ReplaceNewLinesWithSpaces();  // output = "lorem ipsum dolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ReplaceDoubleQuotesWithSingle
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ReplaceDoubleQuotesWithSingle();  // output = null

input = "";
output = input.ReplaceDoubleQuotesWithSingle();  // output = ""

input = " ";
output = input.ReplaceDoubleQuotesWithSingle();  // output = " "

input = "lorem \"ipsum\"";
output = input.ReplaceDoubleQuotesWithSingle();  // output = "lorem 'ipsum'"

input = "lorem\"              ipsum dolor";
output = input.ReplaceDoubleQuotesWithSingle();  // output = "lorem'              ipsum dolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ReplaceSingleQuotesWithDouble
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ReplaceSingleQuotesWithDouble();  // output = null

input = "";
output = input.ReplaceSingleQuotesWithDouble();  // output = ""

input = " ";
output = input.ReplaceSingleQuotesWithDouble();  // output = " "

input = "lorem 'ipsum'";
output = input.ReplaceSingleQuotesWithDouble();  // output = "lorem \"ipsum\""

input = "lorem'              ipsum dolor";
output = input.ReplaceSingleQuotesWithDouble();  // output = "lorem\"              ipsum dolor"  
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ReplaceNonASCIICharsWith
```C#
//using Aqua.StringHelpers;

string input;
char r;         // Replacement Character
string output;

input = null;
r = '*';
output = input.ReplaceNonASCIICharsWith(r);  // output = null

input = "";
r = '*';
output = input.ReplaceNonASCIICharsWith(r);  // output = ""

input = " ";
r = '*';
output = input.ReplaceNonASCIICharsWith(r);  // output = " "

input = "lorem ipsum";
r = '*';
output = input.ReplaceNonASCIICharsWith(r);  // output = "lorem ipsum"

input = "lorem भारत ipsum";
r = '*';
output = input.ReplaceNonASCIICharsWith(r);  // output = "lorem **** ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ReplaceFirstOccurrence
```C#
//using Aqua.StringHelpers;

string input;
string s;         // Search string
string r;         // Replacement string
string output;

input = null;
s = "ip";
r = "**";
output = input.ReplaceFirstOccurrence(s,r);  // output = null

input = "";
s = "ip";
r = "**";
output = input.ReplaceFirstOccurrence(s, r);  // output = ""

input = " ";
s = "ip";
r = "**";
output = input.ReplaceFirstOccurrence(s, r);  // output = " "

input = "lorem ipsum ipsum";
s = "ip";
r = "**";
output = input.ReplaceFirstOccurrence(s, r);  // output = "lorem **sum ipsum"

input = "lorem ipsum dolor";
s = "ip";
r = "**";
output = input.ReplaceFirstOccurrence(s, r);  // output = "lorem **sum dolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToCleanString
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToCleanString();  // output = null

input = "";
output = input.ToCleanString();  // output = ""

input = " ";
output = input.ToCleanString();  // output = ""

input = "   lorem     ipsum      ";
output = input.ToCleanString();  // output = "lorem ipsum"

input = " lorem\n     ipsum\n";  // there is mix of \n \t and spaces
output = input.ToCleanString();  // output = "lorem ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToAlphaNumericString
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToAlphaNumericString();  // output = null

input = "";
output = input.ToAlphaNumericString();  // output = ""

input = " ";
output = input.ToAlphaNumericString();  // output = ""

input = "lorem12345^^^&&**ipsum22$$";
output = input.ToAlphaNumericString();  // output = "lorem12345ipsum22"

input = " lorem\n 55 **   ipsum\n";
output = input.ToAlphaNumericString();  // output = "lorem55ipsum"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToHtml
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToHtml();  // output = null

input = "";
output = input.ToHtml();  // output = ""

input = " ";
output = input.ToHtml();  // output = ""

input = "lorem ipsum lorem\n ipsum\n";
output = input.ToHtml();  // output = "lorem ipsum lorem<br/> ipsum<br/>"

input = " lorem\n ipsum\n";
output = input.ToHtml();  // output = " lorem<br/> ipsum<br/>"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToAbbreviation
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToAbbreviation();  // output = null

input = "";
output = input.ToAbbreviation();  // output = ""

input = " ";
output = input.ToAbbreviation();  // output = " "

input = "lorem ipsum dolor lorem ipsum";
output = input.ToAbbreviation();  // output = "LIDLI"

input = "   lorem    ipsum   dolor lorem ipsum";
output = input.ToAbbreviation();  // output = "LIDLI"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToNcharAbbreviation
```C#
string input;
int n;          //Length of Abbreviation
string output;

input = null;
n = 3;
output = input.ToNcharAbbreviation(n);  // output = null

input = "";
n = 3;
output = input.ToNcharAbbreviation(n);  // output = ""

input = " ";
n = 3;
output = input.ToNcharAbbreviation(n);  // output = " "

input = "lorem ipsum dolor lorem ipsum";
n = 3;
output = input.ToNcharAbbreviation(n);  // output = "LID"

input = "   lorem    ipsum   dolor lorem ipsum";
n = 3;
output = input.ToNcharAbbreviation(n);  // output = "LID"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)
### ToHyperlink
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToHyperlink();  // output = null

input = "";
output = input.ToHyperlink();  // output = ""

input = " ";
output = input.ToHyperlink();  // output = ""

input = "www.wideitsolutions.co.uk";
output = input.ToHyperlink();  // output = "www.wideitsolutions.co.uk"

input = "http://www.wideitsolutions.co.uk";
output = input.ToHyperlink();  // output = "<a href=\"http://www.wideitsolutions.co.uk" target=\"_blank\">http://www.wideitsolutions.co.uk</a>"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToSentenceCase
```C#
//using Aqua.StringHelpers;

string input;
char s;         //Sentence seperator
string output;

input = null;
s = '.';
output = input.ToSentenceCase(s);  // output = null

input = "";
s = '.';
output = input.ToSentenceCase(s);  // output = ""

input = " ";
s = '.';
output = input.ToSentenceCase(s);  // output = ""

input = "lorem ipsum dolor";
s = '.';
output = input.ToSentenceCase(s);  // output = "Lorem ipsum dolor"

input = "lorem ipsum dolor. lorem. ipsum dolor";
s = '.';
output = input.ToSentenceCase(s);  // output = "Lorem ipsum dolor. Lorem. Ipsum dolor."
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToBase64
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToBase64();  // output = null

input = "";
output = input.ToBase64();  // output = ""

input = " ";
output = input.ToBase64();  // output = "IA=="

input = "abc";
output = input.ToBase64();  // output = "YWJj"

input = "lorem ipsum dolor. lorem. ipsum dolor";
output = input.ToBase64();  // output = "bG9yZW0gaXBzdW0gZG9sb3IuIGxvcmVtLiBpcHN1bSBkb2xvcg=="
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToSummarisedText
```C#
//using Aqua.StringHelpers;

string input;
int n;          //Length of Summary
bool d;         //Dots to be used at the end of summary text?
                //This is optional parameter , default is assigned false
string output;

input = null;
n = 15;
output = input.ToSummarisedText(n);    // output = null

input = "";
n = 15;
d = true;
output = input.ToSummarisedText(n,d);  // output = ""

input = " ";
n = 15;
d = true;
output = input.ToSummarisedText(n,d);  // output = " "

input = "abc";
n = 15;
d = true;
output = input.ToSummarisedText(n,d);  // output = "abc"

input = "lorem ipsum dolor. lorem. ipsum dolor";
n = 15;
d = true;
output = input.ToSummarisedText(n,d);  // output = "lorem ipsum dol..."
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToSummarisedTextRight
```C#
//using Aqua.StringHelpers;

string input;
int n;          //Length of Summary
bool d;         //Dots to be used at the end of summary text?
                //This is optional parameter , default is assigned false
string output;

input = null;
n = 15;
output = input.ToSummarisedTextRight(n);  // output = null

input = "";
n = 15;
d = true;
output = input.ToSummarisedTextRight(n,d);  // output = ""

input = " ";
n = 15;
d = true;
output = input.ToSummarisedTextRight(n,d);  // output = " "

input = "abc";
n = 15;
d = true;
output = input.ToSummarisedTextRight(n,d);  // output = "abc"

input = "lorem ipsum dolor. lorem. ipsum dolor";
n = 15;
d = true;
output = input.ToSummarisedTextRight(n,d);  // output = "...em. ipsum dolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToCsvCompatible
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToCsvCompatible();  // output = null

input = "";
output = input.ToCsvCompatible();  // output = ""

input = " ";
output = input.ToCsvCompatible();  // output = "\" \""

input = "abc\n";
output = input.ToCsvCompatible();  // output = "\"abc\n\""

input = " lorem ipsum dolor, lorem; ipsum dolor";
output = input.ToCsvCompatible();  // output = "\" lorem ipsum dolor, lorem; ipsum dolor\""
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToUkTelephoneFormat
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToUkTelephoneFormat();  // output = null

input = "";
output = input.ToUkTelephoneFormat();  // output = ""

input = " ";
output = input.ToUkTelephoneFormat();  // output = " "

input = "07777777777";
output = input.ToUkTelephoneFormat();  // output = "07777 777777"

input = "0111111111";
output = input.ToUkTelephoneFormat();  // output = "01111 11111"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToUpperCaseCanonicalGuid
```C#
//using Aqua.StringHelpers;

Guid input;
string output;

input = Guid.Empty;
output = input.ToUpperCaseCanonicalGuid();  // output = "00000000000000000000000000000000"

input = new Guid("{4A6B75A8-F2A3-4F8F-AAE6-224B5CBFE44E}");
output = input.ToUpperCaseCanonicalGuid();  // output = "4A6B75A8F2A34F8FAAE6224B5CBFE44E"

input = new Guid("{4a6b75a8-f2a3-4f8f-aae6-224b5cbfe44e}");
output = input.ToUpperCaseCanonicalGuid();  // output = "4A6B75A8F2A34F8FAAE6224B5CBFE44E"

input = Guid.NewGuid();
output = input.ToUpperCaseCanonicalGuid();  // output = "4A6B75A8F2A34F8FAAE6224B5CBFE44E"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToDoubleQuotedString
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToDoubleQuotedString();  // output = null

input = "";
output = input.ToDoubleQuotedString();  // output = ""

input = " ";
output = input.ToDoubleQuotedString();  // output = " "

input = "lorem ipsum dolor";
output = input.ToDoubleQuotedString();  // output = "\"lorem ipsum dolor\""

input = "\"lorem ipsum dolor\"";
output = input.ToDoubleQuotedString();  // output = "\"\"lorem ipsum dolor\"\""
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToStringArrayFromDelimitedString
```C#
//using Aqua.StringHelpers;

string input;
char d;           // delimiter
string[] output;

input = null;
d = ',';
output = input.ToStringArrayFromDelimitedString(d);  // output = {string[0]}

input = "";
d = ',';
output = input.ToStringArrayFromDelimitedString(d);  // output = {string[0]}

input = " ";
d = ',';
output = input.ToStringArrayFromDelimitedString(d);  // output = {string[0]}

input = "lorem; ipsum; dolor";
d = ';';
output = input.ToStringArrayFromDelimitedString(d);  // output = string[3]{"lorem", "ipsum", "dolor"}

input = "lorem, ipsum, dolor";
d = ',';
output = input.ToStringArrayFromDelimitedString(d);  // output = string[3]{"lorem", "ipsum", "dolor"}
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToUrlFriendly
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.ToUrlFriendly();  // output = null

input = "";
output = input.ToUrlFriendly();  // output = ""

input = " ";
output = input.ToUrlFriendly();  // output = " "

input = "lorem ipsum dolor";
output = input.ToUrlFriendly();  // output = "loremipsumdolor"

input = "\"lorem ipsum dolor";
output = input.ToUrlFriendly();  // output = "loremipsumdolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToCanonicalGuid
```C#
//using Aqua.StringHelpers;

Guid input;
string output;

input = Guid.Empty;
output = input.ToCanonicalGuid();  // output = "00000000000000000000000000000000"

input = new Guid("{4A6B75A8-F2A3-4F8F-AAE6-224B5CBFE44E}");
output = input.ToCanonicalGuid();  // output = "4a6b75a8f2a34f8faae6224b5cbfe44e"

input = new Guid("{4a6b75a8-f2a3-4f8f-aae6-224b5cbfe44e}");
output = input.ToCanonicalGuid();  // output = "4a6b75a8f2a34f8faae6224b5cbfe44e"

input = Guid.NewGuid();
output = input.ToCanonicalGuid();  // output = "4a6b75a8f2a34f8faae6224b5cbfe44e"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### ToDistinctListOfWords
```C#
//using Aqua.StringHelpers;

string input;
List<string> output;

input = null;
output = input.ToDistinctListOfWords();  // output = List<string>{}

input = "";
output = input.ToDistinctListOfWords();  // output = List<string>{}

input = " ";
output = input.ToDistinctListOfWords();  // output = List<string>{}

input = "lorem ipsum dolor ipsum dolor";
output = input.ToDistinctListOfWords();  // output = List<string>{"dolor", "ipsum", "lorem"}

input = "\"lorem ipsum dolor ipsum dolor";
output = input.ToDistinctListOfWords();  // output = List<string>{"dolor", "ipsum", "lorem"}
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### To16ByteSaltedHash
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = "";
output = input.To16ByteSaltedHash();  // output = "XptBgEyQ8rVKKYnO+0MzWTV2oQHybB3yqpvRbZzSxAkmcV5e"

input = " ";
output = input.To16ByteSaltedHash();  // output = "wbasNJXqc6dcZrEtjIw31aSKg0A1dvab25lRKOqhDHnk9wAz"

input = "abcd";
output = input.To16ByteSaltedHash();  // output = "i6H3KFHsCR/OYni4EG57FCrUX/r3swloE16Ma0lUerdOYrsW"

input = "abcd12345";
output = input.To16ByteSaltedHash();  // output = "ILUxWoR6iWnBxkqs+E38sWJZtU02J42HQ1gtAMcOIIP3p90u"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### CapitaliseEachWord
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.CapitaliseEachWord();  // output = null

input = "";
output = input.CapitaliseEachWord();  // output = ""

input = " ";
output = input.CapitaliseEachWord();  // output = " "

input = "lorem ipsum dolor";
output = input.CapitaliseEachWord();  // output = "Lorem Ipsum Dolor"

input = "lorem ipsum dolor.";
output = input.CapitaliseEachWord();  // output = "Lorem Ipsum Dolor."
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### AddToBeginingIfMissed
```C#
//using Aqua.StringHelpers;

string input;
string a;        //The value to be added
string output;

input = null;
a = "The ";
output = input.AddToBeginingIfMissed(a);  // output = "The "

input = "";
a = "The ";
output = input.AddToBeginingIfMissed(a);  // output = "The "

input = " ";
a = "The ";
output = input.AddToBeginingIfMissed(a);  // output = "The "

input = "The lorem ipsum dolor.";
a = "The ";
output = input.AddToBeginingIfMissed(a);  // output = "The lorem ipsum dolor."

input = "lorem ipsum dolor.";
a = "The ";
output = input.AddToBeginingIfMissed(a);  // output = "The Lorem Ipsum Dolor."
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### DecodeBase64
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.DecodeBase64();  // output = null

input = "";
output = input.DecodeBase64();  // output = ""

input = "IA==";
output = input.DecodeBase64();  // output = " "

input = "YWJj";
output = input.DecodeBase64();  // output = "abc"

input = "bG9yZW0gaXBzdW0gZG9sb3IuIGxvcmVtLiBpcHN1bSBkb2xvcg==";
output = input.DecodeBase64();  // output = "lorem ipsum dolor. lorem. ipsum dolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### CountStringOccurrences
```C#
//using Aqua.StringHelpers;

string input;
string s;       //Search string
bool c;         //Is Case Sensitive Search? - Default is true
int output;

input = null;
s = "em";
output = input.CountStringOccurrences(s);  // output = 0

input = "";
s = "em";
output = input.CountStringOccurrences(s);  // output = 0

input = " ";
s = "em";
output = input.CountStringOccurrences(s);  // output = 0

input = "lorEM ipsum dolor. lorem ipsum dolor. lorem ipsum dolor.";
s = "em";
output = input.CountStringOccurrences(s);  // output = 2

input = "LorEM ipsum dolor. lorEm ipsum dolor. loreM ipsum dolor.";
s = "em";
c = false;
output = input.CountStringOccurrences(s, c);  // output = 3
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### FindAllDigits
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.FindAllDigits();  // output = null

input = "";
output = input.FindAllDigits();  // output = ""

input = " ";
output = input.FindAllDigits();  // output = ""

input = "6lorem65";
output = input.FindAllDigits();  // output = "665"

input = "lorem5 6 7 % 9 ipsum dolor.";
output = input.FindAllDigits();  // output = "5679"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### FindNumberOfDigits
```C#
//using Aqua.StringHelpers;

string input;
int output;

input = null;
output = input.FindNumberOfDigits();  // output = 0

input = "";
output = input.FindNumberOfDigits();  // output = 0

input = " ";
output = input.FindNumberOfDigits();  // output = 0

input = "6lorem65";
output = input.FindNumberOfDigits();  // output = 3

input = "lorem5 6 7 % 9 ipsum dolor.";
output = input.FindNumberOfDigits();  // output = 4
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)
### CorrectPathSlashes
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.CorrectPathSlashes();  // output = null

input = "";
output = input.CorrectPathSlashes();  // output = ""

input = " ";
output = input.CorrectPathSlashes();  // output = " "

input = "c:/test";
output = input.CorrectPathSlashes();  // output = "c:\\test"

input = "c:/test/test.pdf";
output = input.CorrectPathSlashes();  // output = "c:\\test\\test.pdf"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### CenterAligned
```C#
//using Aqua.StringHelpers;

string input;
int b;          //Block size
string output;

input = null;
b = 20;
output = input.CenterAligned(b);  // output = null

input = "";
b = 20;
output = input.CenterAligned(b);  // output = ""

input = " ";
b = 20;
output = input.CenterAligned(b);  // output = "                    "

input = "lorem";
b = 20;
output = input.CenterAligned(b);  // output = "        lorem       "

input = "lorem ipsum dolor";
b = 10;
output = input.CenterAligned(b);  // output = "lorem ipsum dolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### HowManyOccurrences
```C#
//using Aqua.StringHelpers;

string input;
char c;          //Search character
string s;          //Search string
int output;

input = null;
c = 'A';
s = "AA";
output = input.HowManyOccurrences(c);  // output = 0
output = input.HowManyOccurrences(s);  // output = 0

input = "";
c = 'A';
s = "AA";
output = input.HowManyOccurrences(c);  // output = 0
output = input.HowManyOccurrences(c);  // output = 0

input = " ";
c = 'A';
s = "AA";
output = input.HowManyOccurrences(c);  // output = 0   
output = input.HowManyOccurrences(c);  // output = 0

input = "lorem";
c = 'l';
s = "lo";
output = input.HowManyOccurrences(c);  // output = 1
output = input.HowManyOccurrences(c);  // output = 1

input = "lorem ipsum dolor";
c = 'l';
s = "lo";
output = input.HowManyOccurrences(c);  // output = 2
output = input.HowManyOccurrences(c);  // output = 2
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### CleanNonNumericChars
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.CleanNonNumericChars();  // output = null

input = "";
output = input.CleanNonNumericChars();  // output = ""

input = " ";
output = input.CleanNonNumericChars();  // output = ""

input = "lorem";
output = input.CleanNonNumericChars();  // output = ""

input = "lorem 4 ipsum 567 8dolor";
output = input.CleanNonNumericChars();  // output = "45678"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### NullIfEqualTo
```C#
//using Aqua.StringHelpers;

string input;
string s;       //Search string
string output;

input = null;
s = "lorem";
output = input.NullIfEqualTo(s);  // output = null

input = "";
s = "lorem";
output = input.NullIfEqualTo(s);  // output = ""

input = " ";
s = "lorem";
output = input.NullIfEqualTo(s);  // output = " "

input = "lorem";
s = "lorem";
output = input.NullIfEqualTo(s);  // output = null

input = "lorem ipsum dolor";
s = "lorem";
output = input.NullIfEqualTo(s);  // output = "lorem ipsum dolor"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GetTotalNumberOfWords
```C#
//using Aqua.StringHelpers;

string input;
int output;

input = null;
output = input.GetTotalNumberOfWords();  // output = 0

input = "";
output = input.GetTotalNumberOfWords();  // output = 0

input = " ";
output = input.GetTotalNumberOfWords();  // output = 0

input = "lorem";
output = input.GetTotalNumberOfWords();  // output = 1

input = "lorem ipsum dolor";
output = input.GetTotalNumberOfWords();  // output = 3
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GetTotalNumberOfCharachters
```C#
//using Aqua.StringHelpers;

string input;
bool c;         //Clean the string before counting the characters? default is false
int output;

input = null;
c = false;
output = input.GetTotalNumberOfCharachters();  // output = 0

input = "";
c = false;
output = input.GetTotalNumberOfCharachters();  // output = 0

input = " ";
c = false;
output = input.GetTotalNumberOfCharachters();  // output = 1

input = "lorem  ";
c = true;
output = input.GetTotalNumberOfCharachters(c);  // output = 5

input = "lorem ipsum       dolor";
c = true;
output = input.GetTotalNumberOfCharachters(c);  // output = 17
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GetFirstLongestWord
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.GetFirstLongestWord();  // output = null

input = "";
output = input.GetFirstLongestWord();  // output = ""

input = " ";
output = input.GetFirstLongestWord();  // output = " "

input = "lorem";
output = input.GetFirstLongestWord();  // output = "lorem"

input = "lorem ipsum dolor";
output = input.GetFirstLongestWord();  // output = "lorem"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GetFirstShortestWord
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.GetFirstShortestWord();  // output = null

input = "";
output = input.GetFirstShortestWord();  // output = ""

input = " ";
output = input.GetFirstShortestWord();  // output = " "

input = "lorem";
output = input.GetFirstShortestWord();  // output = "lorem"

input = "lorem ipsum dolor";
output = input.GetFirstShortestWord();  // output = "lorem"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GetTotalNumberOfLines
```C#
//using Aqua.StringHelpers;

string input;
int output;

input = null;
output = input.GetTotalNumberOfLines();  // output = 0

input = "";
output = input.GetTotalNumberOfLines();  // output = 0

input = " ";
output = input.GetTotalNumberOfLines();  // output = 0

input = "lorem\n";
output = input.GetTotalNumberOfLines();  // output = 2

input = "\nlorem \n\nipsum\n dolor";
output = input.GetTotalNumberOfLines();  // output = 5
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GetUrlDomain
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.GetUrlDomain();  // output = null

input = "";
output = input.GetUrlDomain();  // output = ""

input = " ";
output = input.GetUrlDomain();  // output = ""

input = "http://www.wideitsolutions.co.uk/test/test";
output = input.GetUrlDomain();  // output = "http://www.wideitsolutions.co.uk"

input = "http://dev.wideitsolutions.co.uk/test/test";
output = input.GetUrlDomain();  // output = "http://dev.wideitsolutions.co.uk"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GetFileExtension
```C#
//using Aqua.StringHelpers;

string input;
string output;

input = null;
output = input.GetFileExtension();  // output = null

input = "";
output = input.GetFileExtension();  // output = ""

input = " ";
output = input.GetFileExtension();  // output = ""

input = "c:\\test.pdf";
output = input.GetFileExtension();  // output = "pdf"

input = "http://dev.wideitsolutions.co.uk/test/test/test.pdf";
output = input.GetFileExtension();  // output = "pdf"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### AddToEndIfMissed
```C#
//using Aqua.StringHelpers;

string input;
string a;        //The value to be added
string output;

input = null;
a = "...";
output = input.AddToEndIfMissed(a);  // output = "..."

input = "";
a = "...";
output = input.AddToEndIfMissed(a);  // output = "..."

input = " ";
a = "...";
output = input.AddToEndIfMissed(a);  // output = "..."

input = "The lorem ipsum dolor";
a = "...";
output = input.AddToEndIfMissed(a);  // output = "The lorem ipsum dolor..."

input = "lorem ipsum dolor";
a = "...";
output = input.AddToEndIfMissed(a);  // output = "lorem Ipsum Dolor..."
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GenerateLoremIpsumString
```C#
//using Aqua.StringHelpers;

string output;
int minWords;       //Minumum number of words in output
int maxWords;       //Maximum number of words in the output
int minSentences;   //Minumum number of sentences in the output
int maxSentences;   //Maximum number of sentences in the output
int numParagraphs;  //The number of paragraphs to be in the output

minWords = 1;
maxWords = 100;
minSentences = 1;
maxSentences = 10;
numParagraphs = 1;
output = StringHelpers.GenerateLoremIpsumString(minWords, maxWords, minSentences, maxSentences, numParagraphs);
// output = "tincidunt tincidunt diam amet diam sit. aliquam euismod diam adipiscing aliquam aliquam."
            
minWords = 1;
maxWords = 100;
minSentences = 1;
maxSentences = 10;
numParagraphs = 2;
output = StringHelpers.GenerateLoremIpsumString(minWords, maxWords, minSentences, maxSentences, numParagraphs);
// output =
//"consectetuer nibh magna euismod dolor ut amet aliquam diam consectetuer magna dolor 
// ipsum sed. aliquam dolor dolore ipsum nibh nibh nonummy nibh aliquam nonummy ut laoreet 
// dolore sed. adipiscing sed dolore sed elit magna euismod lorem magna magna consectetuer tincidunt 
// dolore dolor. dolore euismod tincidunt diam diam nonummy ut laoreet nonummy diam tincidunt lorem euismod ut. 
// tincidunt adipiscing aliquam elit magna dolore euismod ipsum diam sed ut amet laoreet aliquam. 
// consectetuer erat dolore aliquam laoreet elit ut adipiscing magna consectetuer consectetuer adipiscing 
// tincidunt nonummy. magna adipiscing laoreet elit amet aliquam adipiscing nonummy erat magna dolore lorem 
// diam ut. sit amet laoreet amet laoreet dolore nonummy nibh tincidunt ut amet amet erat elit. diam tincidunt 
// ipsum nonummy dolor ipsum sit dolor tincidunt adipiscing erat dolore euismod laoreet. lorem aliquam dolor 
// laoreet magna erat dolor tincidunt diam lorem nibh magna lorem adipiscing. tincidunt ipsum dolor lorem 
// aliquam erat ipsum adipiscing laoreet consectetuer magna sed nibh lorem. nibh sed consectetuer aliquam amet 
// laoreet nibh ut nibh diam adipiscing erat amet laoreet. sit ipsum erat amet lorem magna sed nibh sit erat 
// aliquam euismod tincidunt ut. dolor magna magna diam sed dolor dolor lorem laoreet euismod tincidunt 
// consectetuer laoreet aliquam. "
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GenerateLoremIpsumHtmlSafe
```C#
//using Aqua.StringHelpers;

string output;
int minWords;       //Minumum number of words in output
int maxWords;       //Maximum number of words in the output
int minSentences;   //Minumum number of sentences in the output
int maxSentences;   //Maximum number of sentences in the output
int numParagraphs;  //The number of paragraphs to be in the output

minWords = 1;
maxWords = 100;
minSentences = 1;
maxSentences = 10;
numParagraphs = 1;
output = StringHelpers.GenerateLoremIpsumHtmlSafe(minWords, maxWords, minSentences, maxSentences, numParagraphs);
// output = "<p>tincidunt tincidunt diam amet diam sit. aliquam euismod diam adipiscing aliquam aliquam.</p>"
            
minWords = 1;
maxWords = 100;
minSentences = 1;
maxSentences = 10;
numParagraphs = 2;
output = StringHelpers.GenerateLoremIpsumHtmlSafe(minWords, maxWords, minSentences, maxSentences, numParagraphs);
// output =
// "<p>
// consectetuer nibh magna euismod dolor ut amet aliquam diam consectetuer magna dolor 
// ipsum sed. aliquam dolor dolore ipsum nibh nibh nonummy nibh aliquam nonummy ut laoreet 
// dolore sed. adipiscing sed dolore sed elit magna euismod lorem magna magna consectetuer tincidunt 
// dolore dolor. dolore euismod tincidunt diam diam nonummy ut laoreet nonummy diam tincidunt lorem euismod ut. 
// tincidunt adipiscing aliquam elit magna dolore euismod ipsum diam sed ut amet laoreet aliquam.
// <p>
// </p>
// consectetuer erat dolore aliquam laoreet elit ut adipiscing magna consectetuer consectetuer adipiscing 
// tincidunt nonummy. magna adipiscing laoreet elit amet aliquam adipiscing nonummy erat magna dolore lorem 
// diam ut. sit amet laoreet amet laoreet dolore nonummy nibh tincidunt ut amet amet erat elit. diam tincidunt 
// ipsum nonummy dolor ipsum sit dolor tincidunt adipiscing erat dolore euismod laoreet. lorem aliquam dolor 
// laoreet magna erat dolor tincidunt diam lorem nibh magna lorem adipiscing. tincidunt ipsum dolor lorem 
// aliquam erat ipsum adipiscing laoreet consectetuer magna sed nibh lorem. nibh sed consectetuer aliquam amet 
// laoreet nibh ut nibh diam adipiscing erat amet laoreet. sit ipsum erat amet lorem magna sed nibh sit erat 
// aliquam euismod tincidunt ut. dolor magna magna diam sed dolor dolor lorem laoreet euismod tincidunt 
// consectetuer laoreet aliquam. 
// </p>"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### Coalesce
```C#
//using Aqua.StringHelpers;
string[] input;
string output;

input = new[] { null, "", "lorem", "lorem ipsum dolor", "dolor" };
output = StringHelpers.Coalesce(input); // output = ""

input = new[] { null, "lorem", "lorem ipsum dolor", "dolor" };
output = StringHelpers.Coalesce(input); // output = "lorem"

input = new[] { "lorem", null, "", "lorem ipsum dolor", "dolor" };
output = StringHelpers.Coalesce(input); // output = "lorem"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)

### GetFirstNullOrEmpty
```C#
//using Aqua.StringHelpers;
string[] input;
string output;

input = new[] { "lorem", "", "lorem", "lorem ipsum dolor", "dolor" };
output = StringHelpers.GetFirstNullOrEmpty(input); // output = ""

input = new[] { null, "lorem", "lorem ipsum dolor", "dolor" };
output = StringHelpers.GetFirstNullOrEmpty(input); // output = "null"

input = new[] { "lorem", null, "", "lorem ipsum dolor", "dolor" };
output = StringHelpers.GetFirstNullOrEmpty(input); // output = "null"
```
:back:[Back to the Full List of Features](#List-Of-Features-and-Methods)


# Build and Test
TODO: Describe and show how to build your code and run the tests. 



# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
