using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class Extensions
    {
        public static void PrintLines(int length)
        {
            var sb = new StringBuilder();
            sb.Append('=', length);
            Console.WriteLine(sb.ToString());
        }

        public static void PrintInLines(string str)
        {
            var sb = new StringBuilder();
            sb.Append('=', str.Length);
            sb.Append($"\n{str}\n");
            sb.Append('=', str.Length);
            Console.WriteLine(sb.ToString());
        }

        public static void PrintInLines(string str, int max)
        {
            var sb = new StringBuilder();
            sb.Append('=', str.Length < max ? str.Length : max);
            sb.Append($"\n{str}\n");
            sb.Append('=', str.Length < max ? str.Length : max);
            Console.WriteLine(sb.ToString());
        }
    }
}
