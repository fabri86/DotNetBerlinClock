using System.Linq;
using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Specs.TimeEntityMapperSpecs
{
    [Binding]
    public class FirstMinutesRowMapper
    {
        private readonly ITimeEntityMapper _timeMapper = new CustomTimeEntityMapperWithSpecialRecurringRedLamp(new LampsRowBuilder(), 11, 3);
        private int _number;
        private char _color;
        private char _colorForQuarters;

        [Given(@"the value for the first minute row is ""(.*)""")]
        public void GivenTheValueForTheFirstMinuteRowIs(int number)
        {
            _number = number;
        }

        [Given(@"the colors are ""(.*)""")]
        public void GivenTheColorsAre(string colors)
        {
            string[] strings = colors.Split(',');
            _color = strings.First()[0];
            _colorForQuarters = strings.Last()[0];
        }

        [Then(@"the first minute row sequence should look like ""(.*)""")]
        public void ThenTheFirstMinuteRowSequenceShouldLookLike(string expectedSequence)
        {
            Assert.AreEqual(expectedSequence,
                _timeMapper.GetCode(_number, _color));
        }
    }
}