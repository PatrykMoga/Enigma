using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaLibrary.Decoding
{
    public static class InputAdapter
    {
        public static string AdaptInput(this string input)
        {
            var builder = new StringBuilder();
            foreach (var ch in input.ToUpper())
            {
                if (ch >= 65 && ch <= 90)
                {
                    builder.Append(ch);
                }
            }
            return builder.ToString();
        }
    }
}
