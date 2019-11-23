using System;
using System.Text;
using BerlinClockUtils;

namespace BerlinClock.Helpers
{
    public class LampsRowBuilder : ILampsRowBuilder
    {
        public StringBuilder BuildSwitchedOffLampsRow(int lampsNumber)
        {
            if (lampsNumber <= 0)
            {
                throw new ArgumentException("Argument must be greater than 0", nameof(lampsNumber));
            }
            
            var switchedOffLamp = new StringBuilder(lampsNumber);

            for (var i = 0; i < lampsNumber; i++)
            {
                switchedOffLamp.Append(LampUtils.Off);
            }

            return switchedOffLamp;
        }
    }
}