using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Specs.TimeEntityMapperSpecs
{
    [Binding]
    public class HoursMapper
    {
        private readonly ITimeEntityMapper _timeMapper = new FourLampsTimeEntityMapper(new LampsRowBuilder());
        private int _number;
        private char _color;

        [Given(@"the value for the hours row is ""(.*)""")]
        public void GivenTheValueForTheHoursRowIs(int number)
        {
            _number = number;
        }

        [Given(@"the color for the hours row is ""(.*)""")]
        public void GivenTheColorForTheHoursRowIs(char color)
        {
            _color = color;
        }

        [Then(@"the hours row sequence should look like ""(.*)""")]
        public void ThenTheHoursRowSequenceShouldLookLike(string expectedSequence)
        {
            Assert.AreEqual(expectedSequence, _timeMapper.GetCode(_number, _color));
        }
    }
}