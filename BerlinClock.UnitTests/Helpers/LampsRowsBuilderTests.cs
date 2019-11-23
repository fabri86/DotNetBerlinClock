using Assert = NUnit.Framework.Assert;
using BerlinClock.Helpers;
using BerlinClockUtils;
using NUnit.Framework;
using System;
using System.Linq;

namespace BerlinClock.UnitTests.Helpers
{
    public class LampsRowBuildersTests
    {
        private LampsRowBuilder _builder;

        [SetUp]
        public void Setup()
        {
            _builder = new LampsRowBuilder();
        }

        [Test]
        public void MustThrowWhenPassingANegativeNumberAsParameter()
        {
            Assert.Throws<ArgumentException>(() => _builder.BuildSwitchedOffLampsRow(-1000));
        }

        [Test]
        public void MustThrowWhenPassingZeroAsParameter()
        {
            Assert.Throws<ArgumentException>(() => _builder.BuildSwitchedOffLampsRow(-1000));
        }

        [Test]
        public void MustReturnTheTheProperLampsRowWhenPassingAsParameter2()
        {
            var lampsRow = _builder.BuildSwitchedOffLampsRow(2);

            Assert.AreEqual(GetExpectedLampsRow(2), lampsRow.ToString(), "Expected two Off-value chars for lampsRow");
        }

        [Test]
        public void MustReturnTheTheProperLampsRowWhenPassingAsParameter5()
        {
            var lampsRow = _builder.BuildSwitchedOffLampsRow(5);

            Assert.AreEqual(GetExpectedLampsRow(5), lampsRow.ToString(), "Expected five Off-value chars for lampsRow");
        }

        private char[] GetExpectedLampsRow(int times)
        {
            return Enumerable.Repeat(LampUtils.Off, times).ToArray();
        } 
    }
}