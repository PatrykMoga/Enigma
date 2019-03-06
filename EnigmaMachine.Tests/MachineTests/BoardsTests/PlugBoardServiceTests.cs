using System;
using System.Collections.Generic;
using System.Text;
using EnigmaMachine.Machine.Boards;
using NUnit.Framework;

namespace EnigmaMachine.Tests.MachineTests.BoardsTests
{
    [TestFixture]
    public class PlugBoardServiceTests
    {
        private PlugBoardService _plugBoardService;
        private PlugBoard _plugBoard;

        [SetUp]
        public void SetUp()
        {
            _plugBoard = new PlugBoard(new Dictionary<char, char>());
            _plugBoard.Plugs.Add('T', 'A');
            _plugBoard.Plugs.Add('Z', 'N');
            _plugBoardService = new PlugBoardService(_plugBoard);
        }

        [Test]
        [TestCase("ABCDEFG", "TBCDEFG")]
        [TestCase("AAAA", "TTTT")]
        [TestCase("TTTT", "AAAA")]
        [TestCase("HHHH", "HHHH")]
        public void SwapMessage_WhenCalled_SwapingCharactersInMessage(string message, string expected)
        {
            var actual = _plugBoardService.SwapMessage(message);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase('Z', 'N')]
        public void SwapChar_WhenCalled_SwapingCharacters(char ch, char expected)
        {
            var actual = _plugBoardService.SwapChar(ch);
            Assert.AreEqual(expected, actual);
        }
    }
}
