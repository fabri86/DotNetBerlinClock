using System.Collections.Generic;

namespace BerlinClock.Helpers
{
    public interface IOutputFormatter
    {
        string Format(IEnumerable<string> parts);
    }
}