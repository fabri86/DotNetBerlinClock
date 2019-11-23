using Autofac;
using BerlinClock.TimeEntityMappers;
using BerlinClockUtils;

namespace BerlinClock
{
    public class TimeEntityMapperResolver : ITimeEntityMapperResolver
    {
        private readonly ILifetimeScope _scope;

        public TimeEntityMapperResolver(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public ITimeEntityMapper GetByName(LampsMapperKey mapperKey)
        {
            var temp = _scope.ResolveKeyed<ITimeEntityMapper>(mapperKey, new []{new NamedParameter("lampsNumber", 3) });
            return _scope.ResolveKeyed<ITimeEntityMapper>(mapperKey);
        }
    }
}