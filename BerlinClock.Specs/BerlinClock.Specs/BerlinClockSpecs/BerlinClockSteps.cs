using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using BerlinClockUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TechTalk.SpecFlow;

namespace BerlinClock.Specs.BerlinClockSpecs
{
    [Binding]
    public class BerlinClockSteps
    {
        private readonly BerlinClockApp _berlinClock;
        private readonly Mock<ITimeEntityMapperResolver> _resolverMock = new Mock<ITimeEntityMapperResolver>(MockBehavior.Strict);
        
        public BerlinClockSteps()
        {
            _resolverMock.Setup(x => x.GetByName(LampsMapperKey.FourLamps))
                .Returns(new FourLampsTimeEntityMapper(new LampsRowBuilder()));

            _resolverMock.Setup(x => x.GetByName(LampsMapperKey.Custom))
                .Returns(new CustomTimeEntityMapperWithSpecialRecurringRedLamp(new LampsRowBuilder(), 11, 3));

            _resolverMock.Setup(x => x.GetByName(LampsMapperKey.Blink)).Returns(new BlinkingTimeEntityMapper());

            _berlinClock = new BerlinClockApp(
                new TimeConverter(new TimeSpanDeserializer(new TimePartsValidator()), _resolverMock.Object, new OutputFormatter()));
        }

        private string _userInput;

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string userInput)
        {
            _userInput = userInput;
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string berlinClockTime)
        {
            Assert.AreEqual(berlinClockTime, _berlinClock.GetBerlinClockTime(_userInput));
        }
    }
}