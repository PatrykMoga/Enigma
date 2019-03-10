using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class Extensions
    {
        public static void PrintLines(string str)
        {
            var sb = new StringBuilder();
            sb.Append('=', str.Length);
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
    }
}
