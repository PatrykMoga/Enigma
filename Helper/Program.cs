using System;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectorConstruct();
            
        }

        private static void ReflectorConstruct()
        {
            var str = "AF  BV  CP  DJ  EI  GO  HY  KR  LZ  MX  NW  QT  SU";
            var list = str.Split("  ");
            foreach (var item in list)
            {
                Console.WriteLine($"{{'{item[0]}','{item[1]}'}},");
            }
        }
    }
}
