using Autofac.Extras.Moq;
using EnigmaLibrary.Components;
using NUnit.Framework;

namespace EnigmaLibrary.Tests.ComponentsTests.RotorProcessorTests
{
    [TestFixture]
    public class PassValueTests
    {
        private Rotor _rotor1;
        private Rotor _rotor2;
        private Rotor _rotor3;
        private Rotor _rotor4;
        private Rotor _rotor5;

        [SetUp]
        public void SetUp()
        {
            _rotor1 = new Rotor { Name = "I", TurnoverPosition = 16, Values = "EKMFLGDQVZNTOWYHXUSPAIBRCJ" };
            _rotor2 = new Rotor { Name = "II", TurnoverPosition = 4, Values = "AJDKSIRUXBLHWTMCQGZNPYFVOE" };
            _rotor3 = new Rotor { Name = "III", TurnoverPosition = 21, Values = "BDFHJLCPRTXVZNYEIWGAKMUSQO" };
            _rotor4 = new Rotor { Name = "IV", TurnoverPosition = 9, Values = "ESOVPZJAYQUIRHXLNFTGKDCMWB" };
            _rotor5 = new Rotor { Name = "V", TurnoverPosition = 25, Values = "VZBRGITYUPSDNHLXAWMJQOFECK" };
        }

        [Test]
        [TestCase('A', 'E', 0)]
        [TestCase('F', 'L', 15)]
        [TestCase('X', 'Y', 8)]
        [TestCase('Q', 'Z', 23)]
        public void PassValue_Rotor_I_UnderTests_ReturnsCorrectValue(char input, char expected, byte position)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var sut = mock.Create<RotorProcessor>();
                sut.Rotor = _rotor1;
                sut.Rotor.Position = position;
                var actual = sut.PassValue(input);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCase('A', 'A', 0)]
        [TestCase('B', 'J', 0)]
        [TestCase('D', 'R', 1)]
        [TestCase('A', 'Y', 14)]
        public void PassValue_Rotor_II_UnderTests_ReturnsCorrectValue(char input, char expected, byte position)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var sut = mock.Create<RotorProcessor>();
                sut.Rotor = _rotor2;
                sut.Rotor.Position = position;
                var actual = sut.PassValue(input);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCase('A', 'B', 0)]
        [TestCase('B', 'E', 1)]
        [TestCase('C', 'U', 14)]
        [TestCase('D', 'Y', 20)]
        public void PassValue_Rotor_III_UnderTests_ReturnsCorrectValue(char input, char expected, byte position)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var sut = mock.Create<RotorProcessor>();
                sut.Rotor = _rotor3;
                sut.Rotor.Position = position;
                var actual = sut.PassValue(input);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCase('A', 'E', 0)]
        [TestCase('B', 'N', 1)]
        [TestCase('H', 'R', 3)]
        [TestCase('X', 'R', 16)]
        public void PassValue_Rotor_IV_UnderTests_ReturnsCorrectValue(char input, char expected, byte position)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var sut = mock.Create<RotorProcessor>();
                sut.Rotor = _rotor4;
                sut.Rotor.Position = position;
                var actual = sut.PassValue(input);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        [TestCase('A', 'V', 0)]
        [TestCase('B', 'A', 1)]
        [TestCase('H', 'P', 3)]
        [TestCase('X', 'R', 16)]
        public void PassValue_Rotor_V_UnderTests_ReturnsCorrectValue(char input, char expected, byte position)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var sut = mock.Create<RotorProcessor>();
                sut.Rotor = _rotor5;
                sut.Rotor.Position = position;
                var actual = sut.PassValue(input);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}

