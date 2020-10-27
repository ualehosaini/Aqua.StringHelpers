# About Aqua String Helpers:

Aqua String Helpers is an Open Source and Free Software package consists of a set of utilities that facilitate the job of the developer and save his time while dealing with a string. Every developer could be a beneficiary of this library; however, those who deal with database and integration applications are likely the most potential beneficiaries.


# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Features and Methods
### IsNullOrEmpty
IsNullOrEmpty is an extension method, equivalent for the traditional ``` string.IsNullOrEmpty() ``` static method. Returns true if the string examined is null or empty, otherwise returns false.

```C#

string input;
bool output;

input = null;
output = input.IsNullOrEmpty()  // output = true

input = "";
result = input.IsNullOrEmpty()  // result = true

input = " ";
output = input.IsNullOrEmpty()  // output = false

input = "lorem ipsum dolor";
output = input.IsNullOrEmpty()  // output = false

```

### IsNullOrWhiteSpace
IsNullOrEmpty is an extension method, equivalent for the traditional ``` string.IsNullOrWhiteSpace() ``` static method. Returns true if the string examined is null or empty, otherwise returns false.

```C#

string input;
bool output;

input = null;
output = input.IsNullOrWhiteSpace()  // output = true

input = "";
result = input.IsNullOrWhiteSpace()  // result = true

input = " ";
output = input.IsNullOrWhiteSpace()  // output = false

input = "lorem ipsum dolor";
output = input.IsNullOrWhiteSpace()  // output = false

```

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


# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
