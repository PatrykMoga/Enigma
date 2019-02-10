using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnigmaMachine.Rotors;

namespace EnigmaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Jakiśtam
            var rotor3Values = new Dictionary<byte, byte>()
            {
                {0,1},
                {1,3},
                {2,5},
                {3,7},
                {4,9},
                {5,11},
                {6,2},
                {7,15},
                {8,17},
                {9,19},
                {10,23},
                {11,21},
                {12,25},
                {13,13},
                {14,24},
                {15,4},
                {16,8},
                {17,22},
                {18,6},
                {19,0},
                {20,10},
                {21,12},
                {22,20},
                {23,18},
                {24,16},
                {25,14}
            };
            var rotor2Values = new Dictionary<byte, byte>()
            {
                {0,0},
                {1,9},
                {2,3},
                {3,10},
                {4,18},
                {5,8},
                {6,17},
                {7,20},
                {8,23},
                {9,1},
                {10,11},
                {11,7},
                {12,22},
                {13,19},
                {14,12},
                {15,2},
                {16,16},
                {17,6},
                {18,25},
                {19,13},
                {20,15},
                {21,24},
                {22,5},
                {23,21},
                {24,14},
                {25,4}
            };
            var rotor1Values = new Dictionary<byte, byte>()
            {
                {0,4},
                {1,10},
                {2,12},
                {3,5},
                {4,11},
                {5,6},
                {6,3},
                {7,16},
                {8,21},
                {9,25},
                {10,13},
                {11,19},
                {12,14},
                {13,22},
                {14,24},
                {15,7},
                {16,23},
                {17,20},
                {18,18},
                {19,15},
                {20,0},
                {21,8},
                {22,1},
                {23,17},
                {24,2},
                {25,9}
            };


            var rotor111 = new RotorService(rotor1Values, 0);
            var rotor222 = new RotorService(rotor2Values, 0);
            var rotor333 = new RotorService(rotor3Values, 0);
            #endregion
            //var list3 = new List<byte>
            //{
            //    1, 3, 5, 7, 9, 11, 2, 15, 17, 19, 23, 21, 25, 13, 24, 4, 8, 22, 6, 0, 10, 12, 20, 18, 16, 14
            //};
            var list3 = new List<int>
            {
                1, 2, 3, 4, 5, 6, -4, 8, 9, 10, 13, 10, -13, 0, 10, -11, -8, 5, -12, -19, -10, -9, -2, -5, -8, -11
            };

            var list2 = new List<int>
            {
                0, 8, 1, 7, 14, 3, 11, 13, 15, -8, 1, -4, 10, 6, -2, -13, 16, -11, 7, -6, -5, 3, -17, -2, -10, -21
            };

            var list1 = new List<int>
            {
                4, 9, 10, 2, 7, 1, -3, 9, 13, 16, 3, 8, 2, 9, 10, -8, 7, 3, 0, -4, -20, -13, -11, -6, -22, -16 
            };

            
            //var rotorr1 = new RotorS(list1);
            //var rotorr2 = new RotorS(list2);
            //var rotorr3 = new RotorS(list3);

            var rotorr1 = new Rotor(list1);
            var rotorr2 = new Rotor(list2);
            var rotorr3 = new Rotor(list3);

            //rotor333.Position += 3;
            //foreach (var item in rotor333.Rotor())
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            Encode(rotor111, rotor222, rotor333, "BARBARA");

        }

        public static void Encode(Rotor rotor1, Rotor rotor2, Rotor rotor3,string str)
        {
            int buffer;
            var strBuilder = new StringBuilder();
            foreach (var item in ConvertStringToInt(str))
            {
                rotor3.Rotate();
                buffer = rotor3.GetValue(item);
                buffer = rotor2.GetValue(buffer);
                buffer = rotor1.GetValue(buffer);

                buffer = Reflector_B(buffer);

                buffer = rotor1.GetIndex(buffer);
                buffer = rotor2.GetIndex(buffer);
                buffer = rotor3.GetIndex(buffer);
                
                //strBuilder.Append(buffer + " ");
                strBuilder.Append(ConvertIntToString((byte)buffer));


            }
            Console.WriteLine(strBuilder);
        }

        public static void Encode(Dictionary<byte, byte> rotor3, Dictionary<byte, byte> rotor2, Dictionary<byte, byte> rotor1)
        {

            byte buffer;


        }

        public static void Encode(RotorService rotor1, RotorService rotor2, RotorService rotor3, string str)
        {

            byte buffer;
            var strBuilder = new StringBuilder();
            foreach (var item in ConvertStringToInt(str))
            {
                rotor3.Position++;
                buffer = rotor3.GetValueByIndex(item);
                buffer = rotor2.GetValueByIndex(buffer);
                buffer = rotor1.GetValueByIndex(buffer);

                buffer = (byte)Reflector_B(buffer);
                
                buffer = rotor1.GetIndexByValue(buffer);
                buffer = rotor2.GetIndexByValue(buffer);
                buffer = rotor3.GetIndexByValue(buffer);
                strBuilder.Append(ConvertIntToString(buffer));

            }
            Console.WriteLine(strBuilder);
        }

        public static void Encode(RotorS rotor1, RotorS rotor2, RotorS rotor3, string str)
        {

            byte buffer;
            var strBuilder = new StringBuilder();
            foreach (var item in ConvertStringToInt(str))
            {
                rotor3.Rotate();
                buffer = (byte)rotor3.GetValue(item);
                buffer = (byte)rotor2.GetValue(buffer);
                buffer = (byte)rotor1.GetValue(buffer);

                buffer = (byte)Reflector_B(buffer);
                
                buffer = rotor1.GetIndex(buffer);
                buffer = rotor2.GetIndex(buffer);
                buffer = rotor3.GetIndex(buffer);

                //strBuilder.Append(buffer + " ");
                strBuilder.Append((char)buffer);


            }
            Console.WriteLine(strBuilder);
        }

        public static int Reflector_B(int buffer)
        {
             switch (buffer)
            {
                case 0:
                   return 24;
                case 1:
                    return 17;
                case 2:
                    return 20;
                case 3:
                    return 7;
                case 4:
                    return 16;
                case 5:
                    return 18;
                case 6:
                    return 11;
                case 8:
                    return 15;
                case 9:
                    return 23;
                case 10:
                    return 13;
                case 12:
                    return 14;
                case 19:
                    return 25;
                case 21:
                    return 22;
                case 24:
                    return 0;
                case 17:
                    return 1;
                case 20:
                    return 2;
                case 7:
                    return 3;
                    break;
                case 16:
                    return 4;
                    break;
                case 18:
                    return 5;
                    break;
                case 11:
                    return 6;
                    break;
                case 15:
                    return 8;
                    break;
                case 23:
                    return 9;
                    break;
                case 13:
                    return 10;
                    break;
                case 14:
                    return 12;
                    break;
                case 25:
                    return 19;
                    break;
                case 22:
                    return 21;
                    break;
                default:
                    return 0;
            }
        }

        public static List<byte> ConvertStringToInt(string str)
        {
            var list = new List<byte>();
            var dic = new Dictionary<char, byte>
            {
                {'A',0},
                {'B',1},
                {'C',2},
                {'D',3},
                {'E',4},
                {'F',5},
                {'G',6},
                {'H',7},
                {'I',8},
                {'J',9},
                {'K',10},
                {'L',11},
                {'M',12},
                {'N',13},
                {'O',14},
                {'P',15},
                {'Q',16},
                {'R',17},
                {'S',18},
                {'T',19},
                {'U',20},
                {'V',21},
                {'W',22},
                {'X',23},
                {'Y',24},
                {'Z',25}
            };
            foreach (var ch in str.ToUpper())
            {
                if (dic.Keys.Contains(ch))
                {
                    list.Add(dic.FirstOrDefault(x => x.Key == ch).Value);
                }
            }
            return list;
        }

        public static char ConvertIntToString(byte number)
        {

            var dic = new Dictionary<char, byte>
            {
                {'A',0},
                {'B',1},
                {'C',2},
                {'D',3},
                {'E',4},
                {'F',5},
                {'G',6},
                {'H',7},
                {'I',8},
                {'J',9},
                {'K',10},
                {'L',11},
                {'M',12},
                {'N',13},
                {'O',14},
                {'P',15},
                {'Q',16},
                {'R',17},
                {'S',18},
                {'T',19},
                {'U',20},
                {'V',21},
                {'W',22},
                {'X',23},
                {'Y',24},
                {'Z',25}
            };
            return dic.FirstOrDefault(x => x.Value == number).Key;
        }
    }
}
