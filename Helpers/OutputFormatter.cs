using System.Collections.Generic;

namespace BerlinClock.Helpers
{
    public class OutputFormatter : IOutputFormatter
    {
        private const string NewLine = "\r\n";

        public string Format(IEnumerable<string> parts)
        {
            return string.Join(NewLine, parts);
        }
    }
}