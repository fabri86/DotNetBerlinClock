using BerlinClock.Helpers;
using NUnit.Framework;

namespace BerlinClock.UnitTests.Helpers
{
    public class TimePartsValidatorTests
    {
        private TimePartsValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new TimePartsValidator();
        }

        [Test]
        public void MustReturnFalseIfHoursAreANegativeNumber()
        {
            Assert.IsFalse(_validator.IsValidTime(-5, 23, 16), "Hours cannot be negative");
        }

        [Test]
        public void MustReturnFalseIfMinutesAreANegativeNumber()
        {
            Assert.IsFalse(_validator.IsValidTime(5, -25, 17), "Minutes cannot be negative");
        }

        [Test]
        public void MustReturnFalseIfSecondsAreANegativeNumber()
        {
            Assert.IsFalse(_validator.IsValidTime(17, 23, -4), "Seconds cannot be negative");
        }

        [Test]
        public void MustReturnFalseIfHoursAreGreaterThan23()
        {
            Assert.IsFalse(_validator.IsValidTime(24, 23, 16), "Hours cannot be greater than 23");
        }

        [Test]
        public void MustReturnFalseIfMinutesAreGreaterThan59()
        {
            Assert.IsFalse(_validator.IsValidTime(23, 60, 59), "Minutes cannot be greater than 59");
        }

        [Test]
        public void MustReturnFalseIfSecondsAreGreaterThan59()
        {
            Assert.IsFalse(_validator.IsValidTime(23, 59, 60), "Minutes cannot be greater than 59");
        }

        [Test]
        public void MustReturnTrueWhenAValidTimeIsProvided()
        {
            Assert.IsTrue(_validator.IsValidTime(1, 1, 1), "Expected true since the time passed is valid");
        }

        [Test]
        public void MustReturnTrueWhenMidnightIsTheTimeProvided()
        {
            Assert.IsTrue(_validator.IsValidTime(0, 0, 0), "Expected true since the time passed is valid");
        }
    }
}