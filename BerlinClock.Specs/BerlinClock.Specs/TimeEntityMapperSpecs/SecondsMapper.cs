using BerlinClock.TimeEntityMappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Specs.TimeEntityMapperSpecs
{
    [Binding]
    public class SecondsMapper
    {
        private readonly ITimeEntityMapper _timeMapper = new BlinkingTimeEntityMapper();
        private int _number;
        private char _color;

        [Given(@"the value for the seconds is ""(.*)""")]
        public void WhenTheNumberIs(int number)
        {
            _number = number;
        }

        [Given(@"the colors for the seconds is ""(.*)""")]
        public void WhenTheColourIs(char color)
        {
            _color = color;
        }

        [Then(@"the code value for the blinking led should look like ""(.*)""")]
        public void ThenTheHoursSequenceShouldLookLike(string expectedHoursSequence)
        {
            Assert.AreEqual(expectedHoursSequence, _timeMapper.GetCode(_number, _color));
        }
    }
}