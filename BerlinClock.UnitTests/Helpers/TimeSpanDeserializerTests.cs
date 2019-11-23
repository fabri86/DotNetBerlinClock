using System;
using BerlinClock.Helpers;
using Moq;
using NUnit.Framework;

namespace BerlinClock.UnitTests.Helpers
{
    public class TimeSpanDeserializerTests
    {
        private TimeSpanDeserializer _deserializer;
        private Mock<ITimePartsValidator> _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new Mock<ITimePartsValidator>(MockBehavior.Strict);
            _deserializer = new TimeSpanDeserializer(_validator.Object);
        }

        [Test]
        public void MustReturnADefaultTimeSpanIfTheInputDoesNotContainExactlyThreeParts()
        {
            var input = "1:2:3:4";

            var result = _deserializer.TryDeserializeFromInput(input, out var timeSpan);

            Assert.AreEqual(false, result, "Should not be able to deseriialize");
            Assert.AreEqual(new TimeSpan(), timeSpan, "Expected a default TimeSpan instance");
        }

        [Test]
        public void MustReturnADefaultTimeSpanIfTheInputTimePartsAreNotAllValidIntegers()
        {
            var input = "23:27:z";

            var result = _deserializer.TryDeserializeFromInput(input, out var timeSpan);

            Assert.AreEqual(false, result, "Should not be able to deseriialize");
            Assert.AreEqual(new TimeSpan(), timeSpan, "Expected a default TimeSpan instance");
        }

        [Test]
        public void MustReturnTheProperTimeSpanWhenTheInputTimePartsAreValid()
        {
            var input = "23:27:16";
            _validator.Setup(x => x.IsValidTime(23, 27, 16)).Returns(true);

            var result = _deserializer.TryDeserializeFromInput(input, out var timeSpan);

            Assert.AreEqual(true, result, "Should be able to deserialize");
            Assert.AreEqual(new TimeSpan(23, 27, 16), timeSpan, "Expected a different TimeSpan value");
        }
    }
}