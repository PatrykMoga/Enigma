using System;
using System.Collections.Generic;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var input = Console.ReadLine();
            var splitted = input.Split(", ");

            var s = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Console.WriteLine(s.Length);

            //for (int i = 0; i < splitted.Length - 1; i += 2)
            //{
            //    Console.WriteLine("{" + $"\'{splitted[i]}\',{splitted[i + 1]}" + "},");
            //}

            //for (int i = 0; i < splitted.Length; i++)
            //{
            //    Console.WriteLine("{" + i + "," + splitted[i] + "},");
            //}

            //for (int i = 0; i < splitted.Length; i++)
            //{
            //    Console.Write($"{splitted[i]}, ");
            //}


           
        }

        public void pfff()
        {
            var list3 = new List<byte>
            {
                1, 3, 5, 7, 9, 11, 2, 15, 17, 19, 23, 21, 25, 13, 24, 4, 8, 22, 6, 0, 10, 12, 20, 18, 16, 14
            };

            var list2 = new List<byte>
            {
                0, 9, 3, 10, 18, 8, 17, 20, 23, 1, 11, 7, 22, 19, 12, 2, 16, 6, 25, 13, 15, 24, 5, 21, 14, 4
            };

            var list1 = new List<byte>
            {
                4, 10, 12, 5, 11, 6, 3, 16, 21, 25, 13, 19, 14, 22, 24, 7, 23, 20, 18, 15, 0, 8, 1, 17, 2, 9
            };
        }
    }
}
