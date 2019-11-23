using BerlinClock.TimeEntityMappers;
using BerlinClockUtils;
using NUnit.Framework;

namespace BerlinClock.UnitTests.TimeEntityMappers
{
    public class BlinkingTimeEntityMapperTests
    {
        private BlinkingTimeEntityMapper _mapper;

        [SetUp]
        public void Setup()
        {
            _mapper = new BlinkingTimeEntityMapper();
        }

        [Test]
        public void MustReturnOffCodeWhenPassingAnOddValue()
        {
            var code = _mapper.GetCode(23, LampUtils.Yellow);

            Assert.AreEqual(LampUtils.Off.ToString(), code, "Expected a lamp Off code");
        }

        [Test]
        public void MustReturnTheCodeConsistingOfThePassedColorWhenPassingAnEvenValue()
        {
            var code = _mapper.GetCode(6, LampUtils.Red);

            Assert.AreEqual(LampUtils.Red.ToString(), code, "Expected a lamp Off code");
        }
    }
}