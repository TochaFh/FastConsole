using System;

namespace FastConsole
{
    /// <summary>
    /// The main static class of FastConsole for printing values to the console.
    /// Strings, objects, CoolTexts, CoolSnippets...
    /// </summary>
    public static class Out
    {
        private static readonly object lockP = new object();

        #region Print
        /// <summary>
        /// Writes the specified string value to console.
        /// *Equivalent to Console.Write(string value)
        /// </summary>
        /// <param name="value"></param>
        public static void Print(string value)
        {
            lock (lockP)
            {
                Console.Write(value);
            }
        }

        /// <summary>
        /// Prints the specified text and colors of the CoolSnippet.
        /// </summary>
        /// <param name="text"></param>
        public static void Print(CoolSnippet text)
        {
            lock (lockP)
            {
                if (text == null) return;

                ConsoleColor previousForeColor = GetForeground();
                SetForeground(text.TextColor.MatchColor(previousForeColor));

                ConsoleColor previousBackColor = GetBackground();
                SetBackground(text.BackColor.MatchColor(previousBackColor));

                Console.Write(text.Text);

                SetForeground(previousForeColor);
                SetBackground(previousBackColor);
            }
        }

        /// <summary>
        /// Prints all the specified snippets and colors!
        /// </summary>
        /// <param name="totalText"></param>
        public static void Print(params CoolSnippet[] totalText)
        {
            lock (lockP)
            {
                if (totalText == null) return;
                foreach (var text in totalText) Print(text);
            }
        }

        /// <summary>
        /// Prints the CoolText with all specified snippets and colors!
        /// </summary>
        /// <param name="coolText"></param>
        public static void Print(CoolText coolText)
        {
            lock (lockP)
            {
                if (coolText == null) return;
                Print(coolText.CoolSnippets);
            }
        }

        /// <summary>
        /// Prints the string value with the specified text color.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="textColor"></param>
        public static void Print(string value, FColor textColor)
        {
            lock (lockP)
            {
                ConsoleColor previousColor = GetForeground();
                SetForeground(textColor.MatchColor(previousColor));

                Print(value);

                SetForeground(previousColor);
            }
        }

        /// <summary>
        /// Prints the string value with the specified colors.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        public static void Print(string value, FColor textColor, FColor backColor)
        {
            lock (lockP)
            {
                ConsoleColor previousBackColor = GetBackground();
                SetBackground(backColor.MatchColor(previousBackColor));

                Print(value, textColor);

                SetBackground(previousBackColor);
            }
        }

        /// <summary>
        /// Writes the string representation of the specified object value to console.
        /// *Equivalent to Console.Write(object value)
        /// </summary>
        /// <param name="value"></param>
        public static void Print(object value)
        {
            lock (lockP)
            {
                Console.Write(value);
            }
        }
        #endregion

        #region Println
        /// <summary>
        /// Writes the current line terminator.
        /// *Equivalent to Console.WriteLine()
        /// </summary>
        public static void Println()
        {
            lock (lockP)
            {
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Writes the specified string value to console, followed by the current line terminator.
        /// *Equivalent to Console.WriteLine(string value)
        /// </summary>
        /// <param name="value"></param>
        public static void Println(string value)
        {
            lock (lockP)
            {
                Print(value);
                Println();
            }
        }

        /// <summary>
        /// 'Printlns' the specified text and colors of the CoolSnippet.
        /// </summary>
        /// <param name="text"></param>
        public static void Println(CoolSnippet text)
        {
            lock (lockP)
            {
                Print(text);
                Println();
            }
        }

        /// <summary>
        /// 'Printlns' all the specified snippets and colors!
        /// </summary>
        /// <param name="totalText"></param>
        public static void Println(params CoolSnippet[] totalText)
        {
            lock (lockP)
            {
                Print(totalText);
                Println();
            }
        }

        /// <summary>
        /// 'Printlns' the CoolText with all specified snippets and colors!
        /// </summary>
        /// <param name="coolText"></param>
        public static void Println(CoolText coolText)
        {
            lock (lockP)
            {
                Print(coolText);
                Println();
            }
        }

        /// <summary>
        /// 'Printlns' the string value with the specified text color.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="textColor"></param>
        public static void Println(string value, FColor textColor)
        {
            lock (lockP)
            {
                Print(value, textColor);
                Println();
            }
        }

        /// <summary>
        /// 'Printlns' the string value with the specified colors.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        public static void Println(string value, FColor textColor, FColor backColor)
        {
            lock (lockP)
            {
                Print(value, textColor, backColor);
                Println();
            }
        }

        /// <summary>
        /// 'Printlns' the string representation of the specified object value.
        /// *Equivalent to Console.WriteLine(object value)
        /// </summary>
        /// <param name="value"></param>
        public static void Println(object value)
        {
            lock (lockP)
            {
                Print(value);
                Println();
            }
        }
        #endregion

        #region Other
        /// <summary>
        /// Prints new lines to console.
        /// </summary>
        /// <param name="lines">Number of lines to print.</param>
        public static void NewLine(int lines = 1)
        {
            lock (lockP)
            {
                for (int i = 0; i < lines; i++) Println();
            }
        }

        /// <summary>
        /// 
        /// Invokes an action with predefined colors on the console.
        /// </summary>
        /// <param name="printing"></param>
        /// <param name="textColor"></param>
        public static void InvokeWithColors(Action printing, FColor textColor)
        {
            lock (lockP)
            {
                ConsoleColor previousColor = GetForeground();
                SetForeground(textColor.MatchColor(previousColor));

                printing?.Invoke();

                SetForeground(previousColor);
            }
        }

        /// <summary>
        /// Invokes an action with predefined colors on the console.
        /// </summary>
        /// <param name="printing"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        public static void InvokeWithColors(Action printing, FColor textColor, FColor backColor)
        {
            lock (lockP)
            {
                ConsoleColor previousBackColor = GetBackground();
                SetBackground(backColor.MatchColor(previousBackColor));

                InvokeWithColors(printing, textColor);

                SetBackground(previousBackColor);
            }
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