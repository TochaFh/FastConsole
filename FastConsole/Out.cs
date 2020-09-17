using System;

namespace FastConsole
{
    /// <summary>
    /// The main static class of FastConsole for printing values to the console.
    /// Strings, objects, CoolTexts, CoolSnippets...
    /// </summary>
    public static class Out
    {
        #region Print
        /// <summary>
        /// Writes the specified string value to console.
        /// *Equivalent to Console.Write(string value)
        /// </summary>
        /// <param name="value"></param>
        public static void Print(string value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Prints the specified text and colors of the CoolSnippet.
        /// </summary>
        /// <param name="text"></param>
        public static void Print(CoolSnippet text)
        {
            if (text == null) return;

            ConsoleColor previousForeColor = GetForeground();
            SetForeground(text.TextColor ?? previousForeColor);

            ConsoleColor previousBackColor = GetBackground();
            SetBackground(text.BackColor ?? previousBackColor);

            Print(text.Text);

            SetForeground(previousForeColor);
            SetBackground(previousBackColor);
        }

        /// <summary>
        /// Prints all the specified snippets and colors!
        /// </summary>
        /// <param name="totalText"></param>
        public static void Print(params CoolSnippet[] totalText)
        {
            if (totalText == null) return;
            foreach (var text in totalText) Print(text);
        }

        /// <summary>
        /// Prints the CoolText with all specified snippets and colors!
        /// </summary>
        /// <param name="coolText"></param>
        public static void Print(CoolText coolText)
        {
            if (coolText == null) return;
            Print(coolText.CoolSnippets);
        }

        /// <summary>
        /// Prints the string value with the specified text color.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="textColor"></param>
        public static void Print(string value, ConsoleColor? textColor)
        {
            ConsoleColor previousColor = GetForeground();
            SetForeground(textColor ?? previousColor);

            Print(value);

            SetForeground(previousColor);
        }

        /// <summary>
        /// Prints the string value with the specified colors.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        public static void Print(string value, ConsoleColor? textColor, ConsoleColor? backColor)
        {
            ConsoleColor previousBackColor = GetBackground();
            SetBackground(backColor ?? previousBackColor);

            Print(value, textColor);

            SetBackground(previousBackColor);
        }

        /// <summary>
        /// Writes the string representation of the specified object value to console.
        /// *Equivalent to Console.Write(object value)
        /// </summary>
        /// <param name="value"></param>
        public static void Print(object value)
        {
            Console.Write(value);
        }
        #endregion

        #region Println
        /// <summary>
        /// Writes the current line terminator.
        /// *Equivalent to Console.WriteLine()
        /// </summary>
        public static void Println()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Writes the specified string value to console, followed by the current line terminator.
        /// *Equivalent to Console.WriteLine(string value)
        /// </summary>
        /// <param name="value"></param>
        public static void Println(string value)
        {
            Print(value);
            Println();
        }

        /// <summary>
        /// 'Printlns' the specified text and colors of the CoolSnippet.
        /// </summary>
        /// <param name="text"></param>
        public static void Println(CoolSnippet text)
        {
            Print(text);
            Println();
        }

        /// <summary>
        /// 'Printlns' all the specified snippets and colors!
        /// </summary>
        /// <param name="totalText"></param>
        public static void Println(params CoolSnippet[] totalText)
        {
            Print(totalText);
            Println();
        }

        /// <summary>
        /// 'Printlns' the CoolText with all specified snippets and colors!
        /// </summary>
        /// <param name="coolText"></param>
        public static void Println(CoolText coolText)
        {
            Print(coolText);
            Println();
        }

        /// <summary>
        /// 'Printlns' the string value with the specified text color.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="textColor"></param>
        public static void Println(string value, ConsoleColor? textColor)
        {
            Print(value, textColor);
            Println();
        }

        /// <summary>
        /// 'Printlns' the string value with the specified colors.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        public static void Println(string value, ConsoleColor? textColor, ConsoleColor? backColor)
        {
            Print(value, textColor, backColor);
            Println();
        }

        /// <summary>
        /// 'Printlns' the string representation of the specified object value.
        /// *Equivalent to Console.WriteLine(object value)
        /// </summary>
        /// <param name="value"></param>
        public static void Println(object value)
        {
            Print(value);
            Println();
        }
        #endregion

        #region Other
        /// <summary>
        /// Prints new lines to console.
        /// </summary>
        /// <param name="lines">Number of lines to print.</param>
        public static void NewLine(int lines = 1)
        {
            for (int i = 0; i < lines; i++) Println();
        }

        /// <summary>
        /// 
        /// Invokes an action with predefined colors on the console.
        /// </summary>
        /// <param name="printing"></param>
        /// <param name="textColor"></param>
        public static void InvokeWithColors(Action printing, ConsoleColor textColor)
        {
            ConsoleColor previousColor = GetForeground();
            SetForeground(textColor);

            printing?.Invoke();

            SetForeground(previousColor);
        }

        /// <summary>
        /// Invokes an action with predefined colors on the console.
        /// </summary>
        /// <param name="printing"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        public static void InvokeWithColors(Action printing, ConsoleColor textColor, ConsoleColor backColor)
        {
            ConsoleColor previousBackColor = GetBackground();
            SetBackground(backColor);

            InvokeWithColors(printing, textColor);

            SetBackground(previousBackColor);
        }
        #endregion

        #region Private
        private static ConsoleColor GetForeground()
        {
            return Console.ForegroundColor;
        }
        private static void SetForeground(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        private static ConsoleColor GetBackground()
        {
            return Console.BackgroundColor;
        }
        private static void SetBackground(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        #endregion
    }
}