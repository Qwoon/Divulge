using GEmojiSharp;
using System;
using System.Text.RegularExpressions;

namespace Divulge
{
    public static class TextMessageFormatter
    {
        private static readonly string _newLinePattern = @"\n";

        public static string ConvertNewLines(this string text)
        {
            return Regex.Replace(text, _newLinePattern, Environment.NewLine);
        }

        public static string ConvertEmojis(this string text)
        {
            return Emoji.Emojify(text);
        }
    }
}
