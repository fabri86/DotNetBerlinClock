using BerlinClock.Helpers;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace BerlinClock.UnitTests.Helpers
{
    public class OutputFormatterTests
    {
        private OutputFormatter _formatter;
        private const string _firstToken = "first";
        private const string _secondToken = "second";
        private const string _thirdToken = "third";

        [SetUp]
        public void Setup()
        {
            _formatter = new OutputFormatter();
        }

        [Test]
        public void MustReturnStringEmptyWhenPassingAnEmptyCollectionOfToken()
        {
            Assert.AreEqual(string.Empty, _formatter.Format(Enumerable.Empty<string>()), "Expected an empty string");
        }

        [Test]
        public void MustProperlyFormatTwoTokens()
        {
            var output = _formatter.Format(new List<string> {_firstToken, _secondToken});

            Assert.AreEqual($"{_firstToken}\r\n{_secondToken}", output, "Expected a different output");
        }

        [Test]
        public void MustProperlyFormatThreeTokens()
        {
            var output = _formatter.Format(new List<string> { _firstToken, _secondToken, _thirdToken });

            Assert.AreEqual($"{_firstToken}\r\n{_secondToken}\r\n{_thirdToken}", output, "Expected a different output");
        }
    }
}