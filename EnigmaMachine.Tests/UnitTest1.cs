using System;
using Xunit;
using EnigmaMachine.Rotors;
using EnigmaMachine.Reflectors;
using EnigmaMachine.Machine;

namespace EnigmaMachine.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            var rotorsRepository = new MemoryRepository();
            var rotorService = new RotatingService();

            var one = rotorsRepository.GetRotor("I");
            var two = rotorsRepository.GetRotor("II");
            var three = rotorsRepository.GetRotor("III");

            //var reflector = new Reflector();

            //var m = new Machine.Enigma(reflector);
            //m.Connector = new RotorsService(one, two, three, rotorService);

            //var value = m.Encode("BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHNXSHIUNTHEORXPQPKO");
            //var expected = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

            //Assert.Equal(expected, value);
        }

        [Fact]
        public void Test2()
        {
            var rotorsRepository = new MemoryRepository();
            var rotorService = new RotatingService();

            var one = rotorsRepository.GetRotor("I");
            var two = rotorsRepository.GetRotor("II");
            var three = rotorsRepository.GetRotor("III");

            //var reflector = new Reflector();

            //var m = new Machine.Enigma(reflector);
            //m.Connector = new RotorsService(one, two, three, rotorService);

            //var value = m.Encode("BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHNXSHIUNTHEORXPQPKOVHCBUBTZSZSOOSTGOTFSODBBZZLXLCYZXIFGWFDZEEQIBMGFJBWZFCKPFMGBXQCIVIBBRNCOCJUVYDKMVJPFMDRMTGLWFOZLXGJEYYQ");
            //var expected = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

            //Assert.Equal(expected, value);
        }

        [Fact]
        public void Test3()
        {
            var rotorsRepository = new MemoryRepository();
            var rotorService = new RotatingService();

            var one = rotorsRepository.GetRotor("I");
            var two = rotorsRepository.GetRotor("II");
            var three = rotorsRepository.GetRotor("III");

           // var reflector = new Reflector();

            //var m = new Machine.Enigma(reflector);
            //m.Connector = new RotorsService(one, two, three, rotorService);

            //var value = m.Encode("BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHNXSHIUNTHEORXPQPKOVHCBUBTZSZSOOSTGOTFSODBBZZLXLCYZXIFGWFDZEEQ");
            //var expected = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

            //Assert.Equal(expected, value);
        }

        [Fact]
        public void Test4()
        {
            var rotorsRepository = new MemoryRepository();
            var rotorService = new RotatingService();

            var one = rotorsRepository.GetRotor("I");
            var two = rotorsRepository.GetRotor("II");
            var three = rotorsRepository.GetRotor("III");

            //var reflector = new Reflector();

            //var m = new Machine.Enigma(reflector);
            //m.Connector = new RotorsService(one, two, three, rotorService);

            //var value = m.Encode("BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHNXSHIUNTHEORXPQPKOVHCBUBTZSZSOOSTGOTFSODBBZZLXLCYZXIFGWFDZEEQI");
            //var expected = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

            //Assert.Equal(expected, value);
        }
    }
}
