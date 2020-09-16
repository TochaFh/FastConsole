using System;
using System.Linq;

namespace FastConsole
{
    public static class FcExtensions
    {
        #region String
        /// <summary>
        /// Returns a simple ColorText base on the string with no specified colors.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static CoolSnippet I(this string text)
        {
            return new CoolSnippet(text);
        }

        /// <summary>
        /// Returns a CoolText with the specified text and textColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textColor">The text color</param>
        /// <returns></returns>
        public static CoolSnippet I(this string text, ConsoleColor? textColor)
        {
            return new CoolSnippet(text, textColor);
        }

        /// <summary>
        /// Returns an CoolText with the specified text, textColor and backColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textColor">The text color</param>
        /// <param name="backColor">The back color</param>
        /// <returns></returns>
        public static CoolSnippet I(this string text, ConsoleColor? textColor, ConsoleColor? backColor)
        {
            return new CoolSnippet(text, textColor, backColor);
        }

        /// <summary>
        /// Returns a CoolText with the specified string and backColor.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static CoolSnippet On(this string text, ConsoleColor? backColor)
        {
            return new CoolSnippet(text) { BackColor = backColor };
        }
        #endregion

        #region CoolSnippet
        /// <summary>
        /// Returns a new instance based on this CoolText with the specified backColor.
        /// </summary>
        /// <param name="text">The instance of IColorText</param>
        /// <param name="backColor">New back color</param>
        /// <returns></returns>
        public static CoolSnippet On(this CoolSnippet text, ConsoleColor? backColor)
        {
            return new CoolSnippet(text.Text, text.TextColor, backColor);
        }
        #endregion

        #region CoolText
        /// <summary>
        /// Returns a group of CoolTexts with specified -default- text color.
        /// * The colors inside have preference.
        /// </summary>
        /// <param name="coolText"></param>
        /// <param name="textColor"></param>
        /// <returns></returns>
        public static CoolText I(this CoolText coolText, ConsoleColor? textColor)
        {
            return (CoolText)coolText.CoolSnippets.Select(x => x.WithDefaultColors(textColor, null)).ToArray();
        }

        /// <summary>
        /// Returns a group of CoolTexts with specified -default- colors.
        /// * The colors inside have preference.
        /// </summary>
        /// <param name="coolText"></param>
        /// <param name="textColor"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static CoolText I(this CoolText coolText, ConsoleColor? textColor, ConsoleColor? backColor)
        {
            return (CoolText)coolText.CoolSnippets.Select(x => x.WithDefaultColors(textColor, backColor)).ToArray();
        }

        /// <summary>
        /// Returns a group of CoolTexts with specified -default- back color.
        /// * The colors inside have preference.
        /// </summary>
        /// <param name="coolText"></param>
        /// <param name="backColor"></param>
        /// <returns></returns>
        public static CoolText On(this CoolText coolText, ConsoleColor? backColor)
        {
            return (CoolText)coolText.CoolSnippets.Select(x => x.WithDefaultColors(null, backColor)).ToArray();
        }
        #endregion

        #region Print/Println
        public static void Print(this CoolText text)
        {
            Out.Print(text);
        }
        public static void Println(this CoolText text)
        {
            Out.Println(text);
        }
        public static void Print(this CoolSnippet text)
        {
            Out.Print(text);
        }
        public static void Println(this CoolSnippet text)
        {
            Out.Println(text);
        }
        public static string Print(this string text)
        {
            Out.Print(text);
            return text;
        }
        public static string Println(this string text)
        {
            Out.Println(text);
            return text;
        }
        #endregion

    }
}