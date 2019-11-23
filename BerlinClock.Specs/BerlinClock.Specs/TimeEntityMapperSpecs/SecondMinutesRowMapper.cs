using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Specs.TimeEntityMapperSpecs
{
    [Binding]
    public class SecondMinutesRowMapper
    {
        private readonly ITimeEntityMapper _timeMapper = new FourLampsTimeEntityMapper(new LampsRowBuilder());
        private int _number;
        private char _color;

        [Given(@"the value for the second minutes row is ""(.*)""")]
        public void WhenTheNumberIs(int number)
        {
            _number = number;
        }

        [Given(@"the color for the second minutes row is ""(.*)""")]
        public void WhenTheColorIs(char color)
        {
            _color = color;
        }

        [Then(@"the second minutes row sequence should look like ""(.*)""")]
        public void ThenTheHoursSequenceShouldLookLike(string expectedSequence)
        {
            Assert.AreEqual(expectedSequence, _timeMapper.GetCode(_number, _color));
        }
    }
}