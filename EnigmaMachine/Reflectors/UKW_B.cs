using System;
using System.Collections.Generic;
using System.Text;

namespace EnigmaMachine.Reflectors
{
    public class UKW_B : IReflector
    {
        public byte ReflectValue(byte n)
        {
            switch (n)
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
                case 16:
                    return 4;
                case 18:
                    return 5;                    
                case 11:
                    return 6;                   
                case 15:
                    return 8;                  
                case 23:
                    return 9;                   
                case 13:
                    return 10;                   
                case 14:
                    return 12;                  
                case 25:
                    return 19;                   
                case 22:
                    return 21;                  
                default:
                    return 0;
            }
        }
    }
}
