using System;

namespace FastConsole
{
    public interface IPrinter
    {
        /// <summary>
        /// The font color.
        /// </summary>
        /// <value></value>
        ConsoleColor? TextColor { get; set; }

        /// <summary>
        /// The color behind the text.
        /// </summary>
        /// <value></value>
        ConsoleColor? BackColor { get; set; }

        #region Print
        /// <summary>
        /// Prints the string value with the specified colors in this instance of IPrinter.
        /// </summary>
        /// <param name="value"></param>
        void Print(string value);

        /// <summary>
        /// Prints the string representation of the object value with the specified colors in this instance of IPrinter.
        /// </summary>
        /// <param name="value"></param>
        void Print(object value);

        /// <summary>
        /// Encapsulates the CoolSnippet value with the specified default colors in this instance of IPrinter then Prints it.
        /// </summary>
        /// <param name="value"></param>
        void Print(CoolSnippet value);

        /// <summary>
        /// Encapsulates the CoolText value with the specified colors in this instance of IPrinter then Prints it.
        /// </summary>
        /// <param name="value"></param>
        void Print(CoolText value);
        #endregion

        #region Println
        /// <summary>
        /// 'Printlns' the string value with the specified colors in this instance of IPrinter.
        /// </summary>
        /// <param name="value"></param>
        void Println(string value);

        /// <summary>
        /// 'Printlns' the string representation of the object value with the specified colors in this instance of IPrinter.
        /// </summary>
        /// <param name="value"></param>
        void Println(object value);

        /// <summary>
        /// Encapsulates the CoolSnippet value with the specified default colors in this instance of IPrinter then 'Printlns' it.
        /// </summary>
        /// <param name="value"></param>
        void Println(CoolSnippet value);

        /// <summary>
        /// Encapsulates the CoolText value with the specified default colors in this instance of IPrinter then 'Printlns' it.
        /// </summary>
        /// <param name="value"></param>
        void Println(CoolText value);
        #endregion
    }
}