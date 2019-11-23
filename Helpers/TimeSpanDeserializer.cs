using System;

namespace BerlinClock.Helpers
{
    public class TimeSpanDeserializer : ITimeSpanDeserializer
    {
        private readonly ITimePartsValidator _timePartsValidator;
        private const char _separator = ':';

        public TimeSpanDeserializer(ITimePartsValidator timePartsValidator)
        {
            _timePartsValidator = timePartsValidator;
        }

        public bool TryDeserializeFromInput(string input, out TimeSpan timeSpan)
        {
            var parts = input.Split(_separator);

            if (parts.Length == 3)
            {
                try
                {
                    var hours = int.Parse(parts[0]);
                    var minutes = int.Parse(parts[1]);
                    var seconds = int.Parse(parts[2]);

                    if (_timePartsValidator.IsValidTime(hours, minutes, seconds))
                    {
                        timeSpan = new TimeSpan(hours, minutes, seconds);
                        return true;
                    }

                }
                catch (Exception)
                {
                    timeSpan = new TimeSpan();
                    return false;
                }
            }
            
            timeSpan = new TimeSpan();
            return false;
        }
    }
}