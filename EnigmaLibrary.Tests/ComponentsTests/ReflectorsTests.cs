using EnigmaLibrary.Components;
using NUnit.Framework;
using System.Collections.Generic;

namespace EnigmaLibrary.Tests.ComponentsTests
{
    [TestFixture]
    public class ReflectorsTests
    {
        private Reflector _mkw_B;
        private Reflector _mkw_C;


        [SetUp]
        public void SetUp()
        {
            _mkw_B = new Reflector
            {
                Name = "UKW B",
                Values = new Dictionary<char, char>
                {
                    {'A','Y'},
                    {'B','R'},
                    {'C','U'},
                    {'D','H'},
                    {'E','Q'},
                    {'F','S'},
                    {'G','L'},
                    {'I','P'},
                    {'J','X'},
                    {'K','N'},
                    {'M','O'},
                    {'T','Z'},
                    {'V','W'}
                }
            };
            _mkw_C = new Reflector
            {
                Name = "UKW C",
                Values = new Dictionary<char, char>
                {
                    {'A','F'},
                    {'B','V'},
                    {'C','P'},
                    {'D','J'},
                    {'E','I'},
                    {'G','O'},
                    {'H','Y'},
                    {'K','R'},
                    {'L','Z'},
                    {'M','X'},
                    {'N','W'},
                    {'Q','T'},
                    {'S','U'}
                }
            };
        }

        [Test]
        [TestCase('A','Y')]
        [TestCase('B','R')]
        [TestCase('D','H')]
        [TestCase('Y','A')]
        [TestCase('H','D')]
        [TestCase('T','Z')]
        [TestCase('J','X')]
        public void ReflectValue_Reflector_MKW_B_WhenCalled_ReturnsReflectedValue(char value, char expected)
        {
            Assert.That(_mkw_B.ReflectValue(value), Is.EqualTo(expected));
        }

        [Test]
        [TestCase('A', 'F')]
        [TestCase('B', 'V')]
        [TestCase('D', 'J')]
        [TestCase('L', 'Z')]
        [TestCase('T', 'Q')]
        [TestCase('Q', 'T')]
        [TestCase('J', 'D')]
        public void ReflectValue_Reflector_MKW_C_WhenCalled_ReturnsReflectedValue(char value, char expected)
        {
            Assert.That(_mkw_C.ReflectValue(value), Is.EqualTo(expected));
        }
    }
}
