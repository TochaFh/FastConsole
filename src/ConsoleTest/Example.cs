using FastConsole;
using static System.ConsoleColor;
using static FastConsole.Out;

namespace ConsoleTest
{
    class Example
    {
        public static void Go()
        {
            NewLine(3);

            Println("--- " + "ConsoleTest".I(DarkCyan) + " ---");

            NewLine(2);

            var text = "Hellooo! ".I(Magenta) + "How are " + "you".On(Green) + "!"; // var => CoolText
            Println(text);

            NewLine();

            var otherText = new CoolText("Star Wars".I(Yellow).On(Black), " is the", " BEST ".I(Cyan), "saga!"); // other syntax
            otherText.Println();

            NewLine();

            CoolText allText = text + " " + otherText;
            CoolText blueAllText = allText.I(DarkBlue); // the parts with no specified ink ("How are ", "!") wiil be blue!

            Println(allText);
            Println(blueAllText + " -This is not blue!-");

            NewLine(2);

            Println("Simple text!");
            Println("Simple green text!", Green); // or Println("...".I(Green));
            Println("Simple green text on red!", Green, Red); // or Println("...".I(Green).On(DarkYellow)); or Println("...".I(Green, DarkYellow));

            NewLine(2);

            IPrinter error = new Printer(DarkRed, Gray); // text color, back color
            error.Println("This is an error!");

            CoolText errorText = new[] { "This is an ", "ERROR".On(Black), " too!" }; // anooother syntax...

            error.Println(errorText); // Unspecified colors of 'errorText' will follow 'error' defaults! -- Same as: Out.Print(errorText.I(Red, Black));

            NewLine(2);

            System.Action brazil = () => Print("Brazil!!");
            InvokeWithColors(brazil, Yellow, DarkGreen); // text color, back color

            NewLine(3);

            Println("This ".I(Red) + "was " + "the".On(DarkMagenta) + " test! " + "WOOOOW!!!".I(Cyan, Black));

            NewLine(3);
        }
    }
}