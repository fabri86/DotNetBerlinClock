using BerlinClock.Helpers;
using BerlinClockUtils;

namespace BerlinClock.TimeEntityMappers
{
    public class CustomTimeEntityMapperWithSpecialRecurringRedLamp : ITimeEntityMapper
    {
        private readonly ILampsRowBuilder _lampsRowBuilder;
        private readonly int _lampsNumber;
        private readonly int _recurring;

        public CustomTimeEntityMapperWithSpecialRecurringRedLamp(ILampsRowBuilder lampsRowBuilder, int lampsNumber = 11, int recurring = 3)
        {
            _lampsRowBuilder = lampsRowBuilder;
            _lampsNumber = lampsNumber;
            _recurring = recurring;
        }

        public string GetCode(int value, char color)
        {
            var switchedOffLamp = _lampsRowBuilder.BuildSwitchedOffLampsRow(_lampsNumber);

            if (value <= 0)
            {
                return switchedOffLamp.ToString();
            }

            for (var i = 0; i < value && i < _lampsNumber; i++)
            {
                switchedOffLamp[i] = MathUtils.IsMultipleOf(i+1,_recurring) ? LampUtils.Red : color;
            }

            return switchedOffLamp.ToString();
        }
    }
}