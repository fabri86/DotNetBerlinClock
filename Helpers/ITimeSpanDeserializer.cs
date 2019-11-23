using System;

namespace BerlinClock.Helpers
{
    public interface ITimeSpanDeserializer
    {
        bool TryDeserializeFromInput(string input, out TimeSpan timeSpan);
    }
}