using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using BerlinClockUtils;
using Moq;
using NUnit.Framework;
using System.Text;

namespace BerlinClock.UnitTests.TimeEntityMappers
{
    public class CustomTimeEntityMapperForFirstMinutesLampsRow
    {
        private CustomTimeEntityMapperWithSpecialRecurringRedLamp _mapper;
        private Mock<ILampsRowBuilder> _lampsRowBuilder;

        [SetUp]
        public void Setup()
        {
            _lampsRowBuilder = new Mock<ILampsRowBuilder>(MockBehavior.Strict);
            _mapper = new CustomTimeEntityMapperWithSpecialRecurringRedLamp(_lampsRowBuilder.Object, 11, 3);
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenNoLampNeedsToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(0, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenOneLampsNeedsToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(1, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenTwoLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(2, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenThreeLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(3, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenFourLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(4, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenFiveLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(5, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenSixLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(6, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenSevenLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Off}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(7, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenEightLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Off}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(8, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenNineLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Off}{LampUtils.Off}";

            var code = _mapper.GetCode(9, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenTenLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Off}";

            var code = _mapper.GetCode(10, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        [Test]
        public void MustReturnTheExpectedSequenceWhenElevenLampsNeedToBeSwitchedOn()
        {
            _lampsRowBuilder.Setup(x => x.BuildSwitchedOffLampsRow(11)).Returns(new StringBuilder(GetElevenOffLampsRow()));

            var expectedCode = $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                               $"{LampUtils.Yellow}{LampUtils.Yellow}";

            var code = _mapper.GetCode(11, LampUtils.Yellow);

            Assert.AreEqual(expectedCode, code, "Expected a different sequence");
        }

        private static string GetElevenOffLampsRow()
        {
            return $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                   $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                   $"{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}" +
                   $"{LampUtils.Off}{LampUtils.Off}";
        }
    }
}