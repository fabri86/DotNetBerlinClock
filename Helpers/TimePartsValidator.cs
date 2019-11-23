namespace BerlinClock.Helpers
{
    public class TimePartsValidator : ITimePartsValidator
    {
        public bool IsValidTime(int hours, int minutes, int seconds)
        {
            return IsValidHour(hours) && IsValidMinuteOrSecond(minutes) && IsValidMinuteOrSecond(seconds);
        }

        private static bool IsValidHour(int hours)
        {
            return hours >= 0 && hours <= 23;
        }

        private static bool IsValidMinuteOrSecond(int value)
        {
            return value >= 0 && value <= 59;
        }
    }
}