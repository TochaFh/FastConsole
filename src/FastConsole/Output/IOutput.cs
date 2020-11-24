using System;

namespace FastConsole
{
    /// <summary>
    /// Represents an output. It can be a console, a file, etc.
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// Gets or sets the BackgroundColor of the output.
        /// </summary>
        /// <value></value>
        ConsoleColor BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the ForegroundColor of the output.
        /// </summary>
        /// <value></value>
        ConsoleColor ForegroundColor { get; set; }

        /// <summary>
        /// Writes the string value to the output.
        /// </summary>
        void Write(string value);
        
        /// <summary>
        /// Writes the string representation of the specified object value to the output.
        /// </summary>
        void Write(object value);

        /// <summary>
        /// Writes the current line terminator.
        /// </summary>
        void WriteLine();
        
        /// <summary>
        /// Writes the string value to the output, followed by the current line terminator.
        /// </summary>
        void WriteLine(string value);
        
        /// <summary>
        /// Writes the string representation of the specified object value to the output, followed by the current line terminator.
        /// </summary>
        void WriteLine(object value);
    }
}