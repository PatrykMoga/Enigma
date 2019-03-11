
using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaLibrary
{
    public class MemoryRepository
    {
        public List<DictionaryRotor> Rotors { get; }
        public List<DictionaryReflector> Reflectors { get; }

        public MemoryRepository()
        {
            Rotors = new List<DictionaryRotor>()
            {
                new DictionaryRotor{ Name = "I", TurnoverPosition = 17 , Values = new Dictionary<byte, byte>
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
                }},
                new DictionaryRotor{ Name = "II", TurnoverPosition = 4 , Values = new Dictionary<byte, byte>
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
                }},
                new DictionaryRotor{ Name = "III", TurnoverPosition = 21 , Values = new Dictionary<byte, byte>
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
                }},

                new DictionaryRotor{ Name = "IV", TurnoverPosition = 0 , Values = new Dictionary<byte, byte>
                {

                }},
                new DictionaryRotor{ Name = "V", TurnoverPosition = 0 , Values = new Dictionary<byte, byte>
                {

                }}

            };

            Reflectors = new List<DictionaryReflector>()
            {
                new DictionaryReflector{ Name = "UKW B", Values = new Dictionary<byte, byte>
                {
                    {0,24},
                    {1,17},
                    {2,20},
                    {3,7},
                    {4,16},
                    {5,18},
                    {6,11},
                    {8,15},
                    {9,23},
                    {10,13},
                    {12,14},
                    {19,25},
                    {21,22}
                }},
                new DictionaryReflector{ Name = "UKW C", Values = new Dictionary<byte, byte>
                {
                    {0,5},
                    {1,21},
                    {2,15},
                    {3,9},
                    {4,8},
                    {6,14},
                    {7,24},
                    {10,17},
                    {11,25},
                    {12,23},
                    {13,22},
                    {16,19},
                    {18,20}
                }}
            };
        }
    }
}
