using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmaMachine.Rotors
{
    public class RotorsRepository
    {
        private readonly Dictionary<string, Rotor> _rotors;

        public RotorsRepository()
        {
            _rotors = new Dictionary<string, Rotor>()
            {
                {"I",new Rotor(new Dictionary<byte, byte>(){
                    { 0,4},
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
                    })},
                {"II",new Rotor(new Dictionary<byte, byte>(){{0,0},
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
                    {25,4} }) },
                {"III",new Rotor(new Dictionary<byte, byte>(){
                    { 0,1},
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
                    {25,14} }) }
            };
        }

        public Rotor GetRotor(string name)
        {
            _rotors.TryGetValue(name, out Rotor rotor);
            return rotor;
        }
    }
}
