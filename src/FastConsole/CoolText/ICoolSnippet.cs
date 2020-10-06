using System;

namespace FastConsole
{
    /// <summary>
    /// Interface for CoolSnippet
    /// </summary>
    interface ICoolSnippet
    {
        /// <summary>
        /// The string text.
        /// </summary>
        /// <value></value>
        string Text { get; set; }

        /// <summary>
        /// The font color.
        /// </summary>
        /// <value></value>
        FColor TextColor { get; set; }

        /// <summary>
        /// The color behind the text.
        /// </summary>
        /// <value></value>
        FColor BackColor { get; set; }
    }
}