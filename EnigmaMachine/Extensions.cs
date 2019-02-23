using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine
{
    public static class Extensions
    {
        public static void PrintLines(int number)
        {
            var sb = new StringBuilder();
            sb.Append('=', number);
            Console.WriteLine(sb.ToString());
        }
    }
}
