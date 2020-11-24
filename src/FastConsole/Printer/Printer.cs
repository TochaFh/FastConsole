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
        /// <summary>
        /// Creates a Printer with default colors (represented by null).
        /// </summary>
        public Printer() { }

        /// <summary>
        /// Creates a Printer with the specified text color.
        /// </summary>
        /// <param name="textColor"></param>
        public Printer(FColor textColor) : this()
        {
            TextColor = textColor;
        }

        /// <summary>
        /// Creates a Printer with the specified text and back colors.
        /// </summary>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public Printer(FColor textColor, FColor backColor) : this(textColor)
        {
            BackColor = backColor;
        }
        #endregion

        /// <summary>
        /// The font color. (ForegroundColor)
        /// </summary>
        /// <value></value>
        public FColor TextColor { get; set; } = FColor.Default;

        /// <summary>
        /// The color behind the text. (BackgroundColor)
        /// </summary>
        /// <value></value>
        public FColor BackColor { get; set; } = FColor.Default;

        #region Print

        /// <summary>
        /// Prints the string value with the specified colors in this instance of IPrinter.
        /// </summary>
        /// <param name="value"></param>
        public void Print(string value)
        {
            Out.Print(value, TextColor, BackColor);
        }

        /// <summary>
        /// Prints the string representation of the object value with the specified colors in this instance of IPrinter.
        /// </summary>
        /// <param name="value"></param>
        public void Print(object value)
        {
            Out.Print(value.ToString(), TextColor, BackColor);
        }

        /// <summary>
        /// Encapsulates the CoolSnippet value with the specified default colors in this instance of IPrinter then Prints it.
        /// </summary>
        /// <param name="value"></param>
        public void Print(CoolSnippet value)
        {
            // this
            this.Print((CoolText)value);
        }

        /// <summary>
        /// Encapsulates the CoolText value with the specified colors in this instance of IPrinter then Prints it.
        /// </summary>
        /// <param name="value"></param>
        public void Print(CoolText value)
        {
            Out.Print(value.I(TextColor, BackColor));
        }
        #endregion

        #region Println

        /// <summary>
        /// 'Printlns' the string value with the specified colors in this instance of IPrinter.
        /// </summary>
        /// <param name="value"></param>
        public void Println(string value)
        {
            Out.Println(value, TextColor, BackColor);
        }

        /// <summary>
        /// 'Printlns' the string representation of the object value with the specified colors in this instance of IPrinter.
        /// </summary>
        /// <param name="value"></param>
        public void Println(object value)
        {
            Out.Println(value.ToString(), TextColor, BackColor);
        }

        /// <summary>
        /// Encapsulates the CoolSnippet value with the specified default colors in this instance of IPrinter then 'Printlns' it.
        /// </summary>
        /// <param name="value"></param>
        public void Println(CoolSnippet value)
        {
            this.Println((CoolText)value);
        }
        
        /// <summary>
        /// Encapsulates the CoolText value with the specified default colors in this instance of IPrinter then 'Printlns' it.
        /// </summary>
        /// <param name="value"></param>
        public void Println(CoolText value)
        {
            Out.Println(value.I(TextColor, BackColor));
        }
        #endregion
    }
}