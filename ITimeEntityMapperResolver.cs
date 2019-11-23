using BerlinClock.TimeEntityMappers;
using BerlinClockUtils;

namespace BerlinClock
{
    public interface ITimeEntityMapperResolver
    {
        ITimeEntityMapper GetByName(LampsMapperKey mapperKey);
    }
}