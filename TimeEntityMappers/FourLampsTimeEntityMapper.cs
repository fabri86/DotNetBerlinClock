using BerlinClock.Helpers;

namespace BerlinClock.TimeEntityMappers
{
    public class FourLampsTimeEntityMapper : ITimeEntityMapper
    {
        private readonly ILampsRowBuilder _lampsRowBuilder;

        public FourLampsTimeEntityMapper(ILampsRowBuilder lampsRowBuilder)
        {
            _lampsRowBuilder = lampsRowBuilder;
        }

        public string GetCode(int value, char color)
        {
            var switchedOffLamp = _lampsRowBuilder.BuildSwitchedOffLampsRow(4);

            if (value <= 0)
            {
                return switchedOffLamp.ToString();
            }

            for (var i = 0; i < value && i < 4; i++)
            {
                switchedOffLamp[i] = color;
            }

            return switchedOffLamp.ToString();
        }
    }
}