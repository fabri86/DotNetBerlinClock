using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using BerlinClockUtils;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Text;

namespace BerlinClock.UnitTests.TimeEntityMappers
{
    public class FourLampsTimeEntityMapperTests
    {
        private FourLampsTimeEntityMapper _mapper;

        [SetUp]
        public void Setup()
        {
            var lampsRowBuilder = new Mock<ILampsRowBuilder>(MockBehavior.Strict);
            var fourOffLampsRowSequence = $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}";
            lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(4)).Returns(new StringBuilder(fourOffLampsRowSequence));
            _mapper = new FourLampsTimeEntityMapper(lampsRowBuilder.Object);
        }

        [Test]
        public void MustReturnARowOfFourOffLamps()
        {
            var expectedCode = $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(0, LampUtils.Red);

            Assert.AreEqual(expectedCode, code, "Expected a row consisting of four Off lamps");
        }

        [Test]
        public void MustReturnARowConsistingOfFourLampsWithTheFirstOneSwitchedOnAndRed()
        {
            var expectedCode = $"{LampUtils.Red}{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(1, LampUtils.Red);

            Assert.AreEqual(expectedCode, code, "Expected a row consisting of four lamps, the first red and the rest off");
        }

        [Test]
        public void MustReturnARowConsistingOfFourLampsWithTheFirstTwoSwitchedOnAndYellow()
        {
            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(2, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a row consisting of first two lamps yellow and last two off");
        }

        [Test]
        public void MustReturnARowConsistingOfFourLampsWithTheFirstThreeSwitchedOnAndRedAndLastOneSwitchedOff()
        {
            var expectedCode = $"{LampUtils.Red}{LampUtils.Red}{LampUtils.Red}{LampUtils.Off}";

            var code = _mapper.GetCode(3, LampUtils.Red);

            Assert.AreEqual(expectedCode, code, "Expected a row consisting of first three red lamps switched on and last one off");
        }

        [Test]
        public void MustReturnARowConsistingOfFourSwitchedOnLampsWithColorPassedAsArgument()
        {
            var expectedCode = Enumerable.Repeat(LampUtils.Red, 4).ToArray();

            var code = _mapper.GetCode(4, LampUtils.Red);

            Assert.AreEqual(expectedCode, code, "Expected a row consisting of four yellow switched on lamps");
        }
    }
}