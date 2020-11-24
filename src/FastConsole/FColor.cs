using System;

namespace FastConsole
{
    /// <summary>
    /// The enum used to represent colors in FastConsole.
    /// Specifies the ConsoleColor constants in addition to the 'None' and 'Current' values
    /// </summary>
    public enum FColor
    {
        /// <summary>
        /// The color Black
        /// </summary>
        Black = ConsoleColor.Black,

        /// <summary>
        /// The color DarkBlue
        /// </summary>
        DarkBlue = ConsoleColor.DarkBlue,

        /// <summary>
        /// The color DarkGreen
        /// </summary>
        DarkGreen = ConsoleColor.DarkGreen,

        /// <summary>
        /// The color DarkCyan
        /// </summary>
        DarkCyan = ConsoleColor.DarkCyan,

        /// <summary>
        /// The color DarkRed
        /// </summary>
        DarkRed = ConsoleColor.DarkRed,

        /// <summary>
        /// The color DarkMagenta
        /// </summary>
        DarkMagenta = ConsoleColor.DarkMagenta,

        /// <summary>
        /// The color DarkYellow
        /// </summary>
        DarkYellow = ConsoleColor.DarkYellow,

        /// <summary>
        /// The color Gray
        /// </summary>
        Gray = ConsoleColor.Gray,

        /// <summary>
        /// The color DarkGray
        /// </summary>
        DarkGray = ConsoleColor.DarkGray,

        /// <summary>
        /// The color Blue
        /// </summary>
        Blue = ConsoleColor.Blue,

        /// <summary>
        /// The color Green
        /// </summary>
        Green = ConsoleColor.Green,

        /// <summary>
        /// The color Cyan
        /// </summary>
        Cyan = ConsoleColor.Cyan,

        /// <summary>
        /// The color Red
        /// </summary>
        Red = ConsoleColor.Red,

        /// <summary>
        /// The color Magenta
        /// </summary>
        Magenta = ConsoleColor.Magenta,

        /// <summary>
        /// The color Yellow
        /// </summary>
        Yellow = ConsoleColor.Yellow,

        /// <summary>
        /// The color White
        /// </summary>
        White = ConsoleColor.White,

        /// <summary>
        /// The default value. Represents an unspecified color, that can be changed by the CoolText context.
        /// </summary>
        Default = 16,

        /// <summary>
        /// Represents the color of the Console, that is, when you print something
        /// with FColor.Console specified, the method will print the text with the current color of the console.
        /// </summary>
        CConsole = 17
    }
    internal static class FColorExtensions
    {
        internal static ConsoleColor MatchColor(this FColor fColor, ConsoleColor console)
        {
            if (fColor == FColor.Default || fColor == FColor.CConsole) return console;
            else return (ConsoleColor)fColor;
        }

        internal static FColor WithDefault(this FColor fColor, FColor defaultColor)
        {
            return fColor == FColor.Default ? defaultColor : fColor;
        }
    }
}