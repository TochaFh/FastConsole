using System;

namespace FastConsole
{
    /// <summary>
    /// The main implementation of IPrinter.
    /// Use for printing values to the console with predefined colors.
    /// </summary>
    public class Printer : IPrinter
    {
        #region Constructors
        public Printer() { }
        public Printer(ConsoleColor textColor)
        {
            TextColor = textColor;
        }
        public Printer(ConsoleColor textColor, ConsoleColor backColor) : this(textColor)
        {
            BackColor = backColor;
        }
        #endregion

        public ConsoleColor? TextColor { get; set; }
        public ConsoleColor? BackColor { get; set; }

        #region Print
        public void Print(string value)
        {
            Out.Print(value, TextColor, BackColor);
        }
        public void Print(object value)
        {
            Out.Print(value.ToString(), TextColor, BackColor);
        }
        public void Print(CoolText value)
        {
            Out.Print(value.I(TextColor, BackColor));
        }
        public void Print(CoolSnippet value)
        {
            this.Print((CoolText)value);
        }
        #endregion

        #region Println
        public void Println(string value)
        {
            Out.Println(value, TextColor, BackColor);
        }
        public void Println(object value)
        {
            Out.Println(value.ToString(), TextColor, BackColor);
        }
        public void Println(CoolText value)
        {
            Out.Println(value.I(TextColor, BackColor));
        }
        public void Println(CoolSnippet value)
        {
            this.Println((CoolText)value);
        }
        #endregion
    }
}