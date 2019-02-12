﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmaMachine.Machine
{
    public static class TranslationService
    {
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
                    list.Add(dic.First(x => x.Key == ch).Value);
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
            return dic.First(x => x.Value == number).Key;
        }
    }
}
