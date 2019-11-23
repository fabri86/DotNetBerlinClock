using BerlinClockUtils;

namespace BerlinClock.TimeEntityMappers
{
    public class BlinkingTimeEntityMapper : ITimeEntityMapper
    {
        public string GetCode(int value, char color)
        {
            return MathUtils.IsEven(value) ? color.ToString() : LampUtils.Off.ToString();
        }
    }
}