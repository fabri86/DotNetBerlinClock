using BerlinClock.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.Specs.HelpersSpecs
{
    [Binding]
    public class TimePartsValidatorSteps
    {
        readonly TimePartsValidator _validator = new TimePartsValidator();
        private int _hours;
        private int _minutes;
        private int _seconds;

        [Given(@"the values (.*) hours (.*) minutes (.*) seconds")]
        public void GivenTheValuesHoursMinutesSeconds(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }
        
        [Then(@"the validation should return false")]
        public void ThenTheValidationShouldReturnFalse()
        {
            Assert.IsFalse(_validator.IsValidTime(_hours, _minutes, _seconds));
        }
        
        [Then(@"the validation should return true")]
        public void ThenTheValidationShouldReturnTrue()
        {
            Assert.IsTrue(_validator.IsValidTime(_hours, _minutes, _seconds));
        }
    }
}