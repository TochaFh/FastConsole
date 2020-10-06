using System;
using System.Linq;

namespace FastConsole
{
    /// <summary>
    /// A part of text with one specified text color and one back color.
    /// </summary>
    public sealed class CoolSnippet : ICoolSnippet
    {
        #region Constructors
        internal CoolSnippet(string text)
        {
            Text = text;
        }
        internal CoolSnippet(string text, FColor textColor) : this(text)
        {
            TextColor = textColor;
        }
        internal CoolSnippet(string text, FColor textColor, FColor backColor) : this(text, textColor)
        {
            BackColor = backColor;
        }
        #endregion

        /// <summary>
        /// The string text.
        /// </summary>
        /// <value></value>
        public string Text { get; set; }

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

        internal CoolSnippet WithDefaultColors(FColor defTextColor, FColor defBackColor)
        {
            return new CoolSnippet(this.Text, TextColor.WithDefault(defTextColor), BackColor.WithDefault(defBackColor));
        }

        #region Operators
        /// <summary>
        /// Creates a simple CoolSnippet with the string.
        /// </summary>
        /// <param name="text"></param>
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

        /// <summary>
        /// Returns a CoolText containing the two snippets. The second is based on the string representation of object b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static CoolText operator +(CoolSnippet a, object b) => (a + b.ToString());

        /// <summary>
        /// Returns a CoolText containing the two snippets. The first is based on the string representation of object a.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static CoolText operator +(object a, CoolSnippet b) => (a.ToString() + b);
        #endregion

        /// <summary>
        /// Returns the Text (CoolSnippet.Text) of this instance of CoolSnippet.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => this.Text;
    }
}