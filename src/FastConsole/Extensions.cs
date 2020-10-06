using System;
using System.Linq;

namespace FastConsole
{
    /// <summary>
    /// The extension class of FastConsole. Focused in strings, CoolSnippets and CoolTexts conversions and shortcuts.
    /// </summary>
    public static class FcExtensions
    {
        #region String
        /// <summary>
        /// Returns a simple CoolSnippet with the string and no specified colors.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static CoolSnippet I(this string text)
        {
            return new CoolSnippet(text);
        }

        /// <summary>
        /// Returns a CoolSnippet with the specified text and textColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textColor">The text color</param>
        /// <returns></returns>
        public static CoolSnippet I(this string text, FColor textColor)
        {
            return new CoolSnippet(text, textColor);
        }

        /// <summary>
        /// Returns an CoolSnippet with the specified text, textColor and backColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textColor">The text color</param>
        /// <param name="backColor">The back color</param>
        /// <returns></returns>
        public static CoolSnippet I(this string text, FColor textColor, FColor backColor)
        {
            return new CoolSnippet(text, textColor, backColor);
        }

        /// <summary>
        /// Returns a CoolSnippet with the specified string and backColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static CoolSnippet On(this string text, FColor backColor)
        {
            return new CoolSnippet(text) { BackColor = backColor };
        }
        #endregion

        #region ValueType
        /// <summary>
        /// Returns a simple CoolSnippet with the string representation of this value and no specified colors.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static CoolSnippet I(this ValueType text)
        {
            return new CoolSnippet(text.ToString());
        }

        /// <summary>
        /// Returns a CoolSnippet with the string representation of this value and the specified textColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textColor">The text color</param>
        /// <returns></returns>
        public static CoolSnippet I(this ValueType text, FColor textColor)
        {
            return new CoolSnippet(text.ToString(), textColor);
        }

        /// <summary>
        /// Returns an CoolSnippet with the string representation of this value and the specified textColor and backColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textColor">The text color</param>
        /// <param name="backColor">The back color</param>
        /// <returns></returns>
        public static CoolSnippet I(this ValueType text, FColor textColor, FColor backColor)
        {
            return new CoolSnippet(text.ToString(), textColor, backColor);
        }

        /// <summary>
        /// Returns a CoolSnippet with the string representation of this value and the specified backColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static CoolSnippet On(this ValueType text, FColor backColor)
        {
            return new CoolSnippet(text.ToString()) { BackColor = backColor };
        }
        #endregion

        #region CoolSnippet
        /// <summary>
        /// Returns a CoolSnippet based on this CoolSnippet with a new textColor.
        /// </summary>
        /// <param name="text">The instance of IColorText</param>
        /// <param name="textColor">New text color</param>
        /// <returns></returns>
        public static CoolSnippet I(this CoolSnippet text, FColor textColor)
        {
            return new CoolSnippet(text.Text, textColor, text.BackColor);
        }

        /// <summary>
        /// Returns a CoolSnippet based on this CoolSnippet with a new backColor.
        /// </summary>
        /// <param name="text">The instance of IColorText</param>
        /// <param name="backColor">New back color</param>
        /// <returns></returns>
        public static CoolSnippet On(this CoolSnippet text, FColor backColor)
        {
            return new CoolSnippet(text.Text, text.TextColor, backColor);
        }
        #endregion

        #region CoolText
        /// <summary>
        /// Returns a CoolText with the specified default text color.
        /// * The colors inside have preference.
        /// </summary>
        /// <param name="coolText"></param>
        /// <param name="textColor"></param>
        /// <returns></returns>
        public static CoolText I(this CoolText coolText, FColor textColor)
        {
            return (CoolText)coolText.CoolSnippets.Select(x => x.WithDefaultColors(textColor, FColor.Default)).ToArray();
        }

        /// <summary>
        /// Returns a CoolText with the specified default colors.
        /// * The colors inside have preference.
        /// </summary>
        /// <param name="coolText"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static CoolText I(this CoolText coolText, FColor textColor, FColor backColor)
        {
            return (CoolText)coolText.CoolSnippets.Select(x => x.WithDefaultColors(textColor, backColor)).ToArray();
        }

        /// <summary>
        /// Returns a CoolText with the specified default back color.
        /// * The colors inside have preference.
        /// </summary>
        /// <param name="coolText"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static CoolText On(this CoolText coolText, FColor backColor)
        {
            return (CoolText)coolText.CoolSnippets.Select(x => x.WithDefaultColors(FColor.Default, backColor)).ToArray();
        }
        #endregion

        #region Print/Println
        /// <summary>
        /// Prints the CoolText.
        /// </summary>
        /// <param name="text"></param>
        public static void Print(this CoolText text)
        {
            Out.Print(text);
        }

        /// <summary>
        /// 'Printlns' the CoolText.
        /// </summary>
        /// <param name="text"></param>
        public static void Println(this CoolText text)
        {
            Out.Println(text);
        }
        
        /// <summary>
        /// Prints the CoolSnippet.
        /// </summary>
        /// <param name="text"></param>
        public static void Print(this CoolSnippet text)
        {
            Out.Print(text);
        }
        
        /// <summary>
        /// 'Printlns' the CoolSnippet.
        /// </summary>
        /// <param name="text"></param>
        public static void Println(this CoolSnippet text)
        {
            Out.Println(text);
        }
        
        /// <summary>
        /// Prints the value of the string and returns it (the string).
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Print(this string text)
        {
            Out.Print(text);
            return text;
        }
        
        /// <summary>
        /// 'Printlns' the value of the string and returns it (the string).
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Println(this string text)
        {
            Out.Println(text);
            return text;
        }
        #endregion
    }
}