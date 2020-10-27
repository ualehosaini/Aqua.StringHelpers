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
output = input.IsNullOrEmpty();  // result = true

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
output = input.IsNullOrWhiteSpace();  // result = true

input = " ";
output = input.IsNullOrWhiteSpace(); // output = false

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
output = input.IsInteger();  // result = false

input = " ";
output = input.IsInteger();  // result = false

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
output = input.IsNumber();  // result = false

input = " ";
output = input.IsNumber();  // result = false

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
output = input.IsAlphaNumeric();  // result = false

input = " ";
output = input.IsAlphaNumeric();  // result = false

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
output = input.IsValidURL();  // result = false

input = " ";
output = input.IsValidURL();  // result = false

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
string input;
string output;

input = null;
output = input.IfNullReturnEmptyString();  // output = ""

input = "";
output = input.IfNullReturnEmptyString();  // result = ""

input = " ";
output = input.IfNullReturnEmptyString();  // result = " "

input = "lorem ipsum";
output = input.IfNullReturnEmptyString();  // output = "lorem ipsum"
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
