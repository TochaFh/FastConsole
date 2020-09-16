using System;
using System.Linq;

namespace FastConsole
{
    public sealed class CoolSnippet : ICoolSnippet
    {
        #region Constructors
        internal CoolSnippet(string text)
        {
            Text = text;
        }
        internal CoolSnippet(string text, ConsoleColor? textColor) : this(text)
        {
            TextColor = textColor;
        }
        internal CoolSnippet(string text, ConsoleColor? textColor, ConsoleColor? backColor) : this(text, textColor)
        {
            BackColor = backColor;
        }
        #endregion

        public string Text { get; set; }
        public ConsoleColor? TextColor { get; set; } = null;
        public ConsoleColor? BackColor { get; set; } = null;


        /// <summary>
        /// Returns the Text (CoolSnippet.Text) of this instance of CoolSnippet.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => this.Text;

        internal CoolSnippet WithDefaultColors(ConsoleColor? defTextColor, ConsoleColor? defBackColor)
        {
            return new CoolSnippet(this.Text, TextColor ?? defTextColor, BackColor ?? defBackColor);
        }

        #region Operators
        public static implicit operator CoolSnippet(string text) => new CoolSnippet(text);

        /// <summary>
        /// Returns a CoolText containing the two snippets.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static CoolText operator +(CoolSnippet a, CoolSnippet b)
        {
            return new CoolText(a, b);
        }

        /// <summary>
        /// Returns a cooltext containig the (left) CoolText snippets and the right snippet.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static CoolText operator +(CoolText a, CoolSnippet b)
        {
            return (CoolText)(a.CoolSnippets.Concat(new[] { b }).ToArray());
        }

        /// <summary>
        /// Returns a cooltext containig the left snippet and the (right) CoolText snippets.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static CoolText operator +(CoolSnippet a, CoolText b)
        {
            return (CoolText)(new[] { a }.Concat(b.CoolSnippets).ToArray());
        }
        #endregion
    }
}