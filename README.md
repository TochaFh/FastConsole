# FastConsole - Library for .NET
It's never been so easy to print messages to the console. With FastConsole you can print simple values or super cool text with multiple colors. You can do all of this with easy and short methods!
* [nuget.org](https://www.nuget.org/packages/FastConsole/)
## Install
* Package Reference
```csproj
<PackageReference Include="FastConsole" Version="1.1.2" />
```
* Dotnet CLI
```
dotnet add package FastConsole --version 1.1.2
```
* Package Manager
```
Install-Package FastConsole -Version 1.1.2
```
* Paket CLI
```
paket add FastConsole --version 1.1.2
```
## Quickstart - Examples
* Using
```c#
using FastConsole;
using static FastConsole.Out; // "using statics" are not really necessary
using static System.ConsoleColor;
```
* Simple print/println
```c#
Print("Hello, world! ");
Print("This is blue! ", Blue);
Println("This is blue on dark red!", Blue, DarkRed);
```
* Different inks in same print
```c#
Println("Blue, ".I(Blue) + "yellow, ".I(Yellow) + "red on green, ".I(Red).On(Green) + "default color, " + "default on cyan, ".On(Cyan) + "wow!");
```
* Store cool text in variables
```c#
var text = "May the " + "force ".I(Magenta) + "be with " + "you".On(Green) + "!";  // 'var' --> 'CoolText' (class)
Println(text);
```
* Play with default colors and encapsulating
```c#
// Print text with default colors changed to yellow ('I(Magenta)' and 'On(Green)' will not be overriden!)
Println(text.I(Yellow));

// Only 'text' variable will have yellow as default color
Println("The text is: " + text.I(Yellow) + "\nThe end!");

// You can encapsulate infinitely
var message = ("Let's go!\n" + ("Read this message: " + text).I(Blue) + "\n" + ("Now, read other message: " + "This".On(Green) + " is the " + "way".I(Red) + "!").On(Black) + "\n").I(Yellow);
Println(message + "WOW!!!");
```
* Other methods
```c#
string str = "It's over Anakin!";
str.Print();

Println("I have ".I(Blue), "the ", "high ground".On(Brown), "!");

CoolText text = new[] {"You underestimate ", "my ".On(Yellow), "power".I(Red), "!"};
text.Println();

text = new CoolText("Don't", "try ".I(Magenta), "it.");
text.Print();
```
## See too
* [FastConsole.Input](https://github.com/TochaFh/FastConsole.Input)
