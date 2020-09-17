using System;

namespace FastConsole
{
    public static class Out
    {
        #region Print
        public static void Print(string value)
        {
            Console.Write(value);
        }
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
        public static void Print(params CoolSnippet[] totalText)
        {
            if (totalText == null) return;
            foreach (var text in totalText) Print(text);
        }
        public static void Print(CoolText coolText)
        {
            if (coolText == null) return;
            Print(coolText.CoolSnippets);
        }
        public static void Print(string value, ConsoleColor? textColor)
        {
            ConsoleColor previousColor = GetForeground();
            SetForeground(textColor ?? previousColor);

            Print(value);

            SetForeground(previousColor);
        }
        public static void Print(string value, ConsoleColor? textColor, ConsoleColor? backColor)
        {
            ConsoleColor previousBackColor = GetBackground();
            SetBackground(backColor ?? previousBackColor);

            Print(value, textColor);

            SetBackground(previousBackColor);
        }
        public static void Print(object value)
        {
            Console.Write(value);
        }
        #endregion

        #region Println
        public static void Println()
        {
            Console.WriteLine();
        }
        public static void Println(string value)
        {
            Print(value);
            Println();
        }
        public static void Println(CoolSnippet text)
        {
            Print(text);
            Println();
        }
        public static void Println(params CoolSnippet[] totalText)
        {
            Print(totalText);
            Println();
        }
        public static void Println(CoolText coolText)
        {
            Print(coolText);
            Println();
        }
        public static void Println(string value, ConsoleColor? textColor)
        {
            Print(value, textColor);
            Println();
        }
        public static void Println(string value, ConsoleColor? textColor, ConsoleColor? backColor)
        {
            Print(value, textColor, backColor);
            Println();
        }
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
        public static void InvokeWithColors(Action printing, ConsoleColor textColor)
        {
            ConsoleColor previousColor = GetForeground();
            SetForeground(textColor);

            printing?.Invoke();

            SetForeground(previousColor);
        }
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