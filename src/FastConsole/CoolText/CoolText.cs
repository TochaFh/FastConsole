using System;
using System.Linq;
using System.Text;

namespace FastConsole
{
    /// <summary>
    /// Represents a super cool text with many colors!
    /// A group of CoolSnippets.
    /// </summary>
    public sealed class CoolText
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of CoolText with the specified CoolSnippets.
        /// </summary>
        /// <param name="coolTexts"></param>
        public CoolText(params CoolSnippet[] coolSnippets)
        {
            CoolSnippets = coolSnippets ?? throw new System.ArgumentNullException("coolSnippets");
        }
        #endregion
        
        internal CoolSnippet[] CoolSnippets { get; private set; }

        /// <summary>
        /// Returns the concatenated (string) text of all CoolSnippets in this instance of CoolText.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var snippet in CoolSnippets) sb.Append(snippet.Text);
            return sb.ToString();
        }

        #region Operators
        /// <summary>
        /// Creates a CoolText with the specified CoolSnippets in the array.
        /// </summary>
        /// <param name="array"></param>
        public static implicit operator CoolText(CoolSnippet[] array) => new CoolText(array);

        /// <summary>
        /// Creates a CoolText with the specified CoolSnippet.
        /// </summary>
        /// <param name="coolSnippet"></param>
        public static explicit operator CoolText(CoolSnippet coolSnippet) => new CoolText(coolSnippet);

        /// <summary>
        /// Returns a CoolText containing all CoolSnippets of two CoolTexts.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static CoolText operator +(CoolText a, CoolText b)
        {
            return new CoolText(a.CoolSnippets.Concat(b.CoolSnippets).ToArray());
        }

        /// <summary>
        /// Returns a CoolText with all CoolSnippets of 'a' (left) and 'b' (right) converted to CoolSnippet.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static CoolText operator +(CoolText a, string b) => a + b.I();

        /// <summary>
        /// Returns a CoolText with 'a' (left) converted to CoolSnippet and  all CoolSnippets of 'b' (right).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static CoolText operator +(string a, CoolText b) => a.I() + b;

        #endregion
    }
}