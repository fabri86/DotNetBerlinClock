using BerlinClockUtils;
using BerlinClock.Helpers;
using BerlinClock.TimeEntityMappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private readonly ITimeSpanDeserializer _timeSpanDeserializer;
        private readonly IOutputFormatter _outputFormatter;
        private readonly ITimeEntityMapper _simpleTEMapper;
        private readonly ITimeEntityMapper _complexTEMapper;
        private readonly ITimeEntityMapper _blinkTEMapper;

        public TimeConverter(ITimeSpanDeserializer timeSpanDeserializer, ITimeEntityMapperResolver resolver, IOutputFormatter outputFormatter)
        {
            _timeSpanDeserializer = timeSpanDeserializer;
            _outputFormatter = outputFormatter;
            _blinkTEMapper = resolver.GetByName(LampsMapperKey.Blink);
            _simpleTEMapper = resolver.GetByName(LampsMapperKey.FourLamps);
            _complexTEMapper = resolver.GetByName(LampsMapperKey.Custom);
        }

        public async Task<string> ConvertTime(string aTime)
        {
            if (string.IsNullOrEmpty(aTime) || !_timeSpanDeserializer.TryDeserializeFromInput(aTime, out var timeSpan))
            {
                return string.Empty;
            }

            var dict = new Dictionary<int, Task<string>>
            {
                {0, Task.Factory.StartNew(() => _blinkTEMapper.GetCode(timeSpan.Seconds, LampUtils.Yellow))},
                {1, Task.Factory.StartNew(() => _simpleTEMapper.GetCode(timeSpan.Hours / 5, LampUtils.Red))},
                {2, Task.Factory.StartNew(() => _simpleTEMapper.GetCode(timeSpan.Hours % 5, LampUtils.Red))},
                {3, Task.Factory.StartNew(() => _complexTEMapper.GetCode(timeSpan.Minutes / 5, LampUtils.Yellow))},
                {4, Task.Factory.StartNew(() => _simpleTEMapper.GetCode(timeSpan.Minutes % 5, LampUtils.Yellow))}
            };

            var allPartsTask = Task.WhenAll(dict.Values);
            await allPartsTask;

            return _outputFormatter.Format(allPartsTask.Result);
        }
    }
}