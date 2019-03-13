using Autofac.Extras.Moq;
using EnigmaLibrary.Boards;
using NUnit.Framework;
using System.Collections.Generic;

namespace EnigmaLibrary.Tests.BoardsTests
{
    [TestFixture]
    public class PluginBoardTests
    {
        [Test]
        [TestCase('A', 'T')]
        [TestCase('B', 'B')]
        [TestCase('D', 'H')]
        [TestCase('J', 'L')]
        [TestCase('X', 'X')]
        public void SwapMessage_WhenCalled_ExpectedBehavior(char input, char expected)
        {
            using (var mock = AutoMock.GetLoose())
            {
                var sut = mock.Create<PluginBoard>();
                sut.Plugins = new Dictionary<char, char> { { 'A', 'T' }, { 'D', 'H' }, { 'L', 'J' } };
                var actual = sut.SwapChar(input);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}
