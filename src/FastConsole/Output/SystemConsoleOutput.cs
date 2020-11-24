using System;

namespace FastConsole
{
    /// <summary>
    /// The default implementation of IOutput that uses the 'System.Console' as output.
    /// </summary>
    public class SystemConsoleOutput : IOutput
    {
        /// <summary>
        /// Gets or sets the BackgroundColor of the console.
        /// </summary>
        /// <value></value>
        public ConsoleColor BackgroundColor { get => Console.BackgroundColor; set => Console.BackgroundColor = value; }

        /// <summary>
        /// Gets or sets the ForegroundColor of the console.
        /// </summary>
        /// <value></value>
        public ConsoleColor ForegroundColor { get => Console.ForegroundColor; set => Console.ForegroundColor = value; }

        /// <summary>
        /// Writes the string value to the console.
        /// </summary>
        public void Write(string value)
        {
            Console.Write(value);
        }
        
        /// <summary>
        /// Writes the string representation of the specified object value to the console.
        /// </summary>
        public void Write(object value)
        {
            Console.Write(value);
        }

        /// <summary>
        /// Writes the current line terminator.
        /// </summary>
        public void WriteLine()
        {
            Console.WriteLine();
        }
        
        /// <summary>
        /// Writes the string value to the console, followed by the current line terminator.
        /// </summary>
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
        
        /// <summary>
        /// Writes the string representation of the specified object value to the console, followed by the current line terminator.
        /// </summary>
        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}