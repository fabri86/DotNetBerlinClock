using System;
using System.Collections.Generic;
using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using BerlinClockUtils;
using Moq;
using NUnit.Framework;

namespace BerlinClock.UnitTests
{
    public class TimeConverterTests
    {
        private const string NewLine = "\r\n";

        private Mock<ITimeSpanDeserializer> _deserializer;
        private Mock<ITimeEntityMapperResolver> _mapperResolver;
        private Mock<IOutputFormatter> _formatter;

        private TimeConverter _timeConverter;
        private Mock<ITimeEntityMapper> _blinkingMapper;
        private Mock<ITimeEntityMapper> _fourLampsMapper;
        private Mock<ITimeEntityMapper> _customLampsMapper;

        [SetUp]
        public void Setup()
        {
            _deserializer = new Mock<ITimeSpanDeserializer>(MockBehavior.Strict);
            _formatter = new Mock<IOutputFormatter>(MockBehavior.Strict);

            _blinkingMapper = new Mock<ITimeEntityMapper>(MockBehavior.Strict);
            _blinkingMapper.Setup(x => x.GetCode(30, LampUtils.Yellow)).Returns("Y");

            _fourLampsMapper = new Mock<ITimeEntityMapper>(MockBehavior.Strict);
            _fourLampsMapper.Setup(x => x.GetCode(2, LampUtils.Red)).Returns("RROO");
            _fourLampsMapper.Setup(x => x.GetCode(3, LampUtils.Red)).Returns("RRRO");
            _fourLampsMapper.Setup(x => x.GetCode(1, LampUtils.Yellow)).Returns("YOOO");

            _customLampsMapper = new Mock<ITimeEntityMapper>(MockBehavior.Strict);
            _customLampsMapper.Setup(x => x.GetCode(9, LampUtils.Yellow)).Returns("YYRYYRYYROO");

            _mapperResolver = new Mock<ITimeEntityMapperResolver>(MockBehavior.Strict);
            _mapperResolver.Setup(x => x.GetByName(LampsMapperKey.Blink)).Returns(_blinkingMapper.Object);
            _mapperResolver.Setup(x => x.GetByName(LampsMapperKey.FourLamps)).Returns(_fourLampsMapper.Object);
            _mapperResolver.Setup(x => x.GetByName(LampsMapperKey.Custom)).Returns(_customLampsMapper.Object);

            _timeConverter = new TimeConverter(_deserializer.Object, _mapperResolver.Object, _formatter.Object);
        }

        [Test]
        public void MustReturnEmptyStringWhenUserInputIsEmpty()
        {
            var convertedTime = _timeConverter.ConvertTime(string.Empty).Result;

            Assert.AreEqual(string.Empty, convertedTime, "Expected an empty string when providing an empty input");
        }

        [Test]
        public void MustReturnEmptyStringWhenCannotDeserializeUserInput()
        {
            TimeSpan timeSpan;

            _deserializer.Setup(x => x.TryDeserializeFromInput(It.IsAny<string>(), out timeSpan))
                .Callback(() => { timeSpan = new TimeSpan(); })
                .Returns(false);

            var convertedTime = _timeConverter.ConvertTime(It.IsAny<string>()).Result;

            Assert.AreEqual(string.Empty, convertedTime, "Expected an empty string when providing an invalid input");
        }

        [Test]
        public void MustReturnTheExpectedOutputForAGivenInput()
        {
            var userInput = "13:46:30";
            TimeSpan timeSpan = new TimeSpan(13, 46, 30);

            var expectedOutput = $"{LampUtils.Yellow}" +
                                 $"{NewLine}" +
                                 $"{LampUtils.Red}{LampUtils.Red}{LampUtils.Off}{LampUtils.Off}" +
                                 $"{NewLine}" +
                                 $"{LampUtils.Red}{LampUtils.Red}{LampUtils.Red}{LampUtils.Off}" +
                                 $"{NewLine}" +
                                 $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                                 $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                                 $"{LampUtils.Yellow}{LampUtils.Yellow}{LampUtils.Red}" +
                                 $"{LampUtils.Off}{LampUtils.Off}" +
                                 $"{NewLine}" +
                                 $"{LampUtils.Yellow}{LampUtils.Off}{LampUtils.Off}{LampUtils.Off}";

            _deserializer.Setup(x => x.TryDeserializeFromInput(userInput, out timeSpan)).Returns(true);
            _formatter.Setup(x => x.Format(It.IsAny<IEnumerable<string>>())).Returns(expectedOutput);

            var converted = _timeConverter.ConvertTime(userInput).Result;

            Assert.AreEqual(expectedOutput, converted, "Expected a different output");
        }
    }
}